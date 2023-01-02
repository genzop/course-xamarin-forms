using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation.DisplayingPopups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        private async void Handle_Clicked(object sender, EventArgs e)
        {
            #region Confirm
            /*
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");

            if (response)
                await DisplayAlert("Done", "Your response will be saved!", "OK");
            */
            #endregion

            #region ActionSheet
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Response", response, "OK");
            #endregion
        }
    }
}