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

namespace Lesson3
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>

    public partial class Window4 : System.Windows.Window
    {
        //Đặt các cờ xác định lựa chọn tương ứng với các loại đồ uống
        bool selectedOrange;
        bool selectedKiwi;
        bool selectedMango;
        bool selectedMilk;
        bool selectedEspesso;

        public Window4()
        {
            InitializeComponent();
            //
            //Khởi tạo biến đánh dấu chọn
            selectedOrange = false;
            selectedKiwi = false;
            selectedMango = false;
            selectedMilk = false;
            selectedEspesso = false;
        }


        //Hàm xử lý sự kiện bỏ chọn (Unchecked) của mỗi checkbox
        //Lưu ý: Ở đây ta chỉ sử dụng một hàm duy nhất xử lý sự kiện này cho mọi checkbox
        //Để phân biệt checkbox nào phát động sự kiện, ta dựa vào tham số sender và so sánh nó với các checkbox
        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(chkCafe))selectedEspesso = false;
            if (sender.Equals(chkKiwiJuice)) selectedKiwi = false;
            if (sender.Equals(chkMangoJuice)) selectedMango = false;
            if (sender.Equals(chkMilk)) selectedMilk = false;
            if (sender.Equals(chkOrangeJuice)) selectedOrange = false;
            
        }

        //Hàm xử lý sự kiện bỏ chọn (checked) của mỗi checkbox (tương tự như trên)
        private void HandleChecked(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(chkCafe)) selectedEspesso = true;
            if (sender.Equals(chkKiwiJuice)) selectedKiwi = true;
            if (sender.Equals(chkMangoJuice)) selectedMango = true;
            if (sender.Equals(chkMilk)) selectedMilk = true;
            if (sender.Equals(chkOrangeJuice)) selectedOrange = true;
        }

        //Hàm xử lý sự kiện hiển thị các đồ uống được chọn
        private void DislayCustomerChoices(object sender, RoutedEventArgs e)
        {
            String choices = "Ban da chon ";
            bool selected = false;
            //
            if (selectedOrange)
            {
                choices += "Nuoc cam; ";
                selected = true;
            }
            //
            if (selectedMilk)
            {
                choices += "Sua tuoi; ";
                selected = true;
            }
            //
            if (selectedMango)
            {
                choices += "Nuoc soai ep; ";
                selected = true;
            }
            //
            if (selectedEspesso)
            {
                choices += "Cafe Espresso;";
                selected = true;
            }
            //
            if (!selected) choices = "Ban chua chon do uong nao";
            //
            MessageBox.Show(choices);

        }

    }
}