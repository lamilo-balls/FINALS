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

namespace FINALS
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void back2mainwindow (object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void deposit(object sender, RoutedEventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Close();
        }

        private void withdraw(object sender, RoutedEventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Close();
        }

        private void checkacc(object sender, RoutedEventArgs e)
        {
            CheckAcc checkacc = new CheckAcc();
            checkacc.Show();
            this.Close();
        }
    }
}
