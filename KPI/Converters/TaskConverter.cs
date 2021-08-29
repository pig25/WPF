using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace KPI.Converters
{

    public class TaskConverter : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, CultureInfo culture)
        {
            string propertyToAppend = parameter as string;
            var cell = values as DataGridCell;
            Binding b = new Binding();
            if (cell.Column is DataGridCheckBoxColumn)
            {
                DataGridCheckBoxColumn column = cell.Column as DataGridCheckBoxColumn;
                b = column.Binding as Binding;
                Binding b1 = new Binding(b.Path.Path) { Source = cell.DataContext };
                CheckBox dummy = new CheckBox();
                dummy.SetBinding(CheckBox.IsCheckedProperty, b1);
                return dummy.IsChecked;
            }

            
            //var cell = values as DataGridCell;
            //if ( cell != null)
            //{
            //   if(cell.Content is TextBlock)
            //    {
            //        TextBlock textBlock = cell.Content as TextBlock;
            //        return textBlock.Text;
            //    }
            //    //...
            //    //return row[column];
            //    return cell.Content;
            //}
            return null;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
