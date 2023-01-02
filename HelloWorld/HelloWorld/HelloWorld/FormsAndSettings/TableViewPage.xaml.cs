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
	public partial class TableViewPage : ContentPage
	{
		public TableViewPage ()
		{
			InitializeComponent ();
		}

        private void EntryCell_Completed(object sender, EventArgs e)
        {

        }

        private void SwitchCell_Changed(object sender, ToggledEventArgs e)
        {

        }
	}
}