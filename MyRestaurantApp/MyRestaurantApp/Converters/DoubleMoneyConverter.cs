using System;
using System.Globalization;
using Xamarin.Forms;

namespace MyRestaurantApp.Converters
{
    public class DoubleMoneyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double) value).ToString("C");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}