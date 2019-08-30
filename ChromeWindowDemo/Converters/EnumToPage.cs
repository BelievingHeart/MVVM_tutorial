
using System;
using System.Diagnostics;
using System.Globalization;

namespace ChromeWindowDemo
{
    /// <summary>
    /// PageType for value conversion in markup 
    /// </summary>
    public enum PageType
    {
        /// <summary>
        /// Login page
        /// </summary>
        Login = 1,
        /// <summary>
        /// Chat page
        /// </summary>
        Chat = 2
    }

    public class EnumToPage : ValueConverterBase<EnumToPage>
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

                    case PageType.Chat: return new ChatPage();

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
