using cbb.core;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace cbb.ui
{
    /// <summary>
    /// Convert item type to <see cref="SolidColorBrush"/> color for UI as visual type indicator.
    /// </summary>
    [ValueConversion(typeof(FamilyItem),typeof(SolidColorBrush))]
    public class ItemTypeToColorValueConverter : IValueConverter
    {
        #region public methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Return color based on the type of 
            switch ((ItemType)value)
            {
                case ItemType.Project:
                    return new SolidColorBrush(Colors.OrangeRed);
                case ItemType.Family:
                    return new SolidColorBrush(Colors.CornflowerBlue);
                case ItemType.Cad:
                    return new SolidColorBrush(Colors.PaleGreen);
                case ItemType.Document:
                    return new SolidColorBrush(Colors.YellowGreen);
                case ItemType.None:
                    return new SolidColorBrush(Colors.Black);
                default:
                    break;
            }
            // indicate undefined item type, magenta for some kind of error in coversion process.
            return new SolidColorBrush(Colors.Magenta);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
