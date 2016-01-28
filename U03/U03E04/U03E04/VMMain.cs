using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U03E04
{
    public class VMMain :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string firstString, secondString, thirdString, fourthString;

        public string FirstString
        {
            get
            {
                return firstString;
            }

            set
            {
                firstString = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FirstString"));
                }
            }
        }

        public string SecondString
        {
            get
            {
                return secondString;
            }

            set
            {
                secondString = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SecondString"));
                }
            }
        }

        public string ThirdString
        {
            get
            {
                return thirdString;
            }

            set
            {
                thirdString = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ThirdString"));
                }
            }
        }

        public string FourthString
        {
            get
            {
                return fourthString;
            }

            set
            {
                fourthString = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FourthString"));
                }
            }
        }

        public VMMain()
        {
            FirstString = "This is the first string";
            SecondString = "This is the second string";
            ThirdString = "This is the third string";
            FourthString = "This is the fourth string";
        }
    }
}
