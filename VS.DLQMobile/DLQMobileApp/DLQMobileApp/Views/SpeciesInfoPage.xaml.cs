using DLQMobileApp.Models;
using DLQMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DLQMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeciesInfoPage : ContentPage
    {
        public List<SpeciesDto> Items { get; set; }

        private SpeciesViewModel viewModels = new SpeciesViewModel();

        public SpeciesInfoPage()
        {
            InitializeComponent();

            Items = viewModels.GetRules();

            //Items = new ObservableCollection<string>
            //{
            //    "Australian bass",
            //    "Barcoo grunter",
            //    "Barramundi",
            //    "Bloomfield river cod",
            //    "Freshwater catfish  (eel tailed catfish)",
            //    "Freshwater sawfish",
            //    "Golden perch (yellowbelly)",
            //    "Jungle perch",
            //    "Khaki grunter",
            //    "Longfin eel"
            //};

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var selectedItem = (SpeciesDto)((ListView)sender).SelectedItem;

            if (Items.Exists(x => x.Name.Equals(selectedItem.Name)))
            {
                RulesDetailsViewModel.webObject.Title = selectedItem.Name;
                RulesDetailsViewModel.webObject.RuleURL = selectedItem.URL;
            }

            await Navigation.PushAsync(new RulesDetailPage());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
