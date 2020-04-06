using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace HW2.View
{
    public class OwnerColorConverter : IValueConverter
    {
        readonly private static SolidColorBrush red = new SolidColorBrush(Colors.Red);
        readonly private static SolidColorBrush black = new SolidColorBrush(Colors.Black);
        readonly private static SolidColorBrush white = new SolidColorBrush(Colors.White);
        readonly private static SolidColorBrush[] burshes = new[] { white, red, black };

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return burshes[(int)value];
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
