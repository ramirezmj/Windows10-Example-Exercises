using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U03E08
{
    public class VMMain : INotifyPropertyChanged
    {
        private CSuma command;

        public event PropertyChangedEventHandler PropertyChanged;
        private int operando1;
        private int operando2;

        public CSuma Command
        {
            get
            {
                return command;
            }

            set
            {
                command = value;
            }
        }

        public int Operando1
        {
            get
            {
                return operando1;
            }

            set
            {
                operando1 = value;
            }
        }

        public int Operando2
        {
            get
            {
                return operando2;
            }

            set
            {
                operando2 = value;
            }
        }

        private int resultado;
        public int Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Resultado"));
                }
            }
        }

        public VMMain()
        {
            command = new CSuma();
            command.runSuma = hacer_suma;
            command.runResta = hacer_resta;
            command.runMultiplicacion = hacer_multiplicacion;
            command.runDivision = hacer_division;
        }

        private void hacer_division()
        {
            Resultado = operando1 / operando2;
        }

        private void hacer_multiplicacion()
        {
            Resultado = operando1 * operando2;
        }

        private void hacer_resta()
        {
            Resultado = operando1 - operando2;
        }

        private void hacer_suma()
        {
            Resultado = operando1 + operando2;
        }
    }
}
