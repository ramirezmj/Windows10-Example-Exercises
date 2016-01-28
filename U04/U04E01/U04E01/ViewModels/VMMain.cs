using System;
using System.Windows.Input;
using U04E01.ViewModels.Base;

namespace U04E01.ViewModels
{
    public class VMMain : VMBase
    {
        #region Properties

        #endregion

        public VMMain()
        {
            InitializeCommands();
        }

        #region Commands

        private Lazy<DelegateCommand<string>> accept;
        private Lazy<DelegateCommand<string>> cancel;

        public ICommand Accept
        {
            get
            {
                return accept.Value;
            }
        }

        public ICommand Cancel
        {
            get
            {
                return cancel.Value;
            }
        }

        private void InitializeCommands()
        {
            accept = new Lazy<DelegateCommand<string>>(
                () => new DelegateCommand<string>(AcceptCommandExecute,
                                                  AcceptCommandCanExecute));

            cancel = new Lazy<DelegateCommand<string>>(
                () => new DelegateCommand<string>(CancelCommandExecute,
                                                  CancelCommandCanExecute));

        }

        public void AcceptCommandExecute(string param)
        {

        }

        public bool AcceptCommandCanExecute(object param)
        {
            return true;
        }

        public void CancelCommandExecute(string param)
        {

        }

        public bool CancelCommandCanExecute(object param)
        {
            return true;
        }

        #endregion
    }
}
