using KPI.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.ViewModel
{
    public class Authority_ViewModel : ViewModelBase
    {
        private ObservableCollection<腳色> _腳色;
        public ObservableCollection<腳色> 腳色
        {
            get => _腳色;
            set => SetProperty(ref _腳色, value);
        }
        private 腳色 _選擇腳色;
        public 腳色 選擇腳色
        {
            get => _選擇腳色;
            set => SetProperty(ref _選擇腳色, value);
        }
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

        public Authority_ViewModel()
        {

            dataTable = new DataTable();
            _griddataTable = dataTable.Clone();
            腳色 = new ObservableCollection<腳色>();
        }
    }
}
