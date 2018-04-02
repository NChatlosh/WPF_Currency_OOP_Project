using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
   public interface ICurrency
    {

        double MonetaryValue { get; }
        string Name { get; }

        string About();
    }
}
