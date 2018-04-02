using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
   public class UKCurrencyRepo : CurrencyRepo
    {
        public UKCurrencyRepo() : base() { }

        public override ICurrencyRepo MakeChange(double amt)
        {
            Decimal Amount = new Decimal(amt);
            while (Amount > 0)
            {
                if (Amount >= 5.00m)
                {
                    AddCoin(new FivePound());
                    Amount -= 5.00m;
                }
                else if (Amount >= 2.00m)
                {
                    AddCoin(new TwoPound());
                    Amount -= 2.00m;
                }
                else if (Amount >= 1.00m)
                {
                    AddCoin(new OnePound());
                    Amount -= 1.00m;
                }
                else if (Amount >= 0.50m)
                {
                    AddCoin(new FiftyPence());
                    Amount -= 0.50m;
                }
                else if (Amount >= 0.25m)
                {
                    AddCoin(new TwentyFivePence());
                    Amount -= 0.25m;
                }
                else if (Amount >= 0.20m)
                {
                    AddCoin(new TwentyPence());
                    Amount -= 0.20m;
                }
                else if (Amount >= 0.10m)
                {
                    AddCoin(new TenPence());
                    Amount -= 0.10m;
                }
                else if (Amount >= 0.05m)
                {
                    AddCoin(new FivePence());
                    Amount -= 0.05m;
                }
                else if (Amount >= 0.02m)
                {
                    AddCoin(new TwoPence());
                    Amount -= 0.02m;
                }
                else
                {
                    AddCoin(new OnePenny());
                    Amount -= 0.01m;
                }
            }
            return this;
        }
    }
}
