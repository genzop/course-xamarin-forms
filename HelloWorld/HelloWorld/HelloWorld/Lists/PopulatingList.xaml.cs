using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopulatingList : ContentPage
	{
		public PopulatingList ()
		{
			InitializeComponent ();

            var names = new List<string>
            {
                "Mosh",
                "John",
                "Bob"
            };

            listView.ItemsSource = names;
        }
	}
}