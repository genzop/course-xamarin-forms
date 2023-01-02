using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.FormsAndSettings
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage : ContentPage
	{
        private IList<ContactMethod> _contactMethods;

		public PickerPage ()
		{
			InitializeComponent ();
            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
                contactMethods2.Items.Add(method.Name);            
		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactMethod = contactMethods.Items[contactMethods.SelectedIndex];
            DisplayAlert("Selection", contactMethod, "OK");
        }

        private void Picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = contactMethods2.Items[contactMethods2.SelectedIndex];
            var contactMethod = _contactMethods.FirstOrDefault(cm => cm.Name == name);

            DisplayAlert("Selection", name, "OK");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod{ Id = 1, Name = "SMS" },
                new ContactMethod{ Id = 2, Name = "Email" }
            };
        }
	}
}