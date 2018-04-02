using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public interface ICurrencyRepo
    {
        ObservableCollection<ICoin> Coins { get; set; }
        string about();
        void AddCoin(ICoin c);
        int GetCoinCount();
        int GetCoinCount(ICoin coin);
        ICurrencyRepo MakeChange(double Amount);
        ICurrencyRepo MakeChange(double AmountTendered, double TotalCost);
        ICoin RemoveCoin(ICoin c);
        double TotalValue();
    }
}
