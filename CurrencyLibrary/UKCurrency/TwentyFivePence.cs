using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class TwentyFivePence : UKCoin
    {
        public TwentyFivePence() :this(2017, UKMintage.Clark) { }
        public TwentyFivePence(int year) :this(year, UKMintage.Clark) { }
        public TwentyFivePence(int year, UKMintage mint) : base(year, mint)
        {
            Name = "Twenty-Five Pence Coin";
            MonetaryValue = 0.25;
        }
    }
}
