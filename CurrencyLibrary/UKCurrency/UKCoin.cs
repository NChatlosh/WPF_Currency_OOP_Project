using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    public enum UKMintage { Machin, Maklouf, RankBroadley, Clark, RoyalShield}
   public class UKCoin : Coin
    {
        public UKMintage Mint { get; protected set; }
        public UKCoin() : this(2017) { }
        public UKCoin(int year) :this(year, UKMintage.Clark) { }
        public UKCoin(int year, UKMintage mint)
        {
            this.Year = year;
            this.Mint = mint;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
