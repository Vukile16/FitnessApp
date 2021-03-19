using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FitnessApp.Converters
{
    public class SelectedIndexColorConverter : IValueConverter
    {
        Color selectedColor;
        Color unSelectedColor;
        public SelectedIndexColorConverter()
        {
            selectedColor = (Color)Application.Current.Resources["Accent"];
            unSelectedColor = (Color)Application.Current.Resources["TextSecondary"];
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int.TryParse(parameter as string, out int index);
            return (int)value == index ? selectedColor : unSelectedColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
