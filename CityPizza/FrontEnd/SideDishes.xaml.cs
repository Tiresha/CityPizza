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

namespace CityPizza.FrontEnd
{
    /// <summary>
    /// Interaction logic for SideDishes.xaml
    /// </summary>
    public partial class SideDishes : Window
    {
        public SideDishes()
        {
            InitializeComponent();
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
