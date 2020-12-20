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
using CityPizza.FrontEnd;

namespace CityPizza
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class OrderDetails : Window
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void Pizza_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage();
            paymentPage.Show();
        }

        private void OrderDetail_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SideDishes_Click(object sender, RoutedEventArgs e)
        {
            SideDishes sideDishes = new SideDishes();
            sideDishes.Show();

        }

        private void Dips_Click(object sender, RoutedEventArgs e)
        {
            Dips dips = new Dips();
            dips.Show();
        }

        private void Wings_Click(object sender, RoutedEventArgs e)
        {
            Wings wingsWindow = new Wings();
            wingsWindow.Show();
        }

        private void Sauce_Click(object sender, RoutedEventArgs e)
        {
            Sauce sauceWindow = new Sauce();
            sauceWindow.Show();
        }

        private void Beverages_Click(object sender, RoutedEventArgs e)
        {
            Beverages beverages = new Beverages();
            beverages.Show();
        }
    }
}
