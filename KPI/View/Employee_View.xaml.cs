using KPI.ViewModel;
using MaterialDesignThemes.Wpf;
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
    /// Employee_View.xaml 的互動邏輯
    /// </summary>
    public partial class Employee_View : UserControl
    {
        private Employee_ViewModel employee_ViewModel;
       
        public Employee_View()
        {
            InitializeComponent();
            employee_ViewModel = new Employee_ViewModel();
            DataContext = employee_ViewModel;
            
        }

        private void Btn_postion_add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox_postionid.Text))
            {
                employee_ViewModel.position_Models.Add(new Position_Model
                {
                    PositionID = textbox_postionid.Text,
                    PositionNAME = textbox_postionname.Text
                });
            }
              
            DialogHost.CloseDialogCommand.Execute(null, null);
        }

        

        private void Datagrid_position_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            
        }
    }
}
