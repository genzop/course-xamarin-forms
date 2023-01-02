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
	public partial class SliderPage : ContentPage
	{
		public SliderPage ()
		{
			InitializeComponent ();
		}

        private void Value_Changed(object sender, ValueChangedEventArgs e)
        {
            DisplayAlert("Nuevo valor", e.NewValue.ToString(), "OK");
        }
	}
}