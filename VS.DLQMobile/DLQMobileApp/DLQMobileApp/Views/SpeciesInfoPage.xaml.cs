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
        public List<SpeciesDto> Items { get; set; } = null;

        private ObservableCollection<SpeciesDto> dataItems;
        public ObservableCollection<SpeciesDto> DataItems
        {
            get { return dataItems ?? (dataItems = new ObservableCollection<SpeciesDto>()); }
            set
            {
                dataItems = value; OnPropertyChanged();
            }
        }

        private SpeciesViewModel viewModels = new SpeciesViewModel();

        public SpeciesInfoPage()
        {
            InitializeComponent();

            //Items = viewModels.GetSpecies();

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

            MyListView.ItemsSource = DataItems;
        }
        protected override async void OnAppearing()
        {
            if (dataItems.Count==0)
            {
                Items = await viewModels.GetSpecies();
                foreach (SpeciesDto specii in Items)
                    DataItems.Add(specii);
            }
            //MyListView.ItemsSource = DataItems;
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
