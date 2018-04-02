using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public class Quarter : USCoin
    {
        public Quarter() : this(USCoinMintMark.P, DateTime.Now.Year)
        {
        }
        public Quarter(USCoinMintMark mark) : this(mark, DateTime.Now.Year)
        {
        }

        public Quarter(USCoinMintMark mark, int year): base(mark, year)
        {
            this.MonetaryValue = 0.25;
            this.Name = "US Quarter";
        }

        public override string ToString()
        {
            return "US Quarter";
        }
    }
}
