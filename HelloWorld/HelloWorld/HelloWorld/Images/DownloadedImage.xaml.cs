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
	public partial class DownloadedImage : ContentPage
	{
		public DownloadedImage ()
		{
			InitializeComponent ();

            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false;
            imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source = imageSource;
		}
	}
}