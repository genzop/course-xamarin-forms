using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation.Exercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserProfilePage : ContentPage
	{
        private UserService _userService;

		public UserProfilePage (int userId)
		{
			InitializeComponent ();
            _userService = new UserService();

            BindingContext = _userService.GetUser(userId);
		}
	}
}