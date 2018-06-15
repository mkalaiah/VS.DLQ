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
    public partial class EngagementPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public EngagementPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Ask A Question",
                "Report Illegal Activity",
                "Report an issue - Submit",
                "Complete a Survey"
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            if (((ListView)sender).SelectedItem.ToString().Equals(Items[0]))
            {
                await Navigation.PushAsync(new AskQuestion());
            }
            else if (((ListView)sender).SelectedItem.ToString().Equals(Items[1]))
            {
                await Navigation.PushAsync(new ReportIllegal());
            }
            else if (((ListView)sender).SelectedItem.ToString().Equals(Items[2]))
            {
                await Navigation.PushAsync(new ReportIssuePage());
            }

                //Deselect Item
                ((ListView)sender).SelectedItem = null;
        }
    }
}
