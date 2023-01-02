using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.BeyondBasics.MessagingCenter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        public void OnClick(object sender, EventArgs e)
        {            
            Xamarin.Forms.MessagingCenter.Subscribe<TargetPage, double>(this, Events.SliderValueChanged, OnSliderValueChanged);
            Navigation.PushAsync(new TargetPage());
            Xamarin.Forms.MessagingCenter.Unsubscribe<MainPage>(this, Events.SliderValueChanged);
        }

        private void OnSliderValueChanged(TargetPage source, double newValue)
        {
            label.Text = newValue.ToString();
        }
	}
}