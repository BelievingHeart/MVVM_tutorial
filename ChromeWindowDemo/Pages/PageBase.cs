using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace ChromeWindowDemo
{
    /// <summary>
    /// Base page class that provide common functionality by inheritance
    /// </summary>
    public class PageBase<ViewModelType> : Page
    where ViewModelType: ViewModelBase, new()
    {
        #region Properties


        /// <summary>
        /// The animation to perform on loading
        /// </summary>
        public PageAnimationType LoadingAnimationType { get; set; } = PageAnimationType.SlideIn;

        /// <summary>
        /// The animation to perform on loading
        /// </summary>
        public PageAnimationType UnloadingAnimationType { get; set; } = PageAnimationType.SlideOut;

        /// <summary>
        /// The time duration to perform loading and unloading animation
        /// </summary>
        public double LoadUnloadSeconds { get; set; } = 6;

        /// <summary>
        /// The acceleration ration for page loading in and out
        /// </summary>
        public double InOutDecelerationRatio { get; set; } = 0.9;

        /// <summary>
        /// The backing field of <see cref="ViewModel"/>
        /// </summary>
        private ViewModelType _viewModel;

        /// <summary>
        /// The view model that is bound to this page
        /// Update DataContext in Setter
        /// </summary>
        public ViewModelType ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                this.DataContext = _viewModel;
            }
        }

        #endregion

        #region Constructors

        public PageBase()
        {
            this.Loaded += OnLoaded;
            this.Unloaded += OnUnloaded;

            // Set this.DataContext
            ViewModel = new ViewModelType();
        }

        #endregion

        #region Callbacks

        /// <summary>
        /// Callback that triggers upon loading to perform animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            switch (LoadingAnimationType)
            { 
                case PageAnimationType.SlideIn: PerformSlideInAnimation();
                    break;

                default: Debugger.Break();
                    break;
            }
        }

        /// <summary>
        /// Callback that triggers upon unloading to perform animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            switch (UnloadingAnimationType)
            {
                case PageAnimationType.SlideOut: 
                    PerformSlideOutAnimation();
                    break;
                default: Debugger.Break();
                    break;
            }
        }

        #endregion

        #region Implementations

        /// <summary>
        /// Performs a slide-in animation
        /// </summary>
        private void PerformSlideInAnimation()
        {
            var storyBoard = new Storyboard();

            storyBoard.AddSlideInAnimation(LoadUnloadSeconds, WindowWidth);

            storyBoard.Begin(this);
        }

        /// <summary>
        /// Performs a slide-out animation
        /// </summary>
        private void PerformSlideOutAnimation()
        {
            var storyBoard = new Storyboard();

            storyBoard.AddSlideOutAnimation(LoadUnloadSeconds, WindowWidth);

            storyBoard.Begin(this);
        }

        #endregion
    }

    /// <summary>
    /// Types of available animations for <see cref="PageBase"/>
    /// </summary>
    public enum PageAnimationType
    {
        /// <summary>
        /// No animation
        /// </summary>
        None = 0,

        /// <summary>
        /// A type of animation that performs when <see cref="PageBase"/> is loaded
        /// </summary>
        SlideIn = 1,

        /// <summary>
        /// A type of animation that performs when <see cref="PageBase"/> is unloaded
        /// </summary>
        SlideOut = 2
    }
}