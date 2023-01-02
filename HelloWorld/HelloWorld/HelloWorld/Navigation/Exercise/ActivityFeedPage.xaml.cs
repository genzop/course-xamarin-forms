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
	public partial class ActivityFeedPage : ContentPage
	{
        private ActivityService _activityService;

		public ActivityFeedPage ()
		{
			InitializeComponent ();
            _activityService = new ActivityService();

            lstActivities.ItemsSource = _activityService.GetActivities();
		}

        public void ActivitySelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var activity = e.SelectedItem as Activity;
            lstActivities.SelectedItem = null;            
            Navigation.PushAsync(new UserProfilePage(activity.UserId));
        }
	}
}