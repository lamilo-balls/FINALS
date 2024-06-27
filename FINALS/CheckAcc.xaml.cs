using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for CheckAcc.xaml
    /// </summary>
    public partial class CheckAcc : Window
    {
        Scratch s = new Scratch();
        public CheckAcc()
        {
            InitializeComponent();
            s.StreamRead();
            int x;
            using (StreamReader sr = new StreamReader("C:\\Users\\Lorenzo Miguel Cruz\\Downloads\\Hold.txt"))
            {
                x = int.Parse(sr.ReadLine()); 
            }

            display.Text = s.Accounts[x][1].ToString();
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Lorenzo Miguel Cruz\\Downloads\\Receipt.txt"))
            {
                sw.WriteLine($"Account Number: {s.Accounts[x][0]}");
                sw.WriteLine($"Current amount of money: {s.Accounts[x][1]}");
            }
        }

        private void back2options(object sender, RoutedEventArgs e)
        {
            Options options = new Options();
            options.Show();
            this.Close();
        }
       
    }
}
