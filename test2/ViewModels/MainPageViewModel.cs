﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace test2.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}
		private readonly INavigationService _navigationService;
		public DelegateCommand NavigateNextCommand => new DelegateCommand(NavigateNext);

		private void NavigateNext()
		{
			NavigationParameters parameter = new NavigationParameters();
			parameter.Add("message", "go to second page");
			_navigationService.NavigateAsync("SecondPage", parameter);
		}

		public MainPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("title"))
				Title = (string)parameters["title"] + " and Prism";
		}
	}
}

