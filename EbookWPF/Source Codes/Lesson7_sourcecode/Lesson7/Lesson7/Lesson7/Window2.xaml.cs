using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lesson7
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>

    public partial class Window2 : System.Windows.Window
    {

        public Window2()
        {
            InitializeComponent();
        }

        protected void OnOKButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gutten Morgen!");
        }

    }
}