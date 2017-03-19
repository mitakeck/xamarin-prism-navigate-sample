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
using Newtonsoft.Json;

namespace test2.ViewModels
{
	public class SecondPageViewModel : BindableBase, INavigationAware
	{
		private const string url = "http://www3.city.sabae.fukui.jp/xml/refuge2/refuge2.xml";
		private const string booklogurl = "http://booklog.jp/users/mltake/all?category_id=all&status=all&sort=sort_desc&rank=all&tag=&page=1&keyword=&reviewed=&quoted=&json=true";

		public ObservableCollection<Book> Books
		{
			get
			{
				return _books;
			}
			set
			{
				SetProperty(ref _books, value);
			}
		}
		private ObservableCollection<Book> _books = new ObservableCollection<Book>();

		public SecondPageViewModel()
		{
			this.HttpGet(url);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			
		}


		public async void HttpGet(string url)
		{
			HttpClient httpClient = new HttpClient();
			Stream stream = await httpClient.GetStreamAsync(booklogurl);
			var reader = new StreamReader(stream);
			var booklogData = JsonConvert.DeserializeObject<BookLog>(reader.ToString());

			//HttpClient httpClient = new HttpClient();
			//Stream stream = await httpClient.GetStreamAsync(url);
			//test2.ViewModels.Refuges refuges;
			//_employee.Add(new Employee { DisplayName = "ccc" });

			//try
			//{
			//	XmlRootAttribute xRoot = new XmlRootAttribute();
			//	xRoot.ElementName = "dataroot";
			//	xRoot.IsNullable = true;

			//	using (var reader = new System.IO.StreamReader(stream))
			//	{
			//		var serializer = new XmlSerializer(typeof(Refuges), xRoot);
			//		refuges = (Refuges)serializer.Deserialize(reader);
			//	}

			//	foreach (var r in refuges.Refuge)
			//	{
			//		_employee.Add(new Employee { DisplayName = r.Name, ImageURL = "https://images-fe.ssl-images-amazon.com/images/I/41-cjB3hLPL._SL160_.jpg" });
			//	}
			//}
			//catch (Exception ex)
			//{
			//	while (ex != null)
			//	{
			//		System.Diagnostics.Debug.WriteLine(ex.Message);
			//		ex = ex.InnerException;
			//	}
			//	_employee.Add(new Employee { DisplayName = "aaa", ImageURL = "https://images-fe.ssl-images-amazon.com/images/I/41-cjB3hLPL._SL160_.jpg" });
			//}
			//_employee.Add(new Employee { DisplayName = "bbb", ImageURL = "https://images-fe.ssl-images-amazon.com/images/I/41-cjB3hLPL._SL160_.jpg" });
		}
	}
}
