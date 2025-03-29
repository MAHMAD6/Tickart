using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tickart.UI;
using Tickart.UI.Admin;
using Tickart.UI.User;

namespace Tickart
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
