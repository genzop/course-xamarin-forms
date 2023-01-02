using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridExercise1 : ContentPage
	{
		public GridExercise1 ()
		{
			InitializeComponent ();
		}

        private void Number_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lblNumero.Text += button.Text;
        }

        private void Dial_Clicked(object sender, EventArgs e)
        {
            lblNumero.Text = "";
        }
	}
}