using hhhh.Data;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hhhh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePassword_Step3 : ContentPage
    {
        string db = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "salam.db3");
        public CreatePassword_Step3()
        {
            InitializeComponent();
        }
        private void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CreatePassword();
        }
        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var request = new AuthenticationRequestConfiguration("Prove you have fingers!", "Because without it you can't have access");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request);
            if (result.Authenticated)
            {
                var dbCon = new SQLiteConnection(db);
                dbCon.DropTable<e_mail>();
                dbCon.CreateTable<e_mail>();

                e_mail node2 = new e_mail();
                node2.Id = 1;
                node2.Email_Addr = EmailEntry.Text;
                dbCon.Insert(node2);
                dbCon.Close();


                dbCon = new SQLiteConnection(db);
                dbCon.DropTable<SecurityKey>();
                dbCon.CreateTable<SecurityKey>();
                for (int i = 1; i < 36; i++)
                {
                    SecurityKey node = new SecurityKey();
                    node.Id = i;
                    node.keyValue = CreatePassword.keyValues2[i];
                    dbCon.Insert(node);
                }
                await DisplayAlert("Creating Password", "The password has been created successfully.", "Ok");
                Application.Current.MainPage = new MainPage();
            }
            else
            {
                await DisplayAlert("Creating Password", "The fingerprint was wrong.", "Ok");
            }
            
        }
    }
}