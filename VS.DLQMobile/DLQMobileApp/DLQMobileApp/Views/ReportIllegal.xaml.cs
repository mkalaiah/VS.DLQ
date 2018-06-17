using DLQMobileApp.Models;
using DLQMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DLQMobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReportIllegal : ContentPage
	{
        public CreateReportIllegalActivityDto Item { get; set; }

        private ReportIllegalActivtyViewModel viewModels = new ReportIllegalActivtyViewModel();

		public ReportIllegal ()
		{
            Item = new CreateReportIllegalActivityDto();
			InitializeComponent ();

            DateView.Date = DateTime.Today ;
		}

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            Item.VesselNo = VehicleNoField.Text;
            Item.UserName = "testuser";
            Item.UserId = 1;
            Item.Description = DescriptionField.Text;
            Item.IllegalActivityDate = DateView.Date;

            bool result = await viewModels.SubmitIllegalActivity(Item);

            if (result)
            {
                await DisplayAlert("", "Illegal Activity sucessfully reported", "OK");
            }
            else
            {
                await DisplayAlert("", "Illegal Activity could not be reported", "OK");
            }

            await Navigation.PopAsync();
        }
    }
}