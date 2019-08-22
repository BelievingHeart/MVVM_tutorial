using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PropertyChanged;

namespace ChromeWindowDemo
{
    // This attribute will automatically implement INotifyPropertyChanged
    public class WindowViewModel : INotifyPropertyChanged
    {
        #region Private Member

        /// <summary>
        /// The window that this viewmodel controls
        /// </summary>
        private Window _window;

   
        private int _outerMarginSize = 10;
        private int _windowRadius = 10;
        private int _resizeBorder = 6;

        #endregion

        #region Private Sub

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void WindowOnStateChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginThickness));
            OnPropertyChanged(nameof(WindowCornerRadius));
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {
            _window = window;
            _window.StateChanged += WindowOnStateChanged;
        }

        #endregion

        #region Property

        

        /// <summary>
        /// The size of the resize border that you can grap with cursor around the window
        /// </summary>
        public Thickness ResizeBorderThickness => new Thickness(_resizeBorder + _outerMarginSize);
        /// <summary>
        /// The margin around the window to display a drop shadow
        /// </summary>
        public Thickness OuterMarginThickness => 
            _window.WindowState == WindowState.Maximized ? new Thickness(0) : new Thickness(_outerMarginSize);

        /// <summary>
        /// The radius of the rounded corners
        /// </summary>
        public CornerRadius WindowCornerRadius => 
            _window.WindowState == WindowState.Maximized ? new CornerRadius(0) : new CornerRadius(_windowRadius);

        public int CaptionHeight { get; set; }= 30;

        /// <summary>
        /// The height on the window's top that allows for dragging and clicking
        /// </summary>
        public GridLength CaptionHeightGridLength => new GridLength(CaptionHeight + _resizeBorder);
        #endregion


        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
