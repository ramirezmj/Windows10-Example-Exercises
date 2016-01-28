using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// INotifyPropertyChanged
using System.ComponentModel;

namespace U04E01.ViewModels.Base
{
    public class VMBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public VMBase() { }

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                       new PropertyChangedEventArgs(propertyName));
        }

        protected void UpdateAll()
        {
            RaisePropertyChanged(String.Empty);
        }
    }
}
