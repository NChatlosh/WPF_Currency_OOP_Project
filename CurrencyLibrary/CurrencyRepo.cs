using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary.USCurrency;
using System.Collections.ObjectModel;

namespace CurrencyLibrary
{
    public class CurrencyRepo : ICurrencyRepo
    {
        protected ObservableCollection<ICoin> coins;
        public ObservableCollection<ICoin> Coins
        {
            get { return coins; }
            set { coins = value; }
        }

        public CurrencyRepo()
        {
            coins = new ObservableCollection<ICoin>();
        }

        public virtual string about()
        {
            return string.Empty;
        }

        public void AddCoin(ICoin c)
        {
            coins.Add(c); ;
        }

        public int GetCoinCount()
        {
            return coins.Count;
        }
        public int GetCoinCount(ICoin coin)
        {
            int count = 0;
            foreach(ICoin c in Coins)
            {
                if(c.GetType() == coin.GetType())
                {
                    count++;
                }
            }
            return count;
        }

        public virtual ICurrencyRepo MakeChange(double Amount)
        {
            while (Amount > 0)
            {
                if (Amount >= 1.00)
                {
                    AddCoin(new DollarCoin());
                    Amount -= 1.00;
                }
                else if (Amount >= 0.50)
                {
                    AddCoin(new HalfDollar());
                    Amount -= 0.50;
                }
                else if (Amount >= 0.25)
                {
                    AddCoin(new Quarter());
                    Amount -= 0.25;
                }
                else if (Amount >= 0.10)
                {
                    AddCoin(new Dime());
                    Amount -= 0.10;
                }
                else if (Amount >= 0.05)
                {
                    AddCoin(new Nickel());
                    Amount -= 0.05;
                }
                else
                {
                    AddCoin(new Penny());
                    Amount -= 0.01;
                }
            }
            return this;
        }

        public virtual ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            return MakeChange(AmountTendered);
        }

        public static ICurrencyRepo CreateChange(double Amount)
        {
            CurrencyRepo repo = new CurrencyRepo();
            return repo.MakeChange(Amount);
        }

        public static ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            CurrencyRepo repo = new CurrencyRepo();
            return repo.MakeChange(AmountTendered, TotalCost);
        }

        public ICoin RemoveCoin(ICoin c)
        {
            coins.Remove(c);
            return c;
        }

        public double TotalValue()
        {
            double value = 0;
            foreach(ICoin coin in coins)
            {
                value += coin.MonetaryValue;
            }
            return value;
        }
    }
}
