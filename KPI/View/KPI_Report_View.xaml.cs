using KPI.Model;
using KPI.ViewModel;
using LiveCharts;
using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// KPI_Report_View.xaml 的互動邏輯
    /// </summary>
    public partial class KPI_Report_View : UserControl
    {
        private DBHandler dbhandler;
        private KPI_Report_ViewModel KPI_Report_ViewModel;
        public KPI_Report_View()
        {
            InitializeComponent();
            KPI_Report_ViewModel = new KPI_Report_ViewModel();
            DataContext = KPI_Report_ViewModel;

            KPI_Report_ViewModel.SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 },
                    ScalesXAt=0,
                    ScalesYAt=0,
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                    PointGeometry = null,
                    ScalesXAt=0,
                    ScalesYAt=0,
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 4,2,7,2,7 },
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15,
                    ScalesXAt=0,
                    ScalesYAt=0,

                }
            };

            KPI_Report_ViewModel.Labels =new List<string> { "Jan", "Feb", "Mar", "Apr", "May" };
            KPI_Report_ViewModel.YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart
            KPI_Report_ViewModel.SeriesCollection.Add(new LineSeries
            {
                Title = "Series 4",
                Values = new ChartValues<double> { 5, 3, 2, 4 },
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray,
                ScalesXAt = 0,
                ScalesYAt = 0,
            });

            //modifying any series values will also animate and update the chart
            KPI_Report_ViewModel.SeriesCollection[3].Values.Add(5d);

            KPI_Report_ViewModel.ColumnLabels = new List<string> { "項目一", "項目二", "項目三", "項目四", "項目五", "項目六", "項目七", "項目八", "項目九", "項目十" };
            KPI_Report_ViewModel.ColumnFormatter = value => value.ToString();

            KPI_Report_ViewModel.SeriesCollection.Add(new ColumnSeries
            {
                Title = "扣分",
                Values = new ChartValues<int> { 1, 3, 5,7,0,1,6,10,2,1 },
                PointGeometry = DefaultGeometries.Diamond,
                ScalesYAt =1,
                ScalesXAt=1
               
            });

        }

        private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = KPI_Report_ViewModel.dataTable.Columns[e.PropertyName].Caption;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            KPI_Report_ViewModel.SelectDataRowView = datagrid_Score.SelectedItem as DataRowView;
            if (KPI_Report_ViewModel.SelectDataRowView == null)
            {
                KPI_Report_ViewModel.SelectEmployee = "";
                return;
            }
            KPI_Report_ViewModel.SelectEmployee = KPI_Report_ViewModel.SelectDataRowView.Row["Employee"] as string;
        }
    }
}
