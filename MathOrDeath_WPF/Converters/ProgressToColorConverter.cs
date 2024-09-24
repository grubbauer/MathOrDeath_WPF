using System;
using System.Globalization;
using System.Windows.Data;

namespace MathOrDeath_WPF.Converters
{
    public class ProgressToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double doubleValue)
            {
                doubleValue = Math.Max(0, Math.Min(doubleValue, 100));
                byte g = ((byte)(doubleValue < 50 ? 255 : 255 - ((doubleValue - 50) * 5.1)));
                byte r = (byte)(doubleValue >= 50 ? 255 : (doubleValue * 5.1));
                return $"#{r:X2}{g:X2}00";
            }
            return "#000000";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
