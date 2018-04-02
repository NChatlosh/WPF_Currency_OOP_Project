using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class FivePence : UKCoin
    {
        public FivePence() :this(2017, UKMintage.Clark) { }
        public FivePence(int year) :this(year, UKMintage.Clark) { }
        public FivePence(int year, UKMintage mint) : base(year, mint)
        {
            Name = "Five Pence Coin";
            MonetaryValue = 0.05;
        }
    }
}
