using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Images
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmbeddedImages : ContentView
	{
		public EmbeddedImages ()
		{
			InitializeComponent ();

            image.Source = ImageSource.FromResource("HelloWorld.Images.background.jpg");
		}
	}
}