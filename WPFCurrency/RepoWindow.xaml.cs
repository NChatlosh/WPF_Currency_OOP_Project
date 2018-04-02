using CurrencyLibrary;
using CurrencyLibrary.USCurrency;
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
using System.Windows.Shapes;
using WPFCurrency.UserControls; 

namespace WPFCurrency
{
    /// <summary>
    /// Interaction logic for RepoWindow.xaml
    /// </summary>
    public partial class RepoWindow : Window
    {
        private RepoUC uc;
        public RepoWindow(USCurrencyRepo repo)
        {
            InitializeComponent();
            uc = new RepoUC(repo);
            MainGrid.Children.Add(uc);
        }
    }
}
