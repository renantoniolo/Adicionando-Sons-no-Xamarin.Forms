using System;
using System.Collections.Generic;
using AppSound.ViewModel;
using Xamarin.Forms;

namespace AppSound
{
    public partial class PlayerViewPage : ContentPage
    {
        public PlayerViewPage()
        {
            InitializeComponent();

            this.BindingContext = new PlayerViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((PlayerViewModel)this.BindingContext).ThisOppearing();
        }


    }
}
