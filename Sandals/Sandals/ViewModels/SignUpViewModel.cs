using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sandals.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        private ICommand goToRegistrationCommand;
        public SignUpViewModel() 
        {
            goToRegistrationCommand = new Command(GoToRegistration);
        }

        public ICommand GoToRegistrationCommand 
        {
            get 
            {
                return goToRegistrationCommand;
            }
        }

        private void GoToRegistration() 
        {
            Shell.Current.GoToAsync("//login/register");
        }
    }
}
