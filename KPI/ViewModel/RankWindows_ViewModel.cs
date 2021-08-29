using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.ViewModel
{
    public class RankWindows_ViewModel : ViewModelBase
    {
       
        private DataTable _dataTable;
        public DataTable dataTable
        {
            get => _dataTable;
            set => SetProperty(ref _dataTable, value);
        }

        private DataTable _griddataTable;
        public DataTable griddataTable
        {
            get => _griddataTable;
            set => SetProperty(ref _griddataTable, value);
        }

        public RankWindows_ViewModel()
        {
            
            dataTable = new DataTable();
            _griddataTable = dataTable.Clone();
        }
    }
}
