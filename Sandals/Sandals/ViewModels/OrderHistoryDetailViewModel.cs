using Sandals.Models;
using Sandals.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sandals.ViewModels
{
    public class OrderHistoryDetailViewModel : ViewModelBase
    {
        private ICommand cancelOrderCommand;
        private OrderHistoryDetail orderHistoryDetail;
        public OrderHistoryDetailViewModel() 
        {
            cancelOrderCommand = new Command(CancelOrder);
            OrderHistoryDetail = new DataService().GetOrderHistoryDetail(1);
        }

        public OrderHistoryDetail OrderHistoryDetail 
        {
            get { return orderHistoryDetail; }
            set 
            {
                SetProperty(ref orderHistoryDetail, value);
            }
        }

        public ICommand CancelOrderCommand
        {
            get
            {
                return cancelOrderCommand;
            }
        }
        private void CancelOrder(object parameter)
        {
           //cancel order here;
        }
    }
}
