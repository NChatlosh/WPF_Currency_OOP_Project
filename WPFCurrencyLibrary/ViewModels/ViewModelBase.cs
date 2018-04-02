using CurrencyLibrary;
using CurrencyLibrary.USCurrency;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace WPFCurrencyLibrary.ViewModels
{
   public abstract class ViewModelBase : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected string path;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        protected  USCurrencyRepo repo;
        public USCurrencyRepo Repo
        {
            get { return repo; }
            protected set
            {
                if(repo != value)
                {
                    repo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        protected string total;
        public string Total
        {
            get { return total; }
            set
            {
                if (total != value)
                {
                    total = "$ " + value;
                    NotifyPropertyChanged();
                }
            }
        }


        public ICommand SaveCommand { get; set; }

        public ViewModelBase(USCurrencyRepo _repo)
        {
            repo = _repo;
            repo.Coins.CollectionChanged += Coins_CollectionChanged;
            SaveCommand = new BasicCommand(ExecuteCommandSave, CanExecuteCommandSave);
            path = "DeafultPath";
        }

        protected void Coins_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged();
            UpdateTotal();
        }

        protected void UpdateTotal()
        {
            Total = repo.TotalValue().ToString();
        }

        protected bool CanExecuteCommandSave(object parameter)
        {
            if (repo.GetCoinCount() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void ExecuteCommandSave(object parameter)
        {

            IFormatter formatter = new BinaryFormatter();

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Currency Files | *.cur"
            };

            if (dialog.ShowDialog() == true)
            {
                if(dialog.FileName != string.Empty)
                {
                    path = dialog.FileName;
                }
                Stream stream = new FileStream(path,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, repo.Coins);
                stream.Close();
                MessageBox.Show($"Successfully saved {dialog.FileName}");

            }
            else
            {
                MessageBox.Show("Failed to save file");
            }

        }
    }
}
