using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KPI.ViewModel
{
    class Menu_Model : ViewModelBase
    {
        private readonly Type _contentType;
        private readonly object _dataContext;

        private object _content;
        public object Content => _content == null ?  CreateContent(): _content;
        private ScrollBarVisibility _horizontalScrollBarVisibilityRequirement;
        private ScrollBarVisibility _verticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto;
        

        public Menu_Model(string name,string icon, Type contentType, object dataContext = null)
        {
            Name = name;
            Icon = icon;
            _contentType = contentType;
            _dataContext = dataContext;
          
        }

        public string Name { get; }

        public string Icon { get; }
      

        public ScrollBarVisibility HorizontalScrollBarVisibilityRequirement
        {
            get => _horizontalScrollBarVisibilityRequirement;
            set => SetProperty(ref _horizontalScrollBarVisibilityRequirement, value);
        }

        public ScrollBarVisibility VerticalScrollBarVisibilityRequirement
        {
            get => _verticalScrollBarVisibilityRequirement;
            set => SetProperty(ref _verticalScrollBarVisibilityRequirement, value);
        }

      
        private object CreateContent()
        {
            var content = Activator.CreateInstance(_contentType);
            if (_dataContext != null && content is FrameworkElement element)
            {
                element.DataContext = _dataContext;
            }

            return content;
        }
    }
}

