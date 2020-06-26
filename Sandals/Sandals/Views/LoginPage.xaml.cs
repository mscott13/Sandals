using Sandals.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace Sandals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new SignUpViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//order_history");
        }
    }
}