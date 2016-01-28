using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U04E03.Services
{
	public interface INavigationService
	{
		void NavigateToSecondPage(string message);
		void GoBack();
	}
}
