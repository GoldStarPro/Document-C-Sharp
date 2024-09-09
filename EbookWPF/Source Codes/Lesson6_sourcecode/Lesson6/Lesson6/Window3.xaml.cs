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

namespace Lesson6
{

    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    /// 
    public partial class Window3 : System.Windows.Window
    {

        public Window3()
        {
            InitializeComponent();
        }

        private void DeleteCustomer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = lsbCustomers.SelectedItem != null;
        }

        private void DeleteCustomer_Executed(object sender,
           ExecutedRoutedEventArgs e)
        {
            lsbCustomers.Items.Remove(lsbCustomers.SelectedItem);
        }

        private void DeleteProduct_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = lsbProducts.SelectedItem != null;
        }

        private void DeleteProduct_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            lsbProducts.Items.Remove(lsbProducts.SelectedItem);
        }


        private void InsertCustomer_CanExecute(object sender,
           CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void InsertCustomer_Executed(object sender,
           ExecutedRoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = "New Customer";
            lsbCustomers.Items.Add(item);
        }

    }

    public static class MyCommands
    {
        public readonly static RoutedUICommand InsertCustomer;

        static MyCommands()
        {
            InsertCustomer = new RoutedUICommand(
               "Insert Customer", "InsertCustomer",
               typeof(MyCommands));
        }

        
        //{
        //    get
        //    {
        //        return new RoutedUICommand(
        //       "Insert Customer", "InsertCustomer",
        //       typeof(MyCommands));

        //    }

        //    private set { }
        //}
    }

}









