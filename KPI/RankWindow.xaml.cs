using KPI.Model;
using KPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KPI
{
    /// <summary>
    /// RankWindow.xaml 的互動邏輯
    /// </summary>
    public partial class RankWindow : Window
    {
        private RankWindows_ViewModel rankWindows_ViewModel;
        public RankWindow()
        {
            InitializeComponent();
            rankWindows_ViewModel = new RankWindows_ViewModel();
            DataContext = rankWindows_ViewModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DBHandler dBHandler = new DBHandler();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KPIConnectionString))
            {

                using (SqlCommand command = new SqlCommand("腳色樣板PROCEDURE", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        SqlDataReader dr = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        // process or return dt or dr
                        rankWindows_ViewModel.dataTable = dt;
                        DataTable dataTable = new DataTable();
                        foreach (DataColumn dataColumn in dt.Columns)
                        {
                            switch (dataColumn.DataType.Name.ToLower())
                            {
                                case "int32":
                                    dataTable.Columns.Add(dBHandler.DataColumn(dataColumn.ColumnName, "System.Boolean", dataColumn.Caption, false));
                                    break;
                                default:
                                    dataTable.Columns.Add(dBHandler.DataColumn(dataColumn.ColumnName, "System.String", dataColumn.Caption, ""));
                                    break;
                            }

                        }
                        foreach (DataRow dataRow in dt.Rows)
                        {
                            DataRow datatablerow = dataTable.NewRow();
                            foreach (DataColumn dataColumn in dt.Columns)
                            {
                                switch (dataColumn.DataType.Name.ToLower())
                                {
                                    case "string":
                                        datatablerow[dataColumn.ColumnName] = dataRow.Field<string>(dataColumn.ColumnName);
                                        break;
                                    
                                }

                            }
                            dataTable.Rows.Add(datatablerow);
                        }
                        rankWindows_ViewModel.griddataTable = dataTable;
                    }
                    catch
                    {

                    }


                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine();
        }
    }
}
