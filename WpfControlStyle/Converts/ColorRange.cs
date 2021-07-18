using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfControlStyle.Converts
{
    public class ColorRange : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Double.TryParse(value.ToString(), out double number))
            {
                if (number < 100)
                    return Colors.Red;
                else
                    return Colors.Green;
            }
            else
            {
                return Binding.DoNothing;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
