using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace SimpleDataGrid2.Converters
{
    public class BoolToImageConverter : IValueConverter
    {
        BitmapImage meatImage = new BitmapImage(new Uri(@".\Images\fleisch.png", UriKind.Relative));
        BitmapImage veganImage = new BitmapImage(new Uri(@".\Images\vegan.png", UriKind.Relative));

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var temp = (bool)value;
            if (temp)
            {
                return meatImage;
            }
            return veganImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
