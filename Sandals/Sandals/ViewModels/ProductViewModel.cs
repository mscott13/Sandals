using Sandals.Models;
using Sandals.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sandals.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        private ICommand toCartCommand;
        private List<Product> products;
        public ProductViewModel() 
        {
            toCartCommand = new Command(AddToCart);
            products = new DataService().GetProducts();
        }

        public ICommand ToCartCommand
        {
            get
            {
                return toCartCommand;
            }
        }

        public List<Product> Products 
        {
            get 
            {
                return products;
            }
            set 
            {
                SetProperty(ref products, value);
            }
        }

        public void AddToCart(object parameter) 
        {
            Shell.Current.GoToAsync("//cart");
        }
    }
}
