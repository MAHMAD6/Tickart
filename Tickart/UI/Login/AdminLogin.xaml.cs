using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickart.UI.Admin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tickart.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminLogin : ContentPage
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void signin_clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();

        }

        private void OnFadeEffectTapped(object sender, EventArgs e)
        {
            popup.IsVisible = false;
            fadeEffect.IsVisible = false;
        }

        private void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            popup.IsVisible = true;
            fadeEffect.IsVisible = true;
        }

        private void Adminlogin_clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AdminMenuTabbedPage();

        }
    }
}