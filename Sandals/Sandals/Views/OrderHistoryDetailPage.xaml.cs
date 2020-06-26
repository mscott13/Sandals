using Sandals.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sandals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("HistoryId", "historyId")]
    public partial class OrderHistoryDetail : ContentPage
    {
        private string historyId;
        public OrderHistoryDetail()
        {
            InitializeComponent();
            this.BindingContext = new OrderHistoryDetailViewModel();
        }

        public string HistoryId
        {
            get { return historyId; }
            set
            {
                historyId = Uri.UnescapeDataString(value);
            }
        }
    }
}