using KPI.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.ViewModel
{
    public class Employee_ViewModel : ViewModelBase
    {
        private ObservableCollection<Position_Model> _position_Models;
        public ObservableCollection<Position_Model> position_Models
        {
            get => _position_Models;
            set => SetProperty(ref _position_Models, value);
        }
        public Employee_ViewModel()
        {
            position_Models = createPosition();
        }
        private ObservableCollection<Position_Model> createPosition()
        {
            ObservableCollection<Position_Model> data = new ObservableCollection<Position_Model>();
            for (int i = 1; i < 6; i++)
            {
                data.Add(new Position_Model
                {
                    PositionID = $"POS{i.ToString().PadLeft(3,'0')}",
                    PositionNAME = $"職位{i}"
                }); 
            }
            return data;
        }


    }
}

