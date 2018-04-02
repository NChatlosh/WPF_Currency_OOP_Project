using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class TwoPound : UKCoin
    {
        public TwoPound() :this(2017, UKMintage.RoyalShield) { }
        public TwoPound(int year) :this(year, UKMintage.RoyalShield) { }
        public TwoPound(int year, UKMintage mint) : base(year, mint)
        {
            Name = "Two Pound Coin";
            MonetaryValue = 2.00;
        }
    }
}
