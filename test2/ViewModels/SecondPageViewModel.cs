using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace test2.ViewModels
{
	public class SecondPageViewModel : BindableBase, INavigationAware
	{
		private const string url = "http://www3.city.sabae.fukui.jp/xml/refuge2/refuge2.xml";

		private string _message;
		public string Message
		{
			get { 
				return _message; 
			}
			set 
			{ 
				SetProperty(ref _message, value); 
			}
		}

		public ObservableCollection<Employee> EmployeeList
		{
			get
			{
				return _employee;
			}
			set
			{
				SetProperty(ref _employee, value);
			}
		}
		private ObservableCollection<Employee> _employee = new ObservableCollection<Employee>();

		public SecondPageViewModel()
		{
			_employee.Add(new Employee { DisplayName = "test1 hoge" });
			_employee.Add(new Employee { DisplayName = "test2 hoge" });
			_employee.Add(new Employee { DisplayName = "test3 hoge" });

			this.HttpGet(url);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("message"))
				Message = (string)parameters["message"] + " with Prism hogehoge";
		}


		public async void HttpGet(string url)
		{
			HttpClient httpClient = new HttpClient();
			Stream stream = await httpClient.GetStreamAsync(url);
			test2.ViewModels.Refuges refuges;
			_employee.Add(new Employee { DisplayName = "ccc" });

			try
			{
				XmlRootAttribute xRoot = new XmlRootAttribute();
				xRoot.ElementName = "dataroot";
				xRoot.IsNullable = true;

				using (var reader = new System.IO.StreamReader(stream))
				{
					var serializer = new XmlSerializer(typeof(Refuges), xRoot);
					refuges = (Refuges)serializer.Deserialize(reader);
				}

				foreach (var r in refuges.Refuge)
				{
					_employee.Add(new Employee { DisplayName = r.Name });
				}
			}
			catch (Exception ex)
			{
				while (ex != null)
				{
					System.Diagnostics.Debug.WriteLine(ex.Message);
					ex = ex.InnerException;
				}
				_employee.Add(new Employee { DisplayName = "aaa" });
			}
			_employee.Add(new Employee { DisplayName = "bbb" });
		}
	}
}
