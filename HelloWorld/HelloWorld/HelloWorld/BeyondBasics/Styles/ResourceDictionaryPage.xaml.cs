using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.BeyondBasics.Styles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResourceDictionaryPage : ContentPage
	{
		public ResourceDictionaryPage ()
		{
			InitializeComponent ();
            /*
            this.Resources = new ResourceDictionary();
            this.Resources["borderRadius"] = 20;
            */
		}
	}
}