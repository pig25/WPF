using KPI.Linq;
using KPI.Model;
using KPI.ViewModel;
using MaterialDesignThemes.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KPI.View
{
    /// <summary>
    /// Authority_View.xaml 的互動邏輯
    /// </summary>
    public partial class Authority_View : UserControl
    {
        private Authority_ViewModel rankWindows_ViewModel;
        public Authority_View()
        {
            InitializeComponent();
            rankWindows_ViewModel = new Authority_ViewModel();
            DataContext = rankWindows_ViewModel;
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateCombobox();
        }
        private void UpdateCombobox()
        {
            rankWindows_ViewModel.腳色.Clear();
  KPIDataContext kPIDataContext = new KPIDataContext();
            foreach (var item in kPIDataContext.腳色)
            {
                rankWindows_ViewModel.腳色.Add(item);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine();
        }

        private void OutlinedComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (rankWindows_ViewModel.選擇腳色 != null)
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
                            KPIDataContext kPIDataContext = new KPIDataContext();
                            foreach (var item in kPIDataContext.腳色明細.Where(x => x.代號 == rankWindows_ViewModel.選擇腳色.代號))
                            {
                                foreach (DataRow dataRow in dataTable.Rows)
                                {
                                    if(item.畫面 == dataRow.Field<string>("畫面"))
                                    {
                                        dataRow[item.功能] = item.啟用;
                                        break;
                                    }
                                }
                            }
                        }
                        catch
                        {

                        }


                    }
                }
            }
        }

        private void Btn_update_Click(object sender, RoutedEventArgs e)
        {
            int ans = 0;
            if (rankWindows_ViewModel.選擇腳色 == null)
            {
                return;
            }
            string sql = @"
UPDATE [dbo].[腳色明細]
SET 啟用 = @啟用
 WHERE 代號 = @代號 and 畫面 = @畫面 and 功能 = @功能
IF @@ROWCOUNT = 0
INSERT INTO [dbo].[腳色明細]
           ([代號],[畫面],[功能] ,[啟用])
     VALUES (@代號,@畫面 ,@功能,@啟用)";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KPIConnectionString))
            {
                connection.Open();
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                try
                {

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Transaction = sqlTransaction;


                        foreach (DataRow dataRow in rankWindows_ViewModel.griddataTable.Rows)
                        {

                            foreach (DataColumn dataColumn in rankWindows_ViewModel.griddataTable.Columns)
                            {
                                if (dataColumn.ColumnName != "代號" && dataColumn.ColumnName != "畫面")
                                {
                                    foreach (DataRow row in rankWindows_ViewModel.dataTable.Rows)
                                    {
                                        if (row.Field<string>("畫面") == dataRow.Field<string>("畫面"))
                                        {
                                            if (row.Field<int>(dataColumn.ColumnName)>0)
                                            {
                                                command.Parameters.Clear();

                                                command.Parameters.AddWithValue("@代號", rankWindows_ViewModel.選擇腳色.代號);
                                                command.Parameters.AddWithValue("@畫面", dataRow.Field<string>("畫面"));
                                                command.Parameters.AddWithValue("@功能", dataColumn.ColumnName);
                                                command.Parameters.AddWithValue("@啟用", dataRow.Field<bool>(dataColumn.ColumnName));
                                                ans = command.ExecuteNonQuery();
                                                if (ans < 1)
                                                {
                                                    sqlTransaction.Rollback();
                                                    return;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                    }

                                }

                            }


                        }

                    }
                    sqlTransaction.Commit();
                  
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    return;
                }
            }
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            int ans = 0;
            if (string.IsNullOrWhiteSpace(btn_no.Text) || string.IsNullOrWhiteSpace(btn_name.Text))
            {
                return;
            }
            string sql = @"
INSERT INTO [dbo].[腳色]
           ([代號],[名稱])
     VALUES
           (@代號,@名稱)
";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KPIConnectionString))
            {
                connection.Open();
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                try
                {

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Transaction = sqlTransaction;

                        command.Parameters.AddWithValue("代號", btn_no.Text);
                        command.Parameters.AddWithValue("名稱", btn_name.Text);
                        ans = command.ExecuteNonQuery();
                        if(ans < 1)
                        {
                            sqlTransaction.Rollback();
                            return;
                        }
                    }
                    sqlTransaction.Commit();
                    UpdateCombobox();
                  
                    DialogHost.CloseDialogCommand.Execute(null, null);
                    腳色 data = new 腳色();
                    data.代號 = btn_no.Text;
                    data.名稱 = btn_name.Text;
                    rankWindows_ViewModel.選擇腳色 = data;
                    OutlinedComboBox_SelectionChanged(null, null);
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    return;
                }
            }
        }
    }
}

