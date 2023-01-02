using HelloWorld.MVVM.Demo.ViewModels;
using Xamarin.Forms;

namespace HelloWorld.MVVM.Demo.Views
{
    public partial class PlaylistsPage : ContentPage
    {
        public PlaylistsViewModel ViewModel
        {
            get { return BindingContext as PlaylistsViewModel; }
            set { BindingContext = value; }
        }

        public PlaylistsPage ()
        {
            ViewModel = new PlaylistsViewModel(new PageService());
            InitializeComponent ();
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
        }

        void OnPlaylistSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectPlaylistCommand.Execute(e.SelectedItem);
        }
    }
}
