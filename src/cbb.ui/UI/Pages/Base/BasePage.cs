using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Animation;
using System;

namespace cbb.ui
{
    /// <summary>
    /// A base page to extend basic page functionality.
    /// </summary>
    public class BasePage : Page
    {
        #region public properties
        /// <summary>
        /// Gets or sets the animation type.
        /// </summary>
        public PageAnimationType Animation { get; set; } = PageAnimationType.Fade;
        /// <summary>
        /// Gets or sets the duration of the animation in secods.
        /// </summary>
        public float AnimationDuration { get; set; } = 0.3f;
        #endregion



        #region constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="BasePage"/>
        /// </summary>
        public BasePage()
        {
            //If there is animation then hide page to beggin animation

            if (Animation != PageAnimationType.None)
                Visibility = Visibility.Collapsed;

            //Do animation on loadded event.
            Loaded += BasePage_Load;
        }

        
        #endregion


        #region private methods
        /// <summary>
        /// Animates the page based on provided animation type.
        /// </summary>
        private void AnimatePage()
        {
            if (Animation == PageAnimationType.None)
                return;

            else if (Animation == PageAnimationType.Fade)
            {
                //Define animation properties.
                DoubleAnimation animation = new DoubleAnimation
                {
                    From = 0.0,
                    To = 1.0,
                    Duration = TimeSpan.FromSeconds(AnimationDuration),
                    DecelerationRatio = 0.85f
                };
                //Do the animation.
                BeginAnimation(OpacityProperty,animation);
                Visibility = Visibility.Visible;
            }

            else
            {
                Storyboard storyBoard = new Storyboard();
                //Define animation properties.
                ThicknessAnimation animation = new ThicknessAnimation
                {
                    Duration = new Duration(TimeSpan.FromSeconds(AnimationDuration)),
                    From = new Thickness(640, 0, -640, 0),
                    To = new Thickness(0),
                    DecelerationRatio = 0.85f
                };
                //Do the animation.
                BeginAnimation(OpacityProperty, animation);
                Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BasePage_Load(object sender, RoutedEventArgs e)
        {
            AnimatePage();
        }

        #endregion
    }
}