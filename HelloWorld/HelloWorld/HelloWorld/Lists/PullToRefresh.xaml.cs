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
	public partial class PullToRefresh : ContentPage
	{
		public PullToRefresh ()
		{
			InitializeComponent ();

            listView.ItemsSource = GetContacts();   
        }

        private void RefreshListView(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
        }

        private List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
            };
        }
	}
}