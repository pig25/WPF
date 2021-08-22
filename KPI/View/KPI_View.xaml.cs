using KPI.Model;
using KPI.ViewModel;
using System;
using System.Collections.Generic;
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
    /// KPI_View.xaml 的互動邏輯
    /// </summary>
    public partial class KPI_View : UserControl
    {
      
        private DBHandler dbhandler;
        private KPI_ViewModel kPI_ViewModel;
        public KPI_View()
        {
            InitializeComponent();
            kPI_ViewModel = new KPI_ViewModel();
            DataContext = kPI_ViewModel;
            dbhandler = new DBHandler();
            AddColumns();
        }

        public void AddColumns()
        {
            for (int i = 1; i < 11; i++)
            {
                gridkpi.Columns.Add(new DataGridCheckBoxColumn
                {
                    // bind to a dictionary property
                    Binding = new Binding($"Employee_{i}"),
                    Header = $"員工{i}",


                });

            }
        }

        private void chkSelect_Checked(object sender, RoutedEventArgs e)
        {
            //    throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine();
        }
    }
}
