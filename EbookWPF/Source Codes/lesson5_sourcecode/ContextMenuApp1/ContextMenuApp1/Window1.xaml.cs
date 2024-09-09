using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ContextMenuApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
   
        }
 
        private void Bold_Checked1(object sender, RoutedEventArgs e)
        {
            cmButton1.FontWeight = FontWeights.Bold;
        }

        private void Bold_Unchecked1(object sender, RoutedEventArgs e)
        {
            cmButton1.FontWeight = FontWeights.Normal;
        }
        private void Message1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn thực đơn nút bấm 1");
        }
        private void Bold_Checked2(object sender, RoutedEventArgs e)
        {
            cmButton2.FontWeight = FontWeights.Bold;
        }

        private void Bold_Unchecked2(object sender, RoutedEventArgs e)
        {
            cmButton2.FontWeight = FontWeights.Normal;
        }
        private void Message2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn thực đơn nút bấm 2");
        }
    }
}
