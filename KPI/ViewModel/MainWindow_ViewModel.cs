using KPI.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.ViewModel
{
    class MainWindow_ViewModel : ViewModelBase
    {  
        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set => SetProperty(ref _selectedIndex, value);
        }
        private Menu_Model _selectedItem;
        public Menu_Model SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        public ObservableCollection<Menu_Model> menus_list { get; }
        public MainWindow_ViewModel()
        {
            menus_list = new ObservableCollection<Menu_Model>(new[]
           {
                new Menu_Model(
                    "首頁",
                    "Home",
                    typeof(Home_VIew)
                   
                )
            });

            foreach (var item in GenerateDemoItems().OrderBy(i => i.Name))
            {
                menus_list.Add(item);
            }
        }
      
        private static IEnumerable<Menu_Model> GenerateDemoItems()
        {
           
            yield return new Menu_Model(
                "報表",
                "ChartAreaspline",
                typeof(KPI_Report_View)
               );
            yield return new Menu_Model(
                "評分",
                "ClipboardEditOutline",
                typeof(KPI_View)
               );

        }
    }
}
