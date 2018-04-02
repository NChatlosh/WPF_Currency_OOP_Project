using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CurrencyLibrary;
using WPFCurrencyLibrary.ViewModels;
using CurrencyLibrary.USCurrency;

namespace WPFCurrency.UserControls
{
    /// <summary>
    /// Interaction logic for MakeChangeUC.xaml
    /// </summary>
    public partial class MakeChangeUC : UserControl
    {
        public MakeChangeUCViewModel vm;
        public MakeChangeUC(USCurrencyRepo Repo)
        {
            InitializeComponent();
            vm = new MakeChangeUCViewModel(Repo);
            this.DataContext = vm;
            Coins.ItemsSource = vm.Repo.Coins;
        }
    }
}
