using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace U03E05
{
    class BooleanGenderToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool actualValue = false;
            bool.TryParse(value.ToString(), out actualValue);

            if (actualValue)
            {
                return "Hombre";
            } else
            {
                return "Mujer";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
