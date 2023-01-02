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
	public partial class EntryEditorPage : ContentPage
	{
		public EntryEditorPage ()
		{
			InitializeComponent ();
		}

        private void Entry_Completed(object sender, EventArgs e)
        {
            lblCompleted.Text = "Completed";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextChanged.Text = e.NewTextValue;
        }
	}
}