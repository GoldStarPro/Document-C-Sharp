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
    /// Interaction logic for Window5.xaml
    /// </summary>

    public partial class Window5 : System.Windows.Window
    {

        public Window5()
        {
            // Bind a list of Person-objects to an ItemsControl
           //personItems.ItemsSource = CreatePersons();

        }


        /// <summary>
        /// Create some sample-data
        /// </summary>
        /// <returns>List<Person></returns>
       


    }


    public class Staffs
    {
        private List<Person> staffs;
        
        public IEnumerable<Person> StaffList
        {
            get { return staffs; }
        }

        public Staffs()
        {
            staffs = new List<Person>();
            staffs.Add(new Person("Mary", "mary.jpg"));
            staffs.Add(new Person("Johny", "johny.jpg"));
            staffs.Add(new Person("Olaf", "olaf.jpg"));
            staffs.Add(new Person("Scooby Doo", "scooby_doo.jpg"));
        }        
    }

    public class Person
    {
        public Person(string name, string imageRef)
        {
            this.Name = name;
            this.ImageRef = imageRef;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _imageRef;
        public string ImageRef
        {
            get { return _imageRef; }
            set { _imageRef = value; }
        }
    }

    public class PersonImageConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Hàm chuyển đổi từ đường dẫn ảnh sang đối tượng Bitmap
        /// </summary>
        public object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            string imageName = value.ToString();
            Uri uri = new Uri(imageName, UriKind.RelativeOrAbsolute);
            BitmapFrame source = BitmapFrame.Create(uri);

            return source;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}