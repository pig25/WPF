using KPI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.ViewModel
{
    class KPI_ViewModel: ViewModelBase
    {
        private DateTime _Date;
        public DateTime Date
        {
            get => _Date;
            set => SetProperty(ref _Date, value);
        }
        private DataTable _dataTable;
        public DataTable dataTable
        {
            get => _dataTable;
            set => SetProperty(ref _dataTable, value);
        }

        public KPI_ViewModel()
        {
            DBHandler dBHandler = new DBHandler();
            Date = DateTime.Now;
            dataTable = dBHandler.CreateKpi();
            for (int i = 1; i < 11; i++)
            {
                dataTable.Columns.Add(dBHandler.DataColumn($"Employee_{i}", "System.Boolean", $"員工{i}", false));
            }
            for (int i = 1; i <= 10; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["NO"] = i;
                dataRow["ITEM"] = $"項目{i}".PadLeft(20, '*').PadRight(200, '+');
                dataTable.Rows.Add(dataRow);
            }
        }
    }
}
