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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b, s;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, RoutedEventArgs e)
        {
            s = a + b;
            txtDapan.Text = s.ToString();
        }

        private void txta_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = Double.Parse(txta.Text);
        }

        private void txtb_TextChanged(object sender, TextChangedEventArgs e)
        {
            b = Double.Parse(txtb.Text);
        }

        private void btnHieu_Click(object sender, RoutedEventArgs e)
        {
            s = a - b;
            txtDapan.Text = s.ToString();
        }

        private void btnTich_Click(object sender, RoutedEventArgs e)
        {
            s = a * b;
            txtDapan.Text = s.ToString();
        }

        private void btnThuong_Click(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = float.Parse(txta.Text);

            b = float.Parse(txtb.Text);
            if (b == 0)
            {
                MessageBox.Show("error");
            }
            else
            {
                c = a / b;
                //Ketqua.Text = c.ToString();
                txtDapan.Text = string.Format("{0:0.0}", c);
            }
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }        
    }
}
