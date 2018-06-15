using DLQMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DLQMobileApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void OnFishingTripTap(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FishingTripView());
        }

        private async void OnEngagementTap(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new EngagementPage());
        }

        private async void OnUsefulInfoTap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HowTo());
        }

        private async void OnGalleryTap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage());
        }
    }
}
