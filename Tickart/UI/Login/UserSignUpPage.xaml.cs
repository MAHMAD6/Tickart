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
    public partial class UserSignUpPage : ContentPage
    {
        public UserSignUpPage()
        {
            InitializeComponent();
        }

        private void signin_clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();

        }

        private void admin_clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AdminLogin();

        }

        private void confirm(object sender, EventArgs e)
        {
            Application.Current.MainPage = new UserMenuTabbedPage();
        }
    }
}