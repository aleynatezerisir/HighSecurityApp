using hhhh.Data;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hhhh
{
    public partial class App : Application
    {
        string db = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "salam.db3");
        public static int isLogin = 0;
        public App()
        {
            var dbCon = new SQLiteConnection(db);

            InitializeComponent();

            try
            {
                if (dbCon.Table<SecurityKey>().ToList().Count != 0)
                {

                }
            }
            catch
            {
                MainPage = new CreatePassword();
                return;
            }

            if (isLogin == 0)
            {
                MainPage = new PasswordEntry();
            }
            else
            {
                MainPage = new MainPage();
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
