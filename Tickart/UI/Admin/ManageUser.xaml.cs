using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tickart.UI.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManageUser : ContentPage
    {
        public ManageUser()
        {
            InitializeComponent();
            collection.ItemsSource = new List<string> { "hello", "bye" };
        }

        private void item_clicked(object sender, EventArgs e)
        {
            popup.IsVisible = true;
            fadeEffect.IsVisible = true;

        }
      

        private void OnFadeEffectTapped(object sender, EventArgs e)
        {
            popup.IsVisible = false;
            fadeEffect.IsVisible = false;
        }
    }
}