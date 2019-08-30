
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Media;

namespace ChromeWindowDemo
{

    public class HexStringToBrushConverter : ValueConverterBase<HexStringToBrushConverter>
    {
        //TODO: FINISH THIS
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var codeString = (string) value;
                return (SolidColorBrush)new BrushConverter().ConvertFromString($"#{codeString}");
            }

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
