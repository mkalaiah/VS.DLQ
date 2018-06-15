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
            Item.UserId = 3;
            Item.IssueDescription = DescriptionField.Text;

            viewModels.SubmitIssue(Item);

            if (viewModels.SaveSuccess)
            {
                await DisplayAlert("", "Question sucessfully submitted", "OK");
            }
            else
            {
                await DisplayAlert("", "Question couldnot be submitted", "OK");
            }

            await Navigation.PopAsync();
        }
    }
}