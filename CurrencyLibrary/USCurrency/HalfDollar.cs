using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public class HalfDollar : USCoin
    {
        public HalfDollar() : this(USCoinMintMark.P, DateTime.Now.Year)
        {
        }

        public HalfDollar(USCoinMintMark mark) : this(mark, DateTime.Now.Year)
        {
        }

        public HalfDollar(USCoinMintMark mark, int year): base(mark, year)
        {
            this.MonetaryValue = 0.50;
            this.Name = "US Half Dollar";
        }

        public override string ToString()
        {
            return "US Half Dollar Coin";
        }
    }
}
