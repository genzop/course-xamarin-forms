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
	public partial class PlatformEspecificImages : ContentView
	{
		public PlatformEspecificImages ()
		{
			InitializeComponent ();

            btn.Image = (FileImageSource)ImageSource.FromFile("clock.png");
            btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
                iOS: "clock.png",
                Android: "clock.png",
                WinPhone: "clock.png"
                ));
        }
	}
}