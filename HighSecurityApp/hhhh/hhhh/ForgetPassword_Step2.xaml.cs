using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hhhh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgetPassword_Step2 : ContentPage
    {
        public ForgetPassword_Step2()
        {
            InitializeComponent();
        }
        private void Clicked_Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ForgetPassword();
        }
        private async void Clicked_Save(object sender, EventArgs e)
        {

            if (EmailEntry.Text == ForgetPassword.resetCode)
            {
                App.isLogin = 0;
                Application.Current.MainPage = new CreatePassword();
                return;
            }
            else
            {
                await DisplayAlert("Wrong CODE", "Try again !", "Ok");
                App.isLogin = 0;
                return;
            }
        }
    }
}