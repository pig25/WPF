using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace KPI.Converters
{
    public class DatagridcellConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DataGridCell cell = values[0] as DataGridCell;
            if (cell.Column is DataGridCheckBoxColumn)
            {
                DataRowView dataRowView = cell.DataContext as DataRowView;
                DataTable dataTable = values[1] as DataTable;
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if (dataRow[0].ToString() == dataRowView.Row[0].ToString())
                    {
                        return dataRow.Field<Int32>(cell.Column.Header.ToString()) > 0;
                    }
                }
            }

            //Binding b = new Binding();
            //if (cell.Column is DataGridCheckBoxColumn)
            //{
            //    DataGridCheckBoxColumn column = cell.Column as DataGridCheckBoxColumn;
            //    b = column.Binding as Binding;
            //    Binding b1 = new Binding(b.Path.Path) { Source = cell.DataContext };
            //    CheckBox dummy = new CheckBox();
            //    dummy.SetBinding(CheckBox.IsCheckedProperty, b1);
            //    return dummy.IsChecked;
            //}

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {

            return null;
        }
    }
}
