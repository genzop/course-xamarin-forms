using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();

            slider.Value = 0.5;

            #region Ejemplos de atributos diferentes para cada plataforma
            /*if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
            
            Padding = Device.OnPlatform(
                iOS: new Thickness(0, 20, 0, 0),
                Android: new Thickness(0),
                WinPhone: new Thickness(0)
            );

            Device.OnPlatform(
                iOS: () => {
                    Padding = new Thickness(0, 20, 0, 0);
                },
                Android: () => {
                    Padding = new Thickness(0);
                }
            );*/
            #endregion
        }
    }
}