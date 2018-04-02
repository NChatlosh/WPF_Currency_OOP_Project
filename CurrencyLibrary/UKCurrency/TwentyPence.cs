using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class TwentyPence : UKCoin
    {
        public TwentyPence() :this(2017, UKMintage.Clark) { }
        public TwentyPence(int year) :this(year, UKMintage.Clark) { }
        public TwentyPence(int year, UKMintage mint) : base(year, mint)
        {
            Name = "Twenty Pence Coin";
            MonetaryValue = 0.20;
        }
    }
}
