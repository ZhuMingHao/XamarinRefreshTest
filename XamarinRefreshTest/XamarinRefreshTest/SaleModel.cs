using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace XamarinRefreshTest
{
    public class SaleModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        private double quantity;
 
        public ICommand AddQuantityCommand => new Command<SaleModel>(item =>
        {
            item.Quantity +=1;
        });

        public double Quantity
        {
            get => quantity;
            set
            {

                quantity = value;
                OnPropertyChanged();
            }
        }
    }
}
