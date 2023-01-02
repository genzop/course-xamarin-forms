using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListExercise : ContentPage
	{
        private SearchService Service;
        private List<SearchGroup> SearchGroups;

        public ListExercise()
        {
            InitializeComponent();
            Service = new SearchService();            

            UpdateList();
		}

        private void FilterByLocation(object sender, TextChangedEventArgs e)
        {
            UpdateList(e.NewTextValue);
        }

        private void UpdateList(string filter = null)
        {
            SearchGroups = new List<SearchGroup>()
            {
                new SearchGroup("Recent Searches")
            };           

            foreach (var search in Service.GetSearches(filter))
            {
                SearchGroups[0].Add(search);
            }

            lvSearches.ItemsSource = SearchGroups;
        }

        private void DeleteSearch(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;
            Service.DeleteSearch(search.Id);
        }

        private void Refresh()
        {
            UpdateList(sbSearch.Text);
            lvSearches.EndRefresh();
        }

        private void Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Location", search.Location, "OK");
        }
	}
}