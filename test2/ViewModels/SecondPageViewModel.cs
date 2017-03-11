using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace test2.ViewModels
{
	public class SecondPageViewModel : BindableBase, INavigationAware
	{

		private string _message;
		public string Message
		{
			get { return _message; }
			set { SetProperty(ref _message, value); }
		}

		public SecondPageViewModel()
		{

		}
		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("message"))
				Message = (string)parameters["message"] + " with Prism";
		}
	}
}
