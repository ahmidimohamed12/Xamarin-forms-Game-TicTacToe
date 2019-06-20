using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ChronoYber
{
    public partial class MainPage : ContentPage
    {
        public static string nbc = "";
        public MainPage()
        {
            InitializeComponent();
            btnsettings.Clicked += btn_setting_click;
            btnp.Clicked += btn_p;
            btncp.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new playervscomp());
            };
            if(nbc == "")
            {
                this.BackgroundColor = Color.Black;
            }
            else
            {
                if(nbc == "White")
                {
                    this.BackgroundColor = Color.White;
                    //label
                    lbl1.TextColor = Color.Black;
                    lbl2.TextColor = Color.Black;
                    lbl3.TextColor = Color.Black;
                    //button
                    btnp.TextColor = Color.Black;
                    btncp.TextColor = Color.Black;
                    btnc.TextColor = Color.Black;
                    btnsettings.TextColor = Color.Black;
                }
                else
                {
                    this.BackgroundColor = Color.Black;
                    lbl1.TextColor = Color.White;
                    lbl2.TextColor = Color.White;
                    lbl3.TextColor = Color.White;
                    btnsettings.TextColor = Color.White;
                }

            }
            spb.Toggled += sp_togle;

        }
        private void sp_togle(object sender,EventArgs e)
        {
            if(spb.IsToggled == true)
            {
                nbc = "White";

                this.BackgroundColor = Color.White;
                //label
                lbl1.TextColor = Color.Black;
                lbl2.TextColor = Color.Black;
                lbl3.TextColor = Color.Black;
                //button
                btnp.TextColor = Color.Black;
                btncp.TextColor = Color.Black;
                btnc.TextColor = Color.Black;
                btnsettings.TextColor = Color.Black;
                spb.BackgroundColor = Color.Black;
            }
            else
            {
                nbc = "Black";
                spb.BackgroundColor = Color.White;
                this.BackgroundColor = Color.Black;
                lbl1.TextColor = Color.White;
                lbl2.TextColor = Color.White;
                lbl3.TextColor = Color.White;
                btnsettings.TextColor = Color.White;
                btnp.TextColor = Color.White;
                btncp.TextColor = Color.White;
                btnc.TextColor = Color.White;
            }

        }
        private void btn_p(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new PlayervsPlayer());
        }
        public void btn_setting_click(object sender,EventArgs e)
        {
            
            Navigation.PushModalAsync(new Settings());
        }
    }
}
