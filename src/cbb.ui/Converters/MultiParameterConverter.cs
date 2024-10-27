using System;
using System.Globalization;
using System.Windows.Data;
namespace cbb.ui
{
    public class MultiParameterConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // Here, we combine the values into a Tuple
            return Tuple.Create(values[0], values[1]); // Combine values as needed
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("ConvertBack is not implemented.");
        }
    }
}
