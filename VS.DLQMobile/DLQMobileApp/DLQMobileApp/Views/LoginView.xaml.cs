using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DLQMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
		}

        async void OnLoginClicked (object sender, EventArgs e)
        {
            //Application.Current.MainPage = new NavigationPage(new MainPage());

            //Application.Current.MainPage.Title = "Home";

            if (!string.IsNullOrEmpty(UserName.Text) || !string.IsNullOrEmpty(Password.Text))
            {
                if (UserName.Text.ToLower().Equals("testuser") && Password.Text.Equals("TestPass123"))
                {
                    Application.Current.MainPage = new NavigationPage(new MainPage());
                    Application.Current.MainPage.Title = "Home";
                }
                else
                {
                    await DisplayAlert("Error", "Invalid User Name and Password", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Enter User Name and Password", "OK");
            }
        }

    }
}