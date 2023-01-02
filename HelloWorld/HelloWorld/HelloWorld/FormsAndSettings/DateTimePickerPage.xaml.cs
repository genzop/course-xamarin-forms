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
	public partial class DateTimePickerPage : ContentPage
	{
		public DateTimePickerPage ()
		{
			InitializeComponent ();
		}

        private void DatePicker_DateChanged(object sender, DateChangedEventArgs e)
        {
            var date = e.NewDate;
        }
    }
}