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
	public partial class SearchBar : ContentPage
	{
		public SearchBar ()
		{
			InitializeComponent ();
            listView.ItemsSource = GetContacts();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {            
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        private IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(C => C.Name.StartsWith(searchText));
        }
    }
}