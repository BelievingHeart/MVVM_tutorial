using System;
using System.Windows;
using System.Windows.Controls;

namespace ChromeWindowDemo
{
    public class PasswordBox_MonitorHasTextProperty : AttachedPropertyOwnerBase<PasswordBox_MonitorHasTextProperty, bool>
    {
        public override void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // make sure it is attached to a PasswordBox
            var passwordBox = d as PasswordBox;
            if (passwordBox == null) return;

            var isMonitored = (bool) e.NewValue;
            if (isMonitored)
            {
                passwordBox.PasswordChanged += PasswordBoxOnPasswordChanged;
                // Set HasText on hookup
                PasswordBox_HasTextProperty.SetValue(passwordBox);
            }
            else
            {
                passwordBox.PasswordChanged -= PasswordBoxOnPasswordChanged;
            }
        }

        /// <summary>
        /// Set HasText property on password changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBoxOnPasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox_HasTextProperty.SetValue((PasswordBox)sender);
        }
    }

    public class PasswordBox_HasTextProperty : AttachedPropertyOwnerBase<PasswordBox_HasTextProperty, bool>
    {
        public override void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // do nothing
        }

        public static void SetValue(PasswordBox passwordBox)
        {
            SetValue(passwordBox, passwordBox.Password.Length > 0);
        }
    }
}