using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.BeyondBasics.Styles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DynamicResourcesPage : ContentPage
	{
		public DynamicResourcesPage ()
		{
			InitializeComponent ();
		}

        private void ChangeStyle_Clicked(object sender, EventArgs e)
        {
            Resources["buttonBackgroundColor"] = Color.Pink;
        }
    }
}