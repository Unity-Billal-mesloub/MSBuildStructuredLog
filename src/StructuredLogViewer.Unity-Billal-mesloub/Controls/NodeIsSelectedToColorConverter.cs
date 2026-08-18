using System;
using System.Globalization;
using Unity-Billal-mesloub.Data.Converters;
using Unity-Billal-mesloub.Media;

namespace StructuredLogViewer.Unity-Billal-mesloub.Controls
{
    public class NodeIsSelectedToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isSelected)
                return isSelected ? Brushes.Black : parameter;

            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
            => throw new NotSupportedException();
    }
}
