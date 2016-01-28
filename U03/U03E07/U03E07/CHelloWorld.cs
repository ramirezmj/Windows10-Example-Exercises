using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace U03E07
{
    public class CHelloWorld : ICommand
    {
        public CHelloWorld() { }
        public bool CanExecute(object parameter)
        {
            bool actualValue = false;
            if (parameter == null)
                return false;
            if (parameter.ToString().Equals("hello"))
            {
                actualValue = true;
            }   
            return actualValue;
        }

        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            ShowDialog("Hello word!", "Example");
        }

        public async void ShowDialog(string content, string title)
        {
            MessageDialog messageDialog = new MessageDialog(content, title);
            await messageDialog.ShowAsync();
        }
    }
}
