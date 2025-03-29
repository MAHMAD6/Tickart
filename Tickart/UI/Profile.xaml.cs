using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tickart.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void OnFadeEffectTapped(object sender, EventArgs e)
        {
            popup.IsVisible = false;
            fadeEffect.IsVisible = false;
        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();

        }

        private void EditProfile_Clicked(object sender, EventArgs e)
        {
            popup.IsVisible = true;
            fadeEffect.IsVisible = true; 
        }
    }
}