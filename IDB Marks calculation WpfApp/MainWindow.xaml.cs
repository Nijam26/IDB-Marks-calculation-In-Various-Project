using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt01.MaxLength = 2;
            txt02.MaxLength = 2;
        }

        private void btn_Cal_Click(object sender, RoutedEventArgs e)
        {
            int num1 = 0;
            int.TryParse(txt01.Text,out num1);

            if (num1 < 20 && txt01.Text != "")
            {
                
            }
            else if (num1 > 50 && txt01.Text != "")
            {
                txt01.Text = "50";
                MessageBox.Show("Maximum Number is 50");
                txt01.Clear();
            }


            int num2 = 0;
            int.TryParse(txt02.Text, out num2);

            if (num2< 32 && txt02.Text != "")
            {
                
            }
            else if (num2 > 50 && txt02.Text != "")
            {
                txt02.Text = "50";
                MessageBox.Show("Maximum Number is 50");
                txt02.Clear();
            }


            double total1 = Math.Round((double)(num1 * .20), 2);

            txt03.Text = total1.ToString();
            
            double total2 = Math.Round((double)(num2 * .80), 2);

            txt04.Text = total2.ToString();


            int total = (int)Math.Round((num1 * .20) + (num2 * .80));

            txt_total.Text = total.ToString();

            if (total >= 30)
            {
                txt_status.Text = "Passed";
            }
            else
            {
                txt_status.Text = "Failed";
            }

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_clr_Click(object sender, RoutedEventArgs e)
        {
            txt01.Clear();
            txt02.Clear();
            txt03.Clear();
            txt04.Clear();
            txt_total.Clear();
            txt_status.Clear();        
        }
        private void txt_total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
