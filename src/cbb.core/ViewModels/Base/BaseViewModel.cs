using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// A base view model functionality for all view models.
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region protected methods

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    #endregion

}
