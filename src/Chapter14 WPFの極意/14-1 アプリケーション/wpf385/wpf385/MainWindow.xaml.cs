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

namespace wpf385
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clickLarge(object sender, RoutedEventArgs e)
        {
            text.FontSize = 20;
        }

        private void clickMiddle(object sender, RoutedEventArgs e)
        {
            text.FontSize = 12;
        }

        private void clickSmall(object sender, RoutedEventArgs e)
        {
            text.FontSize = 9;
        }
    }
}
