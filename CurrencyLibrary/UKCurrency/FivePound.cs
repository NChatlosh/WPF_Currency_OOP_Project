using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class FivePound : UKCoin
    {
        public FivePound() :this(2017, UKMintage.RoyalShield) { }
        public FivePound(int year) :this(year, UKMintage.RoyalShield) { }
        public FivePound(int year, UKMintage mint) : base(year, mint)
        {
            Name = "Five Pound Coin";
            MonetaryValue = 5.00;
        }
    }
}
