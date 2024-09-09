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
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class Window1 : System.Windows.Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        //Dùng một StringBuilder để lưu trữ thông tin kết quả
        StringBuilder eventstr = new StringBuilder();

        //Đơn vị xử lý sự kiện Click của Button
        void HandleClick(object sender, RoutedEventArgs args)
        {
            //Lấy thông tin về đối tượng xử lý sự kiện Click, trong trường hợp này là My_StackPanel
            FrameworkElement fe = (FrameworkElement)sender;
            eventstr.Append("Sự kiện được xử lý bởi đối tượng có tên: ");
            eventstr.Append(fe.Name);
            eventstr.Append("\n");
            //
            //Lấy thông tin về nguồn phát ra sự kiện CLick:
            FrameworkElement fe2 = (FrameworkElement)args.Source;
            eventstr.Append("Sự kiện xuất phát từ nguồn đối tượng kiểu: ");
            //+ Loại thành phần UI;
            eventstr.Append(args.Source.GetType().ToString());
            //+ Định danh;
            eventstr.Append(" với tên gọi: ");
            eventstr.Append(fe2.Name);
            eventstr.Append("\n");
            //
            //Lấy thông tin về phương thức định tuyến
            eventstr.Append("Sự kiện sử dụng phương thức định tuyến: ");
            eventstr.Append(args.RoutedEvent.RoutingStrategy);
            eventstr.Append("\n");
            //
            //Đưa thông tin ra màn hình
            Results.Text = eventstr.ToString();
        }

    }
}