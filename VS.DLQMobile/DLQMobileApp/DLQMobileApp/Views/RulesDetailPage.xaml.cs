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
	public partial class RulesDetailPage : ContentPage
	{
		public RulesDetailPage ()
		{
			InitializeComponent ();
            Title = RulesDetailsViewModel.webObject.Title;
            webView.Source = RulesDetailsViewModel.webObject.RuleURL.ToString();
        }
	}
}