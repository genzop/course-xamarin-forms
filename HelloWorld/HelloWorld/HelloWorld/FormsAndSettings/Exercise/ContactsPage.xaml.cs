using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.FormsAndSettings.Exercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
        private ObservableCollection<Contact> _contacts;

		public ContactsPage ()
		{
			InitializeComponent ();
            _contacts = new ObservableCollection<Contact>
            {
                new Contact{Id = 1, FirstName = "Mosh", LastName = "Hamedani", Email = "moshhamedani@gmail.com", Phone = "+542615633456", IsBlocked = false },
                new Contact{Id = 2, FirstName = "Jonh", LastName = "Smith", Email = "johnsmith@gmail.com", Phone = "+54261434545", IsBlocked = true }
            };

            lvContacts.ItemsSource = _contacts;
		}

        public async void OnAddContact(object sender, EventArgs e)
        {
            var page = new ContactDetailsPage(new Contact());

            page.ContactAdded += (source, contact) =>
            {
                _contacts.Add(contact);
            };

            await Navigation.PushAsync(page);
        }

        public async void OnSelectContact(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectecContact = e.SelectedItem as Contact;
            lvContacts.SelectedItem = null;

            var page = new ContactDetailsPage(selectecContact);
            page.ContactUpdated += (source, contact) =>
            {
                selectecContact.Id = contact.Id;
                selectecContact.FirstName = contact.FirstName;
                selectecContact.LastName = contact.LastName;
                selectecContact.Phone = contact.Phone;
                selectecContact.Email = contact.Email;
                selectecContact.IsBlocked = contact.IsBlocked;
            };

            await Navigation.PushAsync(page);
        }

        private async void OnDeleteContact(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
                        
            if (await DisplayAlert("Warning", "Are you sure you want to delete " + contact.FullName + "?", "Yes", "No"))
            {                
                _contacts.Remove(contact);
            }            
        }
	}
}