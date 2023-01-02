﻿using HelloWorld.BeyondBasics.MessagingCenter.Exercise.Persistence;
using HelloWorld.BeyondBasics.MessagingCenter.Exercise.ViewModels;
using HelloWorld.DataAccess.SQLite;
using Xamarin.Forms;

namespace HelloWorld.BeyondBasics.MessagingCenter.Exercise.Views
{
    public partial class ContactsPage : ContentPage
	{
		public ContactsPage()
		{
			var contactStore = new SQLiteContactStore(DependencyService.Get<ISQLiteDb>());
			var pageService = new PageService();
			ViewModel = new ContactsPageViewModel(contactStore, pageService);

			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			ViewModel.LoadDataCommand.Execute(null);

			base.OnAppearing();
		}

		void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
		{
			ViewModel.SelectContactCommand.Execute(e.SelectedItem);
		}

		public ContactsPageViewModel ViewModel
		{
			get { return BindingContext as ContactsPageViewModel; }
			set { BindingContext = value; }
		}
	}
}
