using DLQMobileApp.ViewModels;
using DLQMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using Plugin.Geolocator;

namespace DLQMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FishingTripView : ContentPage
    {
        public FishingTripView()
        {
            InitializeComponent();
        }

        private async void OnWeatherTap(object sender, EventArgs args)
        {
            WeatherViewModel weatherViewModel = new WeatherViewModel();
            //var locator = CrossGeolocator.Current;
            //locator.DesiredAccuracy = 50;

            //var location = await locator.GetPositionAsync(TimeSpan.FromTicks(10000));

            //if (location != null && location.Latitude != 0)
            //{
            //    await weatherViewModel.GetWeather(location.Latitude, location.Longitude);
            //}
            //else
            {
                //MYSORE
                //await weatherViewModel.GetWeather("12.311827", "76.652985");
                //BRISBANE
                await weatherViewModel.GetWeather("-27.470125", "153.021072");
            }
            await Navigation.PushAsync(new WeatherPage());
        }

        private async void OnRulesTap(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RulesPage());
        }

        private async void OnSpeciesInfoTap(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SpeciesInfoPage());
        }

        private async void OnMapTap(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MapPage());
        }
    }
}