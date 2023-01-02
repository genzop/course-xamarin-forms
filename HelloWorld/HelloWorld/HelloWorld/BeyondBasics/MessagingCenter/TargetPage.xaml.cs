using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.BeyondBasics.MessagingCenter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TargetPage : ContentPage
	{
		public TargetPage ()
		{
			InitializeComponent ();
		}

        public void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            Xamarin.Forms.MessagingCenter.Send(this, Events.SliderValueChanged, e.NewValue);            
        }
    }
}