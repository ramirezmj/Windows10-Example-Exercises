using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace U03E07
{
    public class VMMain
    {
        private CHelloWorld sayHelloCommand;

        public ICommand SayHelloCommand
        {
            get
            {
                return sayHelloCommand;
            }
        }


        public VMMain()
        {
            sayHelloCommand = new CHelloWorld();
        }
    }

}
