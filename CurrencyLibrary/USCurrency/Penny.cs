using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public class Penny : USCoin
    {
        public Penny() : this(USCoinMintMark.P, DateTime.Now.Year)
        {
        }

        public Penny(USCoinMintMark mark) : this(mark, DateTime.Now.Year)
        {
        }

        public Penny(USCoinMintMark mark, int year): base(mark, year)
        {
            this.MonetaryValue = 0.01;
            this.Name = "US Penny";
        }

        public override string ToString()
        {
            return "US Penny";
        }

    }

}
