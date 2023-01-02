﻿using HelloWorld.MVVM.Exercise.Persistence;
using HelloWorld.MVVM.Exercise.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloWorld.MVVM.Exercise.ViewModels
{
	public class ContactDetailViewModel 
	{
		private readonly IContactStore _contactStore;
		private readonly IPageService _pageService;

		public event EventHandler<Contact> ContactAdded;
		public event EventHandler<Contact> ContactUpdated;

		public Contact Contact { get; private set; }

		public ICommand SaveCommand { get; private set; }

		public ContactDetailViewModel(ContactViewModel viewModel, IContactStore contactStore, IPageService pageService)
		{
			if (viewModel == null)
				throw new ArgumentNullException(nameof(viewModel));

			_pageService = pageService;
			_contactStore = contactStore;

			SaveCommand = new Command(async () => await Save());

			// Here we are mapping our view model to a domain model. 
			// This is required because further below where we use ContactStore 
			// to add or update a contact, we need a domain model, not a view model.
			// Read my comment in the constructor of ContactViewModel.

			Contact = new Contact
			{
				Id = viewModel.Id,
				FirstName = viewModel.FirstName,
				LastName = viewModel.LastName,
				Phone = viewModel.Phone,
				Email = viewModel.Email,
				IsBlocked = viewModel.IsBlocked,
			};
		}

		async Task Save()
		{
			if (String.IsNullOrWhiteSpace(Contact.FirstName) && 
			    String.IsNullOrWhiteSpace(Contact.LastName))
			{
				await _pageService.DisplayAlert("Error", "Please enter the name.", "OK");
				return;
			}

			if (Contact.Id == 0)
			{
				await _contactStore.AddContact(Contact);

				ContactAdded?.Invoke(this, Contact);
			}
			else
			{
				await _contactStore.UpdateContact(Contact);

				ContactUpdated?.Invoke(this, Contact);
			}

			await _pageService.PopAsync();
		}
	}
}
