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
using CurrencyLibrary;
using CurrencyLibrary.USCurrency;

namespace WPFCurrency
{
    /// <summary>
    /// Interaction logic for MakeChangeWindow.xaml
    /// </summary>
    public partial class MakeChangeWindow : Window
    {
        private MakeChangeUC uc;
        public MakeChangeWindow(USCurrencyRepo repo)
        {
            InitializeComponent();
            uc = new MakeChangeUC(repo);
            MainGrid.Children.Add(uc);
        }
    }
}
