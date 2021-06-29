using hhhh.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hhhh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgetPassword : ContentPage
    {
        string db = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "salam.db3");
        public static string resetCode = "";
        public ForgetPassword()
        {
            InitializeComponent();
        }
        private void Clicked_Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PasswordEntry();
        }
        private async void Clicked_Save(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;

                var dbCon = new SQLiteConnection(db);

                if (dbCon.Table<e_mail>().ToList().Count == 0)
                {
                    await DisplayAlert("Entry State", "No DB Record !", "Ok");
                    btn1.IsEnabled = true;
                    btn2.IsEnabled = true;
                    App.isLogin = 0;
                    return;
                }
                var table = dbCon.Table<e_mail>();
                foreach (var s in table)
                {
                    if (s.Email_Addr == EmailEntry.Text)
                    {
                        sendEmail(EmailEntry.Text);
                        App.isLogin = 0;
                        Application.Current.MainPage = new ForgetPassword_Step2();
                        return;
                    }
                }
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
                await DisplayAlert("Error", "Wrong E-mail !", "Ok");
                return;
            }
            else
            {
                await DisplayAlert("Error", "Sorry We Need Internet Connection !", "Ok");
                return;
            }            
        }
        private async void sendEmail(string mail)
        {
            try
            {
                Random rnd = new Random();
                resetCode = rnd.Next(100000, 999999).ToString();
                MailMessage new_mail = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("e-mail", "password");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                new_mail.To.Add(mail);
                new_mail.From = new MailAddress("e-mail");
                new_mail.Subject = "High Security";
                new_mail.Body = "Hello From High Security Your Password Reset Code : " + resetCode;
                istemci.Send(new_mail);
                await DisplayAlert("Sent E-mail", "Code sent to mail address!", "Ok");
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
            }
            catch {
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
                await DisplayAlert("Giriş Durumu", "Error to sending e-mail.", "Ok");
            }
            
        }
    }
}