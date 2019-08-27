
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using ChromeWindowDemo.Pages;

namespace ChromeWindowDemo
{
    /// <summary>
    /// PageType for value conversion in markup 
    /// </summary>
    public enum PageType
    {
        Login
    }

    public class EnumToPageConverter : BaseConverter<EnumToPageConverter>
    {
        //TODO: FINISH THIS
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var valueTyped = (PageType) value;

                switch (valueTyped)
                {
                    case PageType.Login: return new LoginPage();

                    default: Debugger.Break();
                        break;
                }
            }

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
