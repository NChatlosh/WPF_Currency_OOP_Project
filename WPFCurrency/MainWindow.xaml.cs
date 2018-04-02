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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCurrency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static USCurrencyRepo repo;
        public static USCurrencyRepo Repo
        {
            get
            {

                return repo;
            }
            set { repo = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            repo = new USCurrencyRepo();
            repo.AddCoin(new Penny());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            RepoWindow window = new RepoWindow(repo);
            window.Show();
        }

        private void MakeChange_Click(object sender, RoutedEventArgs e)
        {
            MakeChangeWindow window = new MakeChangeWindow(repo);
            window.Show();
        }
    }
}
