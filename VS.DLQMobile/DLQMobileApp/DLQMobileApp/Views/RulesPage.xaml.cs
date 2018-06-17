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
    public partial class RulesPage : ContentPage
    {
        public List<RuleDto> Items { get; set; }

        private ObservableCollection<RuleDto> dataItems;

        public ObservableCollection<RuleDto> DataItems
        {
            get { return dataItems ?? (dataItems = new ObservableCollection<RuleDto>()); }
            set
            {
                dataItems = value; OnPropertyChanged();
            }
        }

        private RulesViewModel viewModels = new RulesViewModel();

        public RulesPage()
        {
            InitializeComponent();

            //Items = viewModels.GetRules();

            //Items = new ObservableCollection<string>
            //{
            //    "Fishing Equipment",
            //    "Catch Limits & Closures",
            //    "Size & Possession Limits (Tidal Waters)",
            //    "Size & Possession Limits (Fresh Waters)"
            //};

            MyListView.ItemsSource = DataItems;
        }

        protected override async void OnAppearing()
        {
            if (dataItems.Count == 0)
            {
                Items = await viewModels.GetRules();
                foreach (RuleDto rule in Items)
                    DataItems.Add(rule);
            }
            //MyListView.ItemsSource = DataItems;
        }


        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var selectedItem = (RuleDto)((ListView)sender).SelectedItem;

            if(Items.Exists(x => x.Name.Equals(selectedItem.Name)))
            {
                RulesDetailsViewModel.webObject.Title = selectedItem.Name;
                RulesDetailsViewModel.webObject.RuleURL = selectedItem.URL;
            }

            await Navigation.PushAsync(new RulesDetailPage());

            ((ListView)sender).SelectedItem = null;
        }
    }
}
