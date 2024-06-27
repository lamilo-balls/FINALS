using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FINALS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Scratch s = new Scratch();
        public MainWindow()
        {
            InitializeComponent();
            s.StreamRead();
        }

        private void numpad1 (object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button = (Button)sender;
            display.Text += button.Content;
        }

        
        private void confirm (object sender, RoutedEventArgs e)
        {
            try
            {
                for (int x = 0; x < s.Accounts.Count; x++)
                {
                    if (s.Accounts[x].Contains(int.Parse(display.Text)))
                    {


                        using(StreamWriter sw = new StreamWriter("C:\\Users\\Lorenzo Miguel Cruz\\Downloads\\Hold.txt"))
                        {
                            sw.Write(x);
                        }



                        Options options = new Options();
                        options.Show();
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid account.");
            }
        }

        private void cancel (object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button = (Button)sender;
            display.Text = null;
        }

    }
}