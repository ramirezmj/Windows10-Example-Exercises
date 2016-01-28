using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace U03E08
{
    public class CSuma : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public delegate void runCommand();

        public runCommand runSuma;
        public runCommand runResta;
        public runCommand runMultiplicacion;
        public runCommand runDivision;

        public bool CanExecute(object parameter)
        {
            bool actualValue = false;
            if (parameter == null)
            {
                return false;
            }
            else
            {
                actualValue = true;
            }
            return actualValue;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString().Equals("+"))
            {
                runSuma();
            } else if (parameter.ToString().Equals("-"))
            {
                runResta();
            } else if (parameter.ToString().Equals("*"))
            {
                runMultiplicacion();
            } else if (parameter.ToString().Equals("/"))
            {
                runDivision();
            } 
        }
    }
}
