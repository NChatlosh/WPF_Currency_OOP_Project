using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class TwoPence : UKCoin
    {
        public TwoPence() :this(2017, UKMintage.Clark) { }
        public TwoPence(int year) :this(year, UKMintage.Clark) { }
        public TwoPence(int year, UKMintage mint) : base(year, mint)
        {
            Name = "Two Pence Coin";
            MonetaryValue = 0.02;
        }
    }
}
