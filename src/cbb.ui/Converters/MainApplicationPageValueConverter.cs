using cbb.core;
using cbb.ui;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace cbb.ui
{
    /// <summary>
    /// Converts 
    /// </summary>
    public class MainApplicationPageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Switch current application page based on provided type of the page.
            switch ((ApplicationPageType)value)
            {
                case ApplicationPageType.Family:
                    return new FamilyPage();
                case ApplicationPageType.Preferences:
                    return new PreferencesPage();
                default:
                    return new FamilyPage();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
