using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tickart.UI.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TicketPage : ContentPage
    {
        public TicketPage()
        {
            InitializeComponent();
            collection.ItemsSource = new List<string> { "hello", "bye"};

        }

        private void Cart_clicked(object sender, EventArgs e)
        {
            popup.IsVisible = true;
            fadeEffect.IsVisible = true;
        }

        private void cartConfirm_Clicked(object sender, EventArgs e)
        {
            popup.IsVisible = false;
            fadeEffect.IsVisible = false;
        }

        private void OnFadeEffectTapped(object sender, EventArgs e)
        {
            popup.IsVisible = false;
            fadeEffect.IsVisible = false;
        }
    }
}