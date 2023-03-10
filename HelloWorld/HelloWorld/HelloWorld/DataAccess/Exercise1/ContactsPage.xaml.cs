using HelloWorld.DataAccess.SQLite;
using SQLite;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.DataAccess.Exercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Contact> _contacts;
        private bool _isDataLoaded;

        public ContactsPage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        private async Task LoadData()
        {
            await _connection.CreateTableAsync<Contact>();

            var contacts = await _connection.Table<Contact>().ToListAsync();

            _contacts = new ObservableCollection<Contact>(contacts);
            lvContacts.ItemsSource = _contacts;
        }

        protected override async void OnAppearing()
        {
            if (_isDataLoaded)
                return;

            _isDataLoaded = true;
            await LoadData();

            base.OnAppearing(); 
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

                await _connection.DeleteAsync(contact);
            }
        }
    }
}