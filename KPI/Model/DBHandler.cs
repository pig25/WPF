using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Model
{
    class DBHandler
    {
      
        public DataTable CreateEmployeeScore()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Table_EmployeeScore";
            dataTable.Columns.Add(DataColumn("NO", "System.Int32", "序", 0));
            dataTable.Columns.Add(DataColumn("Employee", "System.String", "員工", ""));
            dataTable.Columns.Add(DataColumn("Score", "System.Double", "分數", "0"));
            return dataTable;
        }
        public DataTable CreateKpi()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Table_KPI";
            dataTable.Columns.Add(DataColumn("NO", "System.Int32", "序",0));
            dataTable.Columns.Add(DataColumn("ITEM", "System.String", "項目",""));
            return dataTable;
        }
        public DataColumn DataColumn(string Name, String datatype, string Caption)
        {
            DataColumn dataColumn = new DataColumn();
            dataColumn.ColumnName = Name;
            dataColumn.DataType = System.Type.GetType(datatype);
            dataColumn.Caption = Caption;
            return dataColumn;
        }
        public DataColumn DataColumn(string Name, String datatype, string Caption,bool value)
        {
            DataColumn dataColumn = DataColumn(Name, datatype, Caption);
            dataColumn.DefaultValue = value;
            return dataColumn;
        }
        public DataColumn DataColumn(string Name, String datatype, string Caption,string value)
        {
            DataColumn dataColumn = DataColumn(Name, datatype, Caption);
            dataColumn.DefaultValue = value;
            return dataColumn;
        }
        public DataColumn DataColumn(string Name, String datatype, string Caption, int value)
        {
            DataColumn dataColumn = DataColumn(Name, datatype, Caption);
            dataColumn.DefaultValue = value;
            return dataColumn;
        }
        public DataColumn DataColumn(string Name, String datatype, string Caption, Decimal value)
        {
            DataColumn dataColumn = DataColumn(Name, datatype, Caption);
            dataColumn.DefaultValue = value;
            return dataColumn;
        }
        public DataColumn DataColumn(string Name, String datatype, string Caption, double value)
        {
            DataColumn dataColumn = DataColumn(Name, datatype, Caption);
            dataColumn.DefaultValue = value;
            return dataColumn;
        }
    }
}
