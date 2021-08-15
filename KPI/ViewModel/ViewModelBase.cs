using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KPI.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 如果傳進來的參數不相等就呼叫OnPropertyChanged
        /// </summary>
        /// <typeparam name="T">物件樣板</typeparam>
        /// <param name="member">舊屬性值</param>
        /// <param name="value">新的值</param>
        /// <param name="propertyName">屬性名稱</param>
        protected virtual bool SetProperty<T>(ref T member, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(member, value))
            {
                return false;
            }

            member = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// 通知監聽器該屬性質已經改變
        /// </summary>
        /// <param name="propertyName">屬性名稱</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
