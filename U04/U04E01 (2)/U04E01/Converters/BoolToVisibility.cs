using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace U04E01.Converters
{
    public class BoolToVisibility : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, string language)
        {
            if (((bool)value) == true)
            {
                return "Visible";
            }
            else
            {
                return "Collapsed";
            }
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
