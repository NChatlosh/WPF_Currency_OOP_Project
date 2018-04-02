using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    [Serializable]
    public abstract class Coin : ICoin
    {
        private int year;
        private double monetaryValue;
        private string name;
        public int Year
        {
            get { return year; }
           protected set { year = value; }
        }
        public double MonetaryValue
        {
            get { return monetaryValue; }
            protected set { monetaryValue = value; }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public Coin() : this(2017)
        {
        }
        public Coin(int year)
        {
            Year = year;
        }

        public virtual string About()
        {
            return string.Format($"{Name} is from {Year}.");
        }

    }
}
