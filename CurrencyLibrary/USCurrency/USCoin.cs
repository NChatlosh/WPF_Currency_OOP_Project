using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark { get;}

        public USCoin(USCoinMintMark mark, int year) : base(year)
        {
            MintMark = mark;
        }

        public override string About()
        {
            return string.Format($"{base.About()} It is worth ${MonetaryValue}. It was made in {GetMintNameFromMark(MintMark)}.");
        }

        public static string GetMintNameFromMark(USCoinMintMark mark)
        {
            string s = string.Empty;
            switch (mark)
            {
                case USCoinMintMark.D:
                    s = "Denver";
                    break;
                case USCoinMintMark.O:
                    s = "New Orleans";
                    break;
                case USCoinMintMark.P:
                    s = "Philadelphia";
                    break;
                case USCoinMintMark.S:
                    s = "San Francisco";
                    break;
                case USCoinMintMark.W:
                    s = "West Point";
                    break;
                default:
                    s = "Denver";
                    break;
            }
            return s;
        }

    }


    public enum USCoinMintMark
    {
        P, D, S, W, O
    }
}
