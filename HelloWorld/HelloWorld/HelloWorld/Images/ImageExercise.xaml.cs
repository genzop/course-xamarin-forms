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
	public partial class ImageExercise : ContentPage
	{
        private int ImageNumber;
        private UriImageSource UriSource;

		public ImageExercise ()
		{
			InitializeComponent ();

            ImageNumber = 1;
            UriSource = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new Uri("http://lorempixel.com/1920/1080/city/" + ImageNumber  + "/")
            };

            img.Source = UriSource;
		}

        private void Previous(object sender, EventArgs e)
        {
            if (ImageNumber == 1)
                ImageNumber = 11;

            ImageNumber -= 1;

            UriSource.Uri = new Uri("http://lorempixel.com/1920/1080/city/" + ImageNumber + "/");
            img.Source = UriSource;
        }

        private void Next(object sender, EventArgs e)
        {
            if (ImageNumber == 10)
                ImageNumber = 0;

            ImageNumber += 1;

            UriSource.Uri = new Uri("http://lorempixel.com/1920/1080/city/" + ImageNumber + "/");
            img.Source = UriSource;
        }
	}
}