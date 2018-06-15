using DLQMobileApp.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DLQMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HowTo : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public HowTo()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Check your bait",
                "Catch & Release Top Tip",
                "Tips for Fishers",
                "Tie Fishing Knots",
                "Fishing Recipes",
                "Correctly Measure a Crab",
                "Measure a Fish Correctly",
                "Fish Handling Methods"
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            RulesDetailsViewModel.webObject.Title = ((ListView)sender).SelectedItem.ToString();

            if (((ListView)sender).SelectedItem.ToString().Equals(Items[0]))
            {
                RulesDetailsViewModel.webObject.RuleURL = "https://youtu.be/wh6V_gEc1Q4";
            }
            else if (((ListView)sender).SelectedItem.ToString().Equals(Items[1]))
            {
                RulesDetailsViewModel.webObject.RuleURL = "https://youtu.be/PXBGArrnhts";
            }
            else if (((ListView)sender).SelectedItem.ToString().Equals(Items[2]))
            {
                RulesDetailsViewModel.webObject.RuleURL = "https://youtu.be/glm7KN-b_WI";
            }
            else if (((ListView)sender).SelectedItem.ToString().Equals(Items[3]))
            {
                RulesDetailsViewModel.webObject.RuleURL = "https://www.youtube.com/watch?v=3mKLbGNSvaU";
            }
            else if (((ListView)sender).SelectedItem.ToString().Equals(Items[4]))
            {
                RulesDetailsViewModel.webObject.RuleURL = "https://www.healthier.qld.gov.au/search/prepare+fish/";
            }
            else if (((ListView)sender).SelectedItem.ToString().Equals(Items[5]))
            {
                RulesDetailsViewModel.webObject.RuleURL = "https://youtu.be/q_3irh5T4a8";
            }
            else if (((ListView)sender).SelectedItem.ToString().Equals(Items[6]))
            {
                RulesDetailsViewModel.webObject.RuleURL = "https://youtu.be/c83D_D5Avew";
            }
            else
            {
                RulesDetailsViewModel.webObject.RuleURL = "https://youtu.be/T3CchTvbb_g";
            }

            await Navigation.PushAsync(new RulesDetailPage());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
