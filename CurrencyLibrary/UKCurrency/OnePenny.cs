using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    public class OnePenny : UKCoin
    {
        public OnePenny() :this(2017, UKMintage.Clark) {}
        public OnePenny(int year) :this(year, UKMintage.Clark) { }
        public OnePenny(int year, UKMintage mint) : base(year, mint)
        {
            Name = "One Penny Coin";
            MonetaryValue = 0.01;
        }
    }
}
