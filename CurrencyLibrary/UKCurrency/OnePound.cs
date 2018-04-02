using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class OnePound : UKCoin
    {
        public OnePound() :this(2017, UKMintage.RoyalShield) { }
        public OnePound(int year) :this(year, UKMintage.RoyalShield) { }
        public OnePound(int year, UKMintage mint) : base(year, mint)
        {
            Name = "One Pound Coin";
            MonetaryValue = 1.00;
        }
    }
}
