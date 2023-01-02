using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.FormsAndSettings.Exercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailsPage : ContentPage
	{
        public event EventHandler<Contact> ContactAdded;
        public event EventHandler<Contact> ContactUpdated;
        
        public ContactDetailsPage (Contact contact)
		{
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

			InitializeComponent ();            

            BindingContext = new Contact
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone,
                Email = contact.Email,
                IsBlocked = contact.IsBlocked
            };
		}

        public async void OnSave(object sender, EventArgs e)
        {
            var contact = BindingContext as Contact;

            if (String.IsNullOrWhiteSpace(contact.FullName))
            {
                await DisplayAlert("Error", "Please enter the name", "OK");
                return;
            }

            if(contact.Id == 0)
            {
                contact.Id = 1;
                ContactAdded?.Invoke(this, contact);
            }
            else
            {
                ContactUpdated?.Invoke(this, contact);
            }

            await Navigation.PopAsync();
        }
	}
}