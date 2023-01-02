using HelloWorld.DataAccess;
using HelloWorld.FormsAndSettings.Exercise;
using HelloWorld.DataAccess.FileSystem;
using System;
using Xamarin.Forms;
using HelloWorld.DataAccess.SQLite;

namespace HelloWorld
{
    public partial class App : Application
	{
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();

                return "";
            }
            set
            {
                Properties[TitleKey] = value;
            }
        }
        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return Convert.ToBoolean(Properties[NotificationsEnabledKey]);

                return false;
            }
            set
            {
                Properties[NotificationsEnabledKey] = value;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BeyondBasics.MessagingCenter.Exercise.Views.ContactsPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
