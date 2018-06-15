
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DLQMobileApp.ViewModels;

namespace DLQMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherPage : ContentPage
	{
		public WeatherPage ()
		{
			InitializeComponent ();
            BindingContext = WeatherViewModel.WeatherObj;
		}
	}
}