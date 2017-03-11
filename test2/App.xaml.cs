﻿using Prism.Unity;
using test2.Views;
using Xamarin.Forms;

namespace test2
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			//NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
			NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<SecondPage>();
		}
	}
}

