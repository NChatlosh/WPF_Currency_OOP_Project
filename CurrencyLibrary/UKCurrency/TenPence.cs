using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class TenPence : UKCoin
    {
        public TenPence() :this(2017, UKMintage.Clark) { }
        public TenPence(int year) :this(year, UKMintage.Clark) { }
        public TenPence(int year, UKMintage mint) : base(year, mint)
        {
            Name = "Ten Pence Coin";
            MonetaryValue = 0.10;
        }
    }
}
