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
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
            drps.ValueChanged += drps_value;
            drpm.ValueChanged += drpm_value;
            spc.Toggled += sptogl_back;
            var n = new TapGestureRecognizer();
            n.Tapped += lbl_Re;
            txtRe.GestureRecognizers.Add(n);
                

            
        }
        private async void lbl_Re(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        private void drps_value(object sender,EventArgs e)
        {
            lblps.Text = drps.Value.ToString();
        }
        private void drpm_value(object sender,EventArgs e)
        {
            lblpm.Text = drpm.Value.ToString();
        }
       
        private void sptogl_back(object sender,EventArgs e)
        {
            if (spc.IsToggled)
            {
               MainPage.nbc = "White";
                this.BackgroundColor = Color.White;
                spc.BackgroundColor = Color.White;
                //Slider 1
                drpm.BackgroundColor = Color.White;
                drpm.MaximumTrackColor = Color.Black;
                drpm.MinimumTrackColor = Color.Black;
                //slider 2
                drps.BackgroundColor = Color.White;
                drps.MaximumTrackColor = Color.Black;
                drps.MinimumTrackColor = Color.Black;
                //des Label
                lblgs.TextColor = Color.Black;
                lblpm.TextColor = Color.Black;
                lblps.TextColor = Color.Black;
                mu.TextColor = Color.Black;
                so.TextColor = Color.Black;
                nmb.TextColor = Color.Black;
                bl.TextColor = Color.Black;
                wl.TextColor = Color.Black;
                txtRe.TextColor = Color.Black;
            }
            else
            {
               MainPage.nbc = "Black";
                this.BackgroundColor = Color.Black;
                spc.BackgroundColor = Color.Black;
                //slider 1
                drps.BackgroundColor = Color.Black;
                drps.MaximumTrackColor = Color.White;
                drps.MinimumTrackColor = Color.White;
                //slider 2
                drpm.BackgroundColor = Color.Black;
                drpm.MaximumTrackColor = Color.White;
                drpm.MinimumTrackColor = Color.White;
                //label
                lblgs.TextColor = Color.White;
                lblpm.TextColor = Color.White;
                lblps.TextColor = Color.White;
                mu.TextColor = Color.White;
                so.TextColor = Color.White;
                nmb.TextColor = Color.White;
                bl.TextColor = Color.White;
                wl.TextColor = Color.White;
                txtRe.TextColor = Color.White;
            }
        }
    }
}