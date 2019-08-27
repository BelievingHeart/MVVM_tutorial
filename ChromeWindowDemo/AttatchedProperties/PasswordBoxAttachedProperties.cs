
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup.Localizer;

namespace ChromeWindowDemo
{
    public class PasswordBoxAttachedProperties
    {
        #region HasTextProperty

        public static readonly DependencyProperty HasTextProperty = DependencyProperty.RegisterAttached(
            "HasText", typeof(bool), typeof(PasswordBoxAttachedProperties), new PropertyMetadata(default(bool)));

        private static void SetHasText(PasswordBox element)
        {
            element.SetValue(HasTextProperty, element.Password.Length > 0);
        }

        public static bool GetHasText(PasswordBox element)
        {
            return (bool) element.GetValue(HasTextProperty);
        }
        

        #endregion

        #region MonitorHasTextProperty

        public static readonly DependencyProperty MonitorHasTextProperty = DependencyProperty.RegisterAttached(
            "MonitorHasText", typeof(bool), typeof(PasswordBoxAttachedProperties), new PropertyMetadata(default(bool), OnMonitorHasTextChanged));

        private static void OnMonitorHasTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var passwordBox = (PasswordBox)d;

            if((bool)e.NewValue)
            {
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
                // Update HasText property when PasswordChanged is hooked
                SetHasText(passwordBox);
            }
            else
            {
                passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;
            }
        }

        /// <summary>
        /// Update HasText property when the password changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = (PasswordBox) sender;
            SetHasText(passwordBox);
        }

        public static void SetMonitorHasText(PasswordBox element, bool value)
        {
            element.SetValue(MonitorHasTextProperty, value);
        }

        public static bool GetMonitorHasText(PasswordBox element)
        {
            return (bool) element.GetValue(MonitorHasTextProperty);
        }

        #endregion
    }
}
