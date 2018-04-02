using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public class Dime : USCoin
    {
        public Dime() : this(USCoinMintMark.P, DateTime.Now.Year)
        {
        }
        public Dime(USCoinMintMark mark) : this(mark, DateTime.Now.Year)
        {
        }

        public Dime(USCoinMintMark mark, int year): base(mark, year)
        {
            this.MonetaryValue = 0.10;
            this.Name = "US Dime";
        }

        public override string ToString()
        {
            return "US Dime";
        }
    }
}
