using HelloWorld.MVVM.Exercise.ViewModels;
using Xamarin.Forms;

namespace HelloWorld.MVVM.Exercise.Views
{
	public partial class ContactDetailPage : ContentPage
	{
		public ContactDetailPage(ContactDetailViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = viewModel;
		}
	}
}