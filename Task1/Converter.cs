using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;


namespace Task1
{
    internal class Converter VelueConverter
        public object Convert(object velue, Type targetType, object parameter, CultureInfo culture)
        {
        if ((ProductCategorys)value == ProductCategories.Food)
         {
            return "Еда";
         }
        return "Бытовая техника";
        }
        public object ConvertBack(object velue, Type targetType, object parameter, CultureInfo culture)
     {
        return DependencyProperty.UnsetValue;
     }
    }

