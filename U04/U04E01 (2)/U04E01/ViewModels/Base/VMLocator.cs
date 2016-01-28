using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U04E01.ViewModels.Base
{
    public class VMLocator
    {
        private Lazy<VMMain> mainViewModel;

        public VMLocator()
        {
            mainViewModel = new Lazy<VMMain>(() => new VMMain());
        }

        public VMMain MainViewModel
        {
            get
            {
                return mainViewModel.Value;
            }
        }
    }
}
