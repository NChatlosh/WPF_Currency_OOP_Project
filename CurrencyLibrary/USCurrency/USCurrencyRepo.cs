using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
   public class USCurrencyRepo : CurrencyRepo
    {
        private static ObservableCollection<ICoin> currencyList = new ObservableCollection<ICoin>()
        {
            new DollarCoin(),
            new HalfDollar(),
            new Quarter(),
            new Dime(),
            new Nickel(),
            new Penny()
        };
        public static ObservableCollection<ICoin> CurrencyList
        {
            get { return currencyList; }
        }
        
    }
}
