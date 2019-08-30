

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace ChromeWindowDemo
{
    public static class StoryBoardExtensions
    {
        /// <summary>
        /// Add a slide-in animation to a story board that targets a control's Margin property
        /// The Begin method of <see cref="Storyboard"/> must be called with a <see cref="Control"/> as parameter afterward
        /// </summary>
        /// <param name="storyBoard"></param>
        /// <param name="seconds"></param>
        /// <param name="offset"></param>
        /// <param name="decelerationRatio"></param>
        public static void AddSlideInAnimation(this Storyboard storyBoard, double seconds, double offset,
            double decelerationRatio = 0.9)
        {


            var slideInAnimation = new ThicknessAnimation
            {
                DecelerationRatio = decelerationRatio,
                From = new Thickness(offset, 0, -offset, 0),
                Duration = TimeSpan.FromSeconds(seconds),
                To = new Thickness(0)
            };
            // Target the Margin property of a Control
            Storyboard.SetTargetProperty(slideInAnimation, new PropertyPath("Margin"));

            storyBoard.Children.Add(slideInAnimation);
        }


        /// <summary>
        /// Add a slide-out animation to a story board that targets a control's Margin property
        /// The Begin method of <see cref="Storyboard"/> must be called with a <see cref="Control"/> as parameter afterward
        /// </summary>
        /// <param name="storyBoard"></param>
        /// <param name="seconds"></param>
        /// <param name="offset"></param>
        /// <param name="decelerationRatio"></param>
        public static void AddSlideOutAnimation(this Storyboard storyBoard, double seconds, double offset,
            double decelerationRatio = 0.9)
        {


            var slideInAnimation = new ThicknessAnimation
            {
                DecelerationRatio = decelerationRatio,
                From = new Thickness(-offset, 0, offset, 0),
                Duration = TimeSpan.FromSeconds(seconds),
                To = new Thickness(0)
            };
            // Target the Margin property of a Control
            Storyboard.SetTargetProperty(slideInAnimation, new PropertyPath("Margin"));

            storyBoard.Children.Add(slideInAnimation);
        }

        public static void AddOpacityGrowAnimation(this Storyboard storyboard, double seconds)
        {
            var linearAnimation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(seconds));

            // Target the opacity of the control for animation
            Storyboard.SetTargetProperty(linearAnimation, new PropertyPath("Opacity"));

            storyboard.Children.Add(linearAnimation);
        }
    }
}
