using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.FormsAndSettings.PickerNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactMethodsPage : ContentPage
	{
        public ListView ContactMethods { get { return listView; } }

		public ContactMethodsPage ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "SMS"
            };
        }
	}
}