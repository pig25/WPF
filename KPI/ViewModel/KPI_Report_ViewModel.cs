using KPI.Model;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.ViewModel
{
    public class KPI_Report_ViewModel : ViewModelBase
    {
     
        private SeriesCollection _SeriesCollection;
        public SeriesCollection SeriesCollection
        {
            get => _SeriesCollection;
            set => SetProperty(ref _SeriesCollection, value);
        }
        private List<string> _Labels;
        public List<string> Labels
        {
            get => _Labels;
            set => SetProperty(ref _Labels, value);
        }
       

        private Func<double, string> _YFormatter;
        public Func<double, string> YFormatter
        {
            get => _YFormatter;
            set => SetProperty(ref _YFormatter, value);
        }
       private List<string> _ColumnLabels;
        public List<string> ColumnLabels
        {
            get => _ColumnLabels;
            set => SetProperty(ref _ColumnLabels, value);
        }
        private Func<int, string> _ColumnFormatter;
        public Func<int, string> ColumnFormatter
        {
            get => _ColumnFormatter;
            set => SetProperty(ref _ColumnFormatter, value);
        }
        private DataTable _dataTable;
        public DataTable dataTable
        {
            get => _dataTable;
            set => SetProperty(ref _dataTable, value);
        }

        private String _SelectEmployee;
        public String SelectEmployee
        {
            get => _SelectEmployee;
            set => SetProperty(ref _SelectEmployee, value);
        }

        private DataRowView _SelectDataRowView;
        public DataRowView SelectDataRowView
        {
            get => _SelectDataRowView;
            set => SetProperty(ref _SelectDataRowView, value);
        }

        public KPI_Report_ViewModel()
        {
            DBHandler dBHandler = new DBHandler();
            SelectDataRowView = null;
               dataTable = dBHandler.CreateEmployeeScore();
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["NO"] = i;
                dataRow["Employee"] = $"員工{i}";
                dataRow["Score"] = rnd.Next(0, 120);
                dataTable.Rows.Add(dataRow);
            }
        }
    }
}
