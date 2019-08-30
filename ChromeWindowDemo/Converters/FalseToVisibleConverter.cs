

using System;
using System.Globalization;
using System.Windows;

namespace ChromeWindowDemo
{
    public class FalseToVisibleConverter : ValueConverterBase<FalseToVisibleConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var hasText = (bool) value;
            return hasText ? Visibility.Hidden : Visibility.Visible;

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
