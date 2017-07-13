using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinRefreshTest
{
    public partial class MainPage : ContentPage
    {
        private SalesViewModel viewmodel;
        public MainPage()
        {
            InitializeComponent();
            viewmodel = new SalesViewModel();
            this.BindingContext = viewmodel;
            //ListView.ItemsSource = viewmodel.Sales;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            viewmodel.Sales[0].Quantity = 24;
            viewmodel.Sales.Add(new SaleModel { Quantity = 25});
        }
    }
}
