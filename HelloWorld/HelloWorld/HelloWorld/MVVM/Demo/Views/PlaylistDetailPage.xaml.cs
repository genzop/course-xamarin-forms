﻿using HelloWorld.MVVM.Demo.ViewModels;

using Xamarin.Forms;

namespace HelloWorld.MVVM.Demo.Views
{
    public partial class PlaylistDetailPage : ContentPage
    {
        private PlaylistViewModel _playlist; 

        public PlaylistDetailPage (PlaylistViewModel playlist)
        {
            _playlist = playlist; 
            
            InitializeComponent ();

            title.Text = _playlist.Title;
        }
    }
}
