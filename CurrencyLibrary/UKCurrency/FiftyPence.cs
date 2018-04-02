using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class FiftyPence : UKCoin
    {
        public FiftyPence() :this(2017, UKMintage.Clark) { }
        public FiftyPence(int year) :this(year, UKMintage.Clark) { }
        public FiftyPence(int year, UKMintage mint) : base(year, mint)
        {
            Name = "Fifty Pence Coin";
            MonetaryValue = 0.50;
        }
    }
}
