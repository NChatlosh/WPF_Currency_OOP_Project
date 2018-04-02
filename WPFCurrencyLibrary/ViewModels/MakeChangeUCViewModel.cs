using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary;
using CurrencyLibrary.USCurrency;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Input;

namespace WPFCurrencyLibrary.ViewModels
{
   public class MakeChangeUCViewModel : ViewModelBase
    {

        public ICommand MakeChangeCommand { get; set; }

        private string amount;
        public string Amount
        {
            get { return amount; }
            set
            {
                if(amount != value)
                {
                    amount = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public MakeChangeUCViewModel(USCurrencyRepo _repo) :base(_repo)
        {
            MakeChangeCommand = new BasicCommand(ExecuteCommandMakeChange, CanExecuteCommandMakeChange);
        }

        private bool CanExecuteCommandMakeChange(object parameter)
        {
            double amt;
            if((Double.TryParse(amount, out amt)))
            {
                if(amt > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ExecuteCommandMakeChange(object parameter)
        {
            double amt;
            Double.TryParse(amount, out amt);
            Repo = (USCurrencyRepo)Repo.MakeChange(amt);
            Amount = String.Empty;
        }

    }
}
