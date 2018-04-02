using CurrencyLibrary;
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
using WPFCurrencyLibrary.ViewModels;
using CurrencyLibrary.USCurrency;

namespace WPFCurrency.UserControls
{
    /// <summary>
    /// Interaction logic for RepoUC.xaml
    /// </summary>
    public partial class RepoUC : UserControl
    {
        public RepoUCViewModel vm;
        public RepoUC(USCurrencyRepo Repo)
        {
            InitializeComponent();
            vm = new RepoUCViewModel(Repo);
            this.DataContext = vm;
            Cb.ItemsSource = USCurrencyRepo.CurrencyList;
        }
    }
}
