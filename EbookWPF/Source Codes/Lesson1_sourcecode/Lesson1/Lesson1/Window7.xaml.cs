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

namespace Lesson1
{
    /// <summary>
    /// Interaction logic for Window7.xaml
    /// </summary>

    public partial class Window7 : System.Windows.Window
    {

        public Window7()
        {
            InitializeComponent();
            //
            //Đặt thuộc tính cửa sổ chính
            this.Height = 100; //chiều cao
            this.Width = 300;  //chiều rộng
            this.Title = "Lesson 1 - StackPanel"; //nhan đề
            //
            //Tạo StackPanel
            StackPanel stackPanel = new StackPanel();
            stackPanel.Background = new SolidColorBrush(Colors.Beige); //đặt thuộc tính màu nền
            stackPanel.Orientation = Orientation.Horizontal;  //Đặt hướng sắp đặt
            //
            //Tạo đối tượng Border 1
            Border border1 = new Border(); 
            border1.Width = 90; 
            border1.Height = 90;
            border1.BorderBrush = new SolidColorBrush(Colors.DarkSlateBlue); //đặt màu đường viền
            border1.Background = new SolidColorBrush(Color.FromRgb(169, 233, 105));
            border1.BorderThickness = new Thickness(2); //đặt độ dày đường viền
            //
            //Tạo đối tượng CheckBox
            CheckBox checkbox = new CheckBox();
            checkbox.Content = "Control 1"; //đặt nội dung text của CheckBox
            //
            //Đặt CheckBox vào trong Border 1
            border1.Child = checkbox;
            //
            //Tạo đối tượng Button
            Button button = new Button();
            button.Width = 90;
            button.Height = 90;
            button.Content = "Control 2";
            //
            //Tạo đối tượng Border 2
            Border border2 = new Border();
            border2.Width = 90;
            border2.Height = 90;
            border2.BorderBrush = new SolidColorBrush(Color.FromRgb(254, 202, 0));
            border2.BorderThickness = new Thickness(2);
            //
            //Tạo đối tượng TextBlock
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Control 3";
            //
            //Đặt TextBlock vào trong Border 2
            border2.Child = textBlock;
            //
            //Đặt các đối tượng đã tạo vào trong StackPanel
            stackPanel.Children.Add(border1);
            stackPanel.Children.Add(button);
            stackPanel.Children.Add(border2);
            //
            //Đặt StackPanel vào cửa sổ chính
            this.Content = stackPanel;

        }

    }
}