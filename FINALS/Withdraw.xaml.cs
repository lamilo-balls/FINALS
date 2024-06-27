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
    /// Interaction logic for Withdraw.xaml
    /// </summary>
    public partial class Withdraw : Window
    {
        Scratch s = new Scratch();
        public Withdraw()
        {
            InitializeComponent(); 
            s.StreamRead();
            

        }

        private void numpad1(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button = (Button)sender;
            display.Text += button.Content;
        }

        private void confirm(object sender, RoutedEventArgs e)
        {
            int x;
            using (StreamReader sr = new StreamReader("C:\\Users\\Lorenzo Miguel Cruz\\Downloads\\Hold.txt"))
            {
                x = int.Parse(sr.ReadLine());
            }
            try
            {
                if (s.Accounts[x][1] >= int.Parse(display.Text))
                {
                    s.Accounts[x][1] -= int.Parse(display.Text);
                    MessageBox.Show($"New Balance: {s.Accounts[x][1].ToString()}");
                    MessageBox.Show("Transaction successful");

                    using (StreamWriter sw = new StreamWriter("C:\\Users\\Lorenzo Miguel Cruz\\Downloads\\Accounts.txt"))
                    {
                        for (int i = 0; i < s.Accounts.Count; i++)
                        {
                            sw.WriteLine(s.Accounts[i][0] + " $" + s.Accounts[i][1]);
                        }
                    }
                    Options options = new Options();
                    options.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter valid amount");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid amount");

            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Lorenzo Miguel Cruz\\Downloads\\Receipt.txt"))
            {
                sw.WriteLine($"Account Number: {s.Accounts[x][0]}");
                sw.WriteLine($"Money transacted: -{display.Text}");
                sw.WriteLine($"Current amount of money: {s.Accounts[x][1]}");
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button = (Button)sender;
            display.Text = null;
        }

        private void back2options(object sender, RoutedEventArgs e)
        {
            Options options = new Options();
            options.Show();
            this.Close();
        }

       
    }
}
