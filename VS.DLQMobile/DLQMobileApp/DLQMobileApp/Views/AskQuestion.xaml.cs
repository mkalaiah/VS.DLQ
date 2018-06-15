using DLQMobileApp.Models;
using DLQMobileApp.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DLQMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AskQuestion : ContentPage
    {
        public CreateQueryDto Item { get; set; }

        private AskQuestionViewModel viewModels = new AskQuestionViewModel();

        public AskQuestion ()
		{
            Item = new CreateQueryDto();
			InitializeComponent ();
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            Item.Question = QuestionFeild.Text;
            Item.UserName = "testuser";
            Item.UserId = 3;
            Item.EmailId = "mamatha.kalaiah@softvision.com";

            viewModels.SubmitQuestion(Item);

            if(viewModels.SaveSuccess)
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