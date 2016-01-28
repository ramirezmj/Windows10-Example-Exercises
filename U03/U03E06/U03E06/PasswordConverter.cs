using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace U03E06
{
    class PasswordConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string actualValue = "Enter the password to reveal the message";
            if (value.ToString().Equals("admin"))
            {
                actualValue = "This is a secret message";
            }
            return actualValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value.ToString();
        }
    }
}
