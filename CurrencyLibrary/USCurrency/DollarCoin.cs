using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public class DollarCoin : USCoin
    {

        public DollarCoin () : this(USCoinMintMark.P, DateTime.Now.Year)
        {
        }

        public DollarCoin(USCoinMintMark mark) : this(mark, DateTime.Now.Year)
        {
        }

        public DollarCoin(USCoinMintMark mark, int year): base(mark, year)
        {
            this.MonetaryValue = 1.00;
            this.Name = "US Dollar Coin";
        }

        public override string ToString()
        {
            return "US Dollar Coin";
        }
    }
}
