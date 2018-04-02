using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public class Nickel : USCoin
    {
        public Nickel() : this(USCoinMintMark.P, DateTime.Now.Year)
        {
        }

        public Nickel(USCoinMintMark mark) : this(mark, DateTime.Now.Year)
        {
        }

        public Nickel(USCoinMintMark mark, int year): base(mark, year)
        {
            this.MonetaryValue = 0.05;
            this.Name = "US Nickel";
        }

        public override string ToString()
        {
            return "US Nickel";
        }
    }
}
