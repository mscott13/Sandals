using Sandals.Models;
using Sandals.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sandals.ViewModels
{
    public class OrderHistoryViewModel : ViewModelBase
    {
        ICommand showHistoryDetailCommand;
        public OrderHistoryViewModel()
        {
           OrderHistories = new DataService().GetOrderHistory();
           showHistoryDetailCommand = new Command(ShowHistoryDetail);
        }
        private List<OrderHistory> orderHistories;

        public List<OrderHistory> OrderHistories
        {
            get { return orderHistories; }
            set
            {
                SetProperty(ref orderHistories, value);
            }
        }

        public ICommand ShowHistoryDetailCommand 
        {
            get 
            {
                return showHistoryDetailCommand;
            }
        }
        private void ShowHistoryDetail(object parameter)
        {
            int historyId = ((OrderHistory)parameter).OrderHistoryId;
            Shell.Current.GoToAsync($"history_detail?historyId={historyId}");
        }
    }
}
