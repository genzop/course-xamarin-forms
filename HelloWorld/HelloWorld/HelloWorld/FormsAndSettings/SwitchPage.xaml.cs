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
	public partial class SwitchPage : ContentPage
	{
		public SwitchPage ()
		{
			InitializeComponent ();
		}

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            lblTexto.IsVisible = e.Value;
        }
	}
}