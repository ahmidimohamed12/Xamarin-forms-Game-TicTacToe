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
	public partial class playervscomp : ContentPage
	{
		public playervscomp ()
		{
			InitializeComponent ();
            btn1.Clicked += btn_click;
            btn2.Clicked += btn_click;
            btn3.Clicked += btn_click;
            btn4.Clicked += btn_click;
            btn5.Clicked += btn_click;
            btn6.Clicked += btn_click;
            btn7.Clicked += btn_click;
            btn8.Clicked += btn_click;
            btn9.Clicked += btn_click;
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
        }
        int n = 1;
        public void test(object sender,EventArgs e)
        {
            n++;
            Button btn = (Button)sender;
            if (n % 2 == 0)
            {
                if(btn.Text == null)
                    btn.Text = "X";
            }
            else
            {
                if(btn.Text == null)
                    btn.Text = "O";
            }
        }
      
        private void btn_click(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btn1)
            {
                test(sender, e);
                Resultat();
                //if(n % 2==0)
                //{
                //    if (btn.Text == null)
                //    {
                //        btn.Text = "X";
                //    }
                //}
                //else
                //{
                //    if (btn.Text == null)
                //    {
                //        btn.Text = "O";
                //    }
                //}
            }
            if (btn == btn2)
            {
                test(sender, e);
                Resultat();
                //if (n % 2 == 0)
                //{
                //    if (btn.Text == null)
                //    {
                //        btn.Text = "X";
                //    }
                //}
                //else
                //{
                //    if (btn.Text == null)
                //    {
                //        btn.Text = "O";
                //    }
                //}
            }
            if (btn == btn3)
            {
                test(sender, e);
                Resultat();

            }
            if (btn == btn4)
            {
                test(sender, e);
                Resultat();

            }
            if (btn == btn5)
            {
                test(sender, e);
                Resultat();
            }
            if (btn ==  btn6)
            {
                test(sender, e);
                Resultat();
            }
            if(btn == btn7)
            {
                test(sender, e);
                Resultat();
            }
            if (btn == btn8)
            {
                test(sender, e);
                Resultat();
            }
            if (btn == btn9)
            {
                test(sender, e);
                Resultat();
            }
        }
        public void Resultat()
        {
            if(btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                Messager();
                clear();
            }
            if(btn1.Text == "X" && btn4.Text =="X" && btn7.Text=="X")
            {
                Messager();
                clear();
            }
            if(btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                Messager();
                clear();
            }
            if(btn4.Text == "X" && btn5.Text=="X" && btn6.Text=="X")
            {
                Messager();
                clear();
            }
            if(btn3.Text=="X" && btn6.Text=="X"  && btn9.Text == "X")
            {
                Messager();
                clear();
            }
            if(btn7.Text =="X" && btn8.Text == "X" && btn9.Text=="X")
            {
                Messager();
                clear();
            }
            if(btn3.Text == "X" && btn5.Text =="X" && btn7.Text=="X")
            {
                Messager();
                clear();
            }
            if(btn2.Text == "X" && btn5.Text == "X" && btn8.Text=="X")
            {
                Messager();
                clear();
            }

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                Messager();
                clear();
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                Messager();
                clear();
            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                Messager();
                clear();
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                Messager();
                clear();
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                Messager();
                clear();
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                Messager();
                clear();
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                Messager();
                clear();
            }
            if(btn2.Text=="O" &&  btn5.Text == "O" && btn8.Text == "O")
            {
                Messager();
                clear();
            }
        }
        public void clear()
        {
            btn1.Text = null;
            btn2.Text = null;
            btn3.Text = null;
            btn4.Text = null;
            btn5.Text = null;
            btn6.Text = null;
            btn7.Text = null;
            btn8.Text = null;
            btn9.Text = null;
        }
        public void  Messager()
        {
            DisplayAlert("Gangner", "Ganger Votre Match", "Ok");
        }
	}
}