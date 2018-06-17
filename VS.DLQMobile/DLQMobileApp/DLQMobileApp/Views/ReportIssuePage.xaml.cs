using DLQMobileApp.Models;
using DLQMobileApp.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DLQMobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReportIssuePage : ContentPage
	{
        public CreateReportIssueDto Item { get; set; }

        private ReportIssueViewModel viewModels = new ReportIssueViewModel();

        public ReportIssuePage ()
		{
            Item = new CreateReportIssueDto();
			InitializeComponent ();
		}

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            Item.UserName = "testuser";
            Item.UserId = 1;
            Item.IssueDescription = DescriptionField.Text;

            bool result = await viewModels.SubmitIssue(Item);

            if (result)
            {
                await DisplayAlert("", "Issue sucessfully submitted", "OK");
            }
            else
            {
                await DisplayAlert("", "Issue could not be submitted", "OK");
            }

            await Navigation.PopAsync();
        }
    }
}