using hhhh.Data;
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
    public partial class CreatePassword_Step2 : ContentPage
    {
        public int[] keyValues = new int[36];
        //0 -> RED
        //1 -> BLACK
        //2 -> WHITE

        string db = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "salam.db3");

        public CreatePassword_Step2()
        {
            InitializeComponent();
            for (int i = 1; i < 36; i++)
                keyValues[i] = 0;

        }
        public void readFP()
        {

        }
        private void Clicked_Clear(object sender, EventArgs e)
        {
            for (int i = 1; i < 36; i++)
                keyValues[i] = 0;
            Button1Frame.BackgroundColor = Color.Red;
            Button2Frame.BackgroundColor = Color.Red;
            Button3Frame.BackgroundColor = Color.Red;
            Button4Frame.BackgroundColor = Color.Red;
            Button5Frame.BackgroundColor = Color.Red;
            Button6Frame.BackgroundColor = Color.Red;
            Button7Frame.BackgroundColor = Color.Red;
            Button8Frame.BackgroundColor = Color.Red;
            Button9Frame.BackgroundColor = Color.Red;
            Button10Frame.BackgroundColor = Color.Red;
            Button11Frame.BackgroundColor = Color.Red;
            Button12Frame.BackgroundColor = Color.Red;
            Button13Frame.BackgroundColor = Color.Red;
            Button14Frame.BackgroundColor = Color.Red;
            Button15Frame.BackgroundColor = Color.Red;
            Button16Frame.BackgroundColor = Color.Red;
            Button17Frame.BackgroundColor = Color.Red;
            Button18Frame.BackgroundColor = Color.Red;
            Button19Frame.BackgroundColor = Color.Red;
            Button20Frame.BackgroundColor = Color.Red;
            Button21Frame.BackgroundColor = Color.Red;
            Button22Frame.BackgroundColor = Color.Red;
            Button23Frame.BackgroundColor = Color.Red;
            Button24Frame.BackgroundColor = Color.Red;
            Button25Frame.BackgroundColor = Color.Red;
            Button26Frame.BackgroundColor = Color.Red;
            Button27Frame.BackgroundColor = Color.Red;
            Button28Frame.BackgroundColor = Color.Red;
            Button29Frame.BackgroundColor = Color.Red;
            Button30Frame.BackgroundColor = Color.Red;
            Button31Frame.BackgroundColor = Color.Red;
            Button32Frame.BackgroundColor = Color.Red;
            Button33Frame.BackgroundColor = Color.Red;
            Button34Frame.BackgroundColor = Color.Red;
            Button35Frame.BackgroundColor = Color.Red;
        }
        private async void Clicked_Save(object sender, EventArgs e)
        {
            for (int i = 1; i < 36; i++)
            {
                if (CreatePassword.keyValues2[i] != keyValues[i]) 
                {
                    await DisplayAlert("Creating Password", "The patterns you entered do not match !", "Ok");
                    return;
                }
            }
            Application.Current.MainPage = new CreatePassword_Step3();
        }
        private void Clicked_Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CreatePassword();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            if (Button1Frame.BackgroundColor == Color.Red)
            {
                Button1Frame.BackgroundColor = Color.Black;
                keyValues[1] = 1;
            }
            else if (Button1Frame.BackgroundColor == Color.Black)
            {
                Button1Frame.BackgroundColor = Color.White;
                keyValues[1] = 2;
            }
            else if (Button1Frame.BackgroundColor == Color.White)
            {
                Button1Frame.BackgroundColor = Color.Red;
                keyValues[1] = 0;
            }
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            if (Button2Frame.BackgroundColor == Color.Red)
            {
                Button2Frame.BackgroundColor = Color.Black;
                keyValues[2] = 1;
            }
            else if (Button2Frame.BackgroundColor == Color.Black)
            {
                Button2Frame.BackgroundColor = Color.White;
                keyValues[2] = 2;
            }
            else if (Button2Frame.BackgroundColor == Color.White)
            {
                Button2Frame.BackgroundColor = Color.Red;
                keyValues[2] = 0;
            }
        }
        private void Button_Clicked3(object sender, EventArgs e)
        {
            if (Button3Frame.BackgroundColor == Color.Red)
            {
                Button3Frame.BackgroundColor = Color.Black;
                keyValues[3] = 1;
            }
            else if (Button3Frame.BackgroundColor == Color.Black)
            {
                Button3Frame.BackgroundColor = Color.White;
                keyValues[3] = 2;
            }
            else if (Button3Frame.BackgroundColor == Color.White)
            {
                Button3Frame.BackgroundColor = Color.Red;
                keyValues[3] = 0;
            }
        }
        private void Button_Clicked4(object sender, EventArgs e)
        {
            if (Button4Frame.BackgroundColor == Color.Red)
            {
                Button4Frame.BackgroundColor = Color.Black;
                keyValues[4] = 1;
            }
            else if (Button4Frame.BackgroundColor == Color.Black)
            {
                Button4Frame.BackgroundColor = Color.White;
                keyValues[4] = 2;
            }
            else if (Button4Frame.BackgroundColor == Color.White)
            {
                Button4Frame.BackgroundColor = Color.Red;
                keyValues[4] = 0;
            }
        }
        private void Button_Clicked5(object sender, EventArgs e)
        {
            if (Button5Frame.BackgroundColor == Color.Red)
            {
                Button5Frame.BackgroundColor = Color.Black;
                keyValues[5] = 1;
            }
            else if (Button5Frame.BackgroundColor == Color.Black)
            {
                Button5Frame.BackgroundColor = Color.White;
                keyValues[5] = 2;
            }
            else if (Button5Frame.BackgroundColor == Color.White)
            {
                Button5Frame.BackgroundColor = Color.Red;
                keyValues[5] = 0;
            }
        }
        private void Button_Clicked6(object sender, EventArgs e)
        {
            if (Button6Frame.BackgroundColor == Color.Red)
            {
                Button6Frame.BackgroundColor = Color.Black;
                keyValues[6] = 1;
            }
            else if (Button6Frame.BackgroundColor == Color.Black)
            {
                Button6Frame.BackgroundColor = Color.White;
                keyValues[6] = 2;
            }
            else if (Button6Frame.BackgroundColor == Color.White)
            {
                Button6Frame.BackgroundColor = Color.Red;
                keyValues[6] = 0;
            }
        }
        private void Button_Clicked7(object sender, EventArgs e)
        {
            if (Button7Frame.BackgroundColor == Color.Red)
            {
                Button7Frame.BackgroundColor = Color.Black;
                keyValues[7] = 1;
            }
            else if (Button7Frame.BackgroundColor == Color.Black)
            {
                Button7Frame.BackgroundColor = Color.White;
                keyValues[7] = 2;
            }
            else if (Button7Frame.BackgroundColor == Color.White)
            {
                Button7Frame.BackgroundColor = Color.Red;
                keyValues[7] = 0;
            }
        }
        private void Button_Clicked8(object sender, EventArgs e)
        {
            if (Button8Frame.BackgroundColor == Color.Red)
            {
                Button8Frame.BackgroundColor = Color.Black;
                keyValues[8] = 1;
            }
            else if (Button8Frame.BackgroundColor == Color.Black)
            {
                Button8Frame.BackgroundColor = Color.White;
                keyValues[8] = 2;
            }
            else if (Button8Frame.BackgroundColor == Color.White)
            {
                Button8Frame.BackgroundColor = Color.Red;
                keyValues[8] = 0;
            }
        }
        private void Button_Clicked9(object sender, EventArgs e)
        {
            if (Button9Frame.BackgroundColor == Color.Red)
            {
                Button9Frame.BackgroundColor = Color.Black;
                keyValues[9] = 1;
            }
            else if (Button9Frame.BackgroundColor == Color.Black)
            {
                Button9Frame.BackgroundColor = Color.White;
                keyValues[9] = 2;
            }
            else if (Button9Frame.BackgroundColor == Color.White)
            {
                Button9Frame.BackgroundColor = Color.Red;
                keyValues[9] = 0;
            }
        }
        private void Button_Clicked10(object sender, EventArgs e)
        {
            if (Button10Frame.BackgroundColor == Color.Red)
            {
                Button10Frame.BackgroundColor = Color.Black;
                keyValues[10] = 1;
            }
            else if (Button10Frame.BackgroundColor == Color.Black)
            {
                Button10Frame.BackgroundColor = Color.White;
                keyValues[10] = 2;
            }
            else if (Button10Frame.BackgroundColor == Color.White)
            {
                Button10Frame.BackgroundColor = Color.Red;
                keyValues[10] = 0;
            }
        }
        private void Button_Clicked11(object sender, EventArgs e)
        {
            if (Button11Frame.BackgroundColor == Color.Red)
            {
                Button11Frame.BackgroundColor = Color.Black;
                keyValues[11] = 1;
            }
            else if (Button11Frame.BackgroundColor == Color.Black)
            {
                Button11Frame.BackgroundColor = Color.White;
                keyValues[11] = 2;
            }
            else if (Button11Frame.BackgroundColor == Color.White)
            {
                Button11Frame.BackgroundColor = Color.Red;
                keyValues[11] = 0;
            }
        }
        private void Button_Clicked12(object sender, EventArgs e)
        {
            if (Button12Frame.BackgroundColor == Color.Red)
            {
                Button12Frame.BackgroundColor = Color.Black;
                keyValues[12] = 1;
            }
            else if (Button12Frame.BackgroundColor == Color.Black)
            {
                Button12Frame.BackgroundColor = Color.White;
                keyValues[12] = 2;
            }
            else if (Button12Frame.BackgroundColor == Color.White)
            {
                Button12Frame.BackgroundColor = Color.Red;
                keyValues[12] = 0;
            }
        }
        private void Button_Clicked13(object sender, EventArgs e)
        {
            if (Button13Frame.BackgroundColor == Color.Red)
            {
                Button13Frame.BackgroundColor = Color.Black;
                keyValues[13] = 1;
            }
            else if (Button13Frame.BackgroundColor == Color.Black)
            {
                Button13Frame.BackgroundColor = Color.White;
                keyValues[13] = 2;
            }
            else if (Button13Frame.BackgroundColor == Color.White)
            {
                Button13Frame.BackgroundColor = Color.Red;
                keyValues[13] = 0;
            }
        }
        private void Button_Clicked14(object sender, EventArgs e)
        {
            if (Button14Frame.BackgroundColor == Color.Red)
            {
                Button14Frame.BackgroundColor = Color.Black;
                keyValues[14] = 1;
            }
            else if (Button14Frame.BackgroundColor == Color.Black)
            {
                Button14Frame.BackgroundColor = Color.White;
                keyValues[14] = 2;
            }
            else if (Button14Frame.BackgroundColor == Color.White)
            {
                Button14Frame.BackgroundColor = Color.Red;
                keyValues[14] = 0;
            }
        }
        private void Button_Clicked15(object sender, EventArgs e)
        {
            if (Button15Frame.BackgroundColor == Color.Red)
            {
                Button15Frame.BackgroundColor = Color.Black;
                keyValues[15] = 1;
            }
            else if (Button15Frame.BackgroundColor == Color.Black)
            {
                Button15Frame.BackgroundColor = Color.White;
                keyValues[15] = 2;
            }
            else if (Button15Frame.BackgroundColor == Color.White)
            {
                Button15Frame.BackgroundColor = Color.Red;
                keyValues[15] = 0;
            }
        }
        private void Button_Clicked16(object sender, EventArgs e)
        {
            if (Button16Frame.BackgroundColor == Color.Red)
            {
                Button16Frame.BackgroundColor = Color.Black;
                keyValues[16] = 1;
            }
            else if (Button16Frame.BackgroundColor == Color.Black)
            {
                Button16Frame.BackgroundColor = Color.White;
                keyValues[16] = 2;
            }
            else if (Button16Frame.BackgroundColor == Color.White)
            {
                Button16Frame.BackgroundColor = Color.Red;
                keyValues[16] = 0;
            }
        }
        private void Button_Clicked17(object sender, EventArgs e)
        {
            if (Button17Frame.BackgroundColor == Color.Red)
            {
                Button17Frame.BackgroundColor = Color.Black;
                keyValues[17] = 1;
            }
            else if (Button17Frame.BackgroundColor == Color.Black)
            {
                Button17Frame.BackgroundColor = Color.White;
                keyValues[17] = 2;
            }
            else if (Button17Frame.BackgroundColor == Color.White)
            {
                Button17Frame.BackgroundColor = Color.Red;
                keyValues[17] = 0;
            }
        }
        private void Button_Clicked18(object sender, EventArgs e)
        {
            if (Button18Frame.BackgroundColor == Color.Red)
            {
                Button18Frame.BackgroundColor = Color.Black;
                keyValues[18] = 1;
            }
            else if (Button18Frame.BackgroundColor == Color.Black)
            {
                Button18Frame.BackgroundColor = Color.White;
                keyValues[18] = 2;
            }
            else if (Button18Frame.BackgroundColor == Color.White)
            {
                Button18Frame.BackgroundColor = Color.Red;
                keyValues[18] = 0;
            }
        }
        private void Button_Clicked19(object sender, EventArgs e)
        {
            if (Button19Frame.BackgroundColor == Color.Red)
            {
                Button19Frame.BackgroundColor = Color.Black;
                keyValues[19] = 1;
            }
            else if (Button19Frame.BackgroundColor == Color.Black)
            {
                Button19Frame.BackgroundColor = Color.White;
                keyValues[19] = 2;
            }
            else if (Button19Frame.BackgroundColor == Color.White)
            {
                Button19Frame.BackgroundColor = Color.Red;
                keyValues[19] = 0;
            }
        }
        private void Button_Clicked20(object sender, EventArgs e)
        {
            if (Button20Frame.BackgroundColor == Color.Red)
            {
                Button20Frame.BackgroundColor = Color.Black;
                keyValues[20] = 1;
            }
            else if (Button20Frame.BackgroundColor == Color.Black)
            {
                Button20Frame.BackgroundColor = Color.White;
                keyValues[20] = 2;
            }
            else if (Button20Frame.BackgroundColor == Color.White)
            {
                Button20Frame.BackgroundColor = Color.Red;
                keyValues[20] = 0;
            }
        }
        private void Button_Clicked21(object sender, EventArgs e)
        {
            if (Button21Frame.BackgroundColor == Color.Red)
            {
                Button21Frame.BackgroundColor = Color.Black;
                keyValues[21] = 1;
            }
            else if (Button21Frame.BackgroundColor == Color.Black)
            {
                Button21Frame.BackgroundColor = Color.White;
                keyValues[21] = 2;
            }
            else if (Button21Frame.BackgroundColor == Color.White)
            {
                Button21Frame.BackgroundColor = Color.Red;
                keyValues[21] = 0;
            }
        }
        private void Button_Clicked22(object sender, EventArgs e)
        {
            if (Button22Frame.BackgroundColor == Color.Red)
            {
                Button22Frame.BackgroundColor = Color.Black;
                keyValues[22] = 1;
            }
            else if (Button22Frame.BackgroundColor == Color.Black)
            {
                Button22Frame.BackgroundColor = Color.White;
                keyValues[22] = 2;
            }
            else if (Button22Frame.BackgroundColor == Color.White)
            {
                Button22Frame.BackgroundColor = Color.Red;
                keyValues[22] = 0;
            }
        }
        private void Button_Clicked23(object sender, EventArgs e)
        {
            if (Button23Frame.BackgroundColor == Color.Red)
            {
                Button23Frame.BackgroundColor = Color.Black;
                keyValues[23] = 1;
            }
            else if (Button23Frame.BackgroundColor == Color.Black)
            {
                Button23Frame.BackgroundColor = Color.White;
                keyValues[23] = 2;
            }
            else if (Button23Frame.BackgroundColor == Color.White)
            {
                Button23Frame.BackgroundColor = Color.Red;
                keyValues[23] = 0;
            }
        }
        private void Button_Clicked24(object sender, EventArgs e)
        {
            if (Button24Frame.BackgroundColor == Color.Red)
            {
                Button24Frame.BackgroundColor = Color.Black;
                keyValues[24] = 1;
            }
            else if (Button24Frame.BackgroundColor == Color.Black)
            {
                Button24Frame.BackgroundColor = Color.White;
                keyValues[24] = 2;
            }
            else if (Button24Frame.BackgroundColor == Color.White)
            {
                Button24Frame.BackgroundColor = Color.Red;
                keyValues[24] = 0;
            }
        }
        private void Button_Clicked25(object sender, EventArgs e)
        {
            if (Button25Frame.BackgroundColor == Color.Red)
            {
                Button25Frame.BackgroundColor = Color.Black;
                keyValues[25] = 1;
            }
            else if (Button25Frame.BackgroundColor == Color.Black)
            {
                Button25Frame.BackgroundColor = Color.White;
                keyValues[25] = 2;
            }
            else if (Button25Frame.BackgroundColor == Color.White)
            {
                Button25Frame.BackgroundColor = Color.Red;
                keyValues[25] = 0;
            }
        }
        private void Button_Clicked26(object sender, EventArgs e)
        {
            if (Button26Frame.BackgroundColor == Color.Red)
            {
                Button26Frame.BackgroundColor = Color.Black;
                keyValues[26] = 1;
            }
            else if (Button26Frame.BackgroundColor == Color.Black)
            {
                Button26Frame.BackgroundColor = Color.White;
                keyValues[26] = 2;
            }
            else if (Button26Frame.BackgroundColor == Color.White)
            {
                Button26Frame.BackgroundColor = Color.Red;
                keyValues[26] = 0;
            }
        }
        private void Button_Clicked27(object sender, EventArgs e)
        {
            if (Button27Frame.BackgroundColor == Color.Red)
            {
                Button27Frame.BackgroundColor = Color.Black;
                keyValues[27] = 1;
            }
            else if (Button27Frame.BackgroundColor == Color.Black)
            {
                Button27Frame.BackgroundColor = Color.White;
                keyValues[27] = 2;
            }
            else if (Button27Frame.BackgroundColor == Color.White)
            {
                Button27Frame.BackgroundColor = Color.Red;
                keyValues[27] = 0;
            }
        }
        private void Button_Clicked28(object sender, EventArgs e)
        {
            if (Button28Frame.BackgroundColor == Color.Red)
            {
                Button28Frame.BackgroundColor = Color.Black;
                keyValues[28] = 1;
            }
            else if (Button28Frame.BackgroundColor == Color.Black)
            {
                Button28Frame.BackgroundColor = Color.White;
                keyValues[28] = 2;
            }
            else if (Button28Frame.BackgroundColor == Color.White)
            {
                Button28Frame.BackgroundColor = Color.Red;
                keyValues[28] = 0;
            }
        }
        private void Button_Clicked29(object sender, EventArgs e)
        {
            if (Button29Frame.BackgroundColor == Color.Red)
            {
                Button29Frame.BackgroundColor = Color.Black;
                keyValues[29] = 1;
            }
            else if (Button29Frame.BackgroundColor == Color.Black)
            {
                Button29Frame.BackgroundColor = Color.White;
                keyValues[29] = 2;
            }
            else if (Button29Frame.BackgroundColor == Color.White)
            {
                Button29Frame.BackgroundColor = Color.Red;
                keyValues[29] = 0;
            }
        }
        private void Button_Clicked30(object sender, EventArgs e)
        {
            if (Button30Frame.BackgroundColor == Color.Red)
            {
                Button30Frame.BackgroundColor = Color.Black;
                keyValues[30] = 1;
            }
            else if (Button30Frame.BackgroundColor == Color.Black)
            {
                Button30Frame.BackgroundColor = Color.White;
                keyValues[30] = 2;
            }
            else if (Button30Frame.BackgroundColor == Color.White)
            {
                Button30Frame.BackgroundColor = Color.Red;
                keyValues[30] = 0;
            }
        }
        private void Button_Clicked31(object sender, EventArgs e)
        {
            if (Button31Frame.BackgroundColor == Color.Red)
            {
                Button31Frame.BackgroundColor = Color.Black;
                keyValues[31] = 1;
            }
            else if (Button31Frame.BackgroundColor == Color.Black)
            {
                Button31Frame.BackgroundColor = Color.White;
                keyValues[31] = 2;
            }
            else if (Button31Frame.BackgroundColor == Color.White)
            {
                Button31Frame.BackgroundColor = Color.Red;
                keyValues[31] = 0;
            }
        }
        private void Button_Clicked32(object sender, EventArgs e)
        {
            if (Button32Frame.BackgroundColor == Color.Red)
            {
                Button32Frame.BackgroundColor = Color.Black;
                keyValues[32] = 1;
            }
            else if (Button32Frame.BackgroundColor == Color.Black)
            {
                Button32Frame.BackgroundColor = Color.White;
                keyValues[32] = 2;
            }
            else if (Button32Frame.BackgroundColor == Color.White)
            {
                Button32Frame.BackgroundColor = Color.Red;
                keyValues[32] = 0;
            }
        }
        private void Button_Clicked33(object sender, EventArgs e)
        {
            if (Button33Frame.BackgroundColor == Color.Red)
            {
                Button33Frame.BackgroundColor = Color.Black;
                keyValues[33] = 1;
            }
            else if (Button33Frame.BackgroundColor == Color.Black)
            {
                Button33Frame.BackgroundColor = Color.White;
                keyValues[33] = 2;
            }
            else if (Button33Frame.BackgroundColor == Color.White)
            {
                Button33Frame.BackgroundColor = Color.Red;
                keyValues[33] = 0;
            }
        }
        private void Button_Clicked34(object sender, EventArgs e)
        {
            if (Button34Frame.BackgroundColor == Color.Red)
            {
                Button34Frame.BackgroundColor = Color.Black;
                keyValues[34] = 1;
            }
            else if (Button34Frame.BackgroundColor == Color.Black)
            {
                Button34Frame.BackgroundColor = Color.White;
                keyValues[34] = 2;
            }
            else if (Button34Frame.BackgroundColor == Color.White)
            {
                Button34Frame.BackgroundColor = Color.Red;
                keyValues[34] = 0;
            }
        }
        private void Button_Clicked35(object sender, EventArgs e)
        {
            if (Button35Frame.BackgroundColor == Color.Red)
            {
                Button35Frame.BackgroundColor = Color.Black;
                keyValues[35] = 1;
            }
            else if (Button35Frame.BackgroundColor == Color.Black)
            {
                Button35Frame.BackgroundColor = Color.White;
                keyValues[35] = 2;
            }
            else if (Button35Frame.BackgroundColor == Color.White)
            {
                Button35Frame.BackgroundColor = Color.Red;
                keyValues[35] = 0;
            }
        }
    }
}