using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChronoYber
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlayervsPlayer : ContentPage
	{
		public PlayervsPlayer ()
		{
			InitializeComponent ();
            if (MainPage.nbc == "")
            {
                this.BackgroundColor = Color.Black;
                btn1.BackgroundColor = Color.White;
                btn2.BackgroundColor = Color.White;
                btn3.BackgroundColor = Color.White;
                btn4.BackgroundColor = Color.White;
                btn5.BackgroundColor = Color.White;
                btn6.BackgroundColor = Color.White;
                btn7.BackgroundColor = Color.White;
                btn8.BackgroundColor = Color.White;
                btn9.BackgroundColor = Color.White;
            }
            else
            {
                if (MainPage.nbc == "White")
                {
                    this.BackgroundColor = Color.White;
                    btn1.BackgroundColor = Color.Black;
                    btn2.BackgroundColor = Color.Black;
                    btn3.BackgroundColor = Color.Black;
                    btn4.BackgroundColor = Color.Black;
                    btn5.BackgroundColor = Color.Black;
                    btn6.BackgroundColor = Color.Black;
                    btn7.BackgroundColor = Color.Black;
                    btn8.BackgroundColor = Color.Black;
                    btn9.BackgroundColor = Color.Black;

                    btn1.TextColor = Color.White;
                    btn2.TextColor = Color.White;
                    btn3.TextColor = Color.White;
                    btn4.TextColor = Color.White;
                    btn5.TextColor = Color.White;
                    btn6.TextColor = Color.White;
                    btn7.TextColor = Color.White;
                    btn8.TextColor = Color.White;
                    btn9.TextColor = Color.White;
                }
                else
                {
                    this.BackgroundColor = Color.Black;
                    btn1.BackgroundColor = Color.White;
                    btn2.BackgroundColor = Color.White;
                    btn3.BackgroundColor = Color.White;
                    btn4.BackgroundColor = Color.White;
                    btn5.BackgroundColor = Color.White;
                    btn6.BackgroundColor = Color.White;
                    btn7.BackgroundColor = Color.White;
                    btn8.BackgroundColor = Color.White;
                    btn9.BackgroundColor = Color.White;
                    btn1.TextColor = Color.Black;
                    btn2.TextColor = Color.Black;
                    btn3.TextColor = Color.Black;
                    btn4.TextColor = Color.Black;
                    btn5.TextColor = Color.Black;
                    btn6.TextColor = Color.Black;
                    btn7.TextColor = Color.Black;
                    btn8.TextColor = Color.Black;
                    btn9.TextColor = Color.Black;
                }
            }
            btn1.Clicked += btn_click;
            btn2.Clicked += btn_click;
            btn3.Clicked += btn_click;
            btn4.Clicked += btn_click;
            btn5.Clicked += btn_click;
            btn6.Clicked += btn_click;
            btn7.Clicked += btn_click;
            btn8.Clicked += btn_click;
            btn9.Clicked += btn_click;
            //btn2.Clicked += btn_click;

        }
        private void btn_click(object sender,EventArgs e)
        {
            Button btn = (Button)sender; 
            if (btn == btn1)
            {
                btn.Text = "X";
            }
            if(btn == btn2)
            {
                btn.Text = "X";
            }
            if (btn == btn3)
            {
            }
            if(btn  == btn4)
            {

            }
            if(btn == btn5)
            {

            }
            if(btn == btn6)
            {

            }
            if(btn  ==  btn7)
            {

            }
            if(btn  ==  btn8)
            {

            }
            if(btn == btn9)
            {

            }
            
        }
        private void btn_test()
        {

        }
	}
}