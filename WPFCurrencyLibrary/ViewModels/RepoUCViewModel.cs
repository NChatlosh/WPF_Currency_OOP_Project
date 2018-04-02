using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary;
using CurrencyLibrary.USCurrency;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Win32;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows;
using System.Collections.Specialized;

namespace WPFCurrencyLibrary.ViewModels
{
   public class RepoUCViewModel : ViewModelBase
    {
        public ICommand AddCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand NewCommand { get; set; }

        private string quantity;
        public string Quantity
        {
            get { return quantity; }
            set
            {
                if(quantity != value)
                {
                    quantity = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public RepoUCViewModel(USCurrencyRepo _repo) :base(_repo)
        {
            AddCommand = new BasicCommand(ExecuteCommandAdd, CanExecuteCommandAdd);
            LoadCommand = new BasicCommand(ExecuteCommandLoad, CanExecuteCommandLoad);
            NewCommand = new BasicCommand(ExecuteCommandNew, CanExecuteCommandNew);
            UpdateTotal();
        }

        private bool CanExecuteCommandAdd(object parameter)
        {
            
            int qty;
            if(Int32.TryParse(quantity, out qty))
            {
                if(qty > 0 && parameter != null)
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

        private void ExecuteCommandAdd(object parameter)
        {
            int q;
            Int32.TryParse(quantity, out q);
            Coin coin = parameter as Coin;
            for(int i = 0; i < q; i++)
            {
                if(coin != null)
                Repo.AddCoin(coin);
            }
            Total = repo.TotalValue().ToString();
            Quantity = String.Empty;
        }
        private bool CanExecuteCommandLoad(object parameter)
        {
            return true;
        }

        private void ExecuteCommandLoad(object parameter)
        {
            ObservableCollection<ICoin> coins = new ObservableCollection<ICoin>();
            IFormatter formatter = new BinaryFormatter();

            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Currency Files | *.cur"
            };

            if (dialog.ShowDialog() == true)
            {
                if (dialog.FileName != string.Empty)
                {
                    path = dialog.FileName;
                }
                Stream stream = new FileStream(path,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
                 coins = (ObservableCollection<ICoin>)formatter.Deserialize(stream);
                stream.Close();
                MessageBox.Show($"Successfully Opened {dialog.FileName}");
            }
            if(coins.Count != 0)
            {
                //manually add values to the collection, cannot set collection to new one 
                //created by deserialization because collectionchanged event is reset
                this.repo.Coins.Clear();
                foreach(ICoin coin in coins)
                {
                    repo.AddCoin(coin);
                }
            }
            else
            {
                MessageBox.Show("Failed to load file");
            }
        }

        private bool CanExecuteCommandNew(object parameter)
        {
            return true;
        }

        private void ExecuteCommandNew(object parameter)
        {
            repo.Coins.Clear();
            repo.AddCoin(new Penny());
            UpdateTotal();
        }
    }
}
