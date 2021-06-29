using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace hhhh
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            App.isLogin = 0;
            Application.Current.MainPage = new PasswordEntry();
            await DisplayAlert("Entery State", "Successfully Logged Out", "Ok");
        }
        async void OnNotesClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new SecretNotes();
        }
        void OnPassChangeClicked(object sender, EventArgs args)
        {
            App.isLogin = 0;
            Application.Current.MainPage = new PasswordValidation();
        }
        async void onFPClicked(object sender, EventArgs args)
        {
            var request = new AuthenticationRequestConfiguration("Prove you have fingers!", "Because without it you can't have access");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request);
            if (result.Authenticated)
            {
                // do secret stuff :)
            }
            else
            {
                // not allowed to do secret stuff :(
            }
        }
    }
}
