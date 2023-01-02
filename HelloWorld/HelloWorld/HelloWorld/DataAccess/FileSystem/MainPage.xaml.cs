using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.DataAccess.FileSystem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            var fileSystem = DependencyService.Get<IFileSystem>();       //Devuelve la implentacion de IFileSystem que se este ejecutando
            fileSystem.WriteTextAsync("", "");
		}
	}
}