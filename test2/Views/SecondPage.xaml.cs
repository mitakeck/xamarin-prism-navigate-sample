using Xamarin.Forms;
using System.Collections.ObjectModel;
            
namespace test2.Views
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage()
		{
			InitializeComponent();
		}

		private void EmployeeList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine(e.SelectedItem as ViewModels.Employee);
		}
	}
}

