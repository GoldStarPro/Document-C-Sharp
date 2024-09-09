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

namespace WpfControlSample1
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

private void button1_Click(object sender, RoutedEventArgs e)
{
    String strMessage, strHoTen, strTitle, strNgoaiNgu="";
    strHoTen = textBox1.Text + " " + textBox2.Text;
    if (radioButton1.IsChecked==true)
        strTitle = "Mr.";
    else
        strTitle = "Miss/Mrs.";
    strMessage = "Xin chào: " + strTitle + " " + strHoTen;

    if (checkBox1.IsChecked == true)
    {
        strNgoaiNgu = "Tiếng Anh";
    }
    if (checkBox2.IsChecked == true)
    {
        strNgoaiNgu = (strNgoaiNgu.Length==0) ? "Tiếng Trung": (strNgoaiNgu+" và Tiếng Trung");
    }
    strMessage += "\n Ngoại ngữ: " + strNgoaiNgu;
    if (comboBox1.SelectedIndex >= 0)//Nếu đã có một mục trong danh sách được chọn
    {
        strMessage += "\n Quê Quán: " + comboBox1.Text;
    }
    MessageBox.Show(strMessage);
}

private void button2_Click(object sender, RoutedEventArgs e)
{
    textBox1.Text = "";
    textBox2.Text = "";
    radioButton1.IsChecked = true;
    radioButton2.IsChecked = false;
    checkBox1.IsChecked = false;
    checkBox2.IsChecked = false;
    comboBox1.SelectedIndex = 0;
}


    }
}
