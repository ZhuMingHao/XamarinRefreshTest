using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinRefreshTest
{
    public class SalesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    
        public ObservableCollection<SaleModel> Sales { get; set; }
        
        public SalesViewModel()
        {
            Sales = new ObservableCollection<SaleModel>() { new SaleModel { Quantity =26 } };
        }

    }
}
