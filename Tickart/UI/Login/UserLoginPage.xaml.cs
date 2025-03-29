using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickart.UI.User;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tickart.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }



        private  void Admin_click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AdminLogin();
        }

        private void SignUp_click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new UserSignUpPage();
        }

        private void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            popup.IsVisible = true;
            fadeEffect.IsVisible = true;
        }

        private void OnFadeEffectTapped(object sender, EventArgs e)
        {
            popup.IsVisible = false;
            fadeEffect.IsVisible = false;
        }

        private void confirm(object sender, EventArgs e)
        {
            Application.Current.MainPage = new UserMenuTabbedPage();

        }
    }
}