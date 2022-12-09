using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettifierModule.Interfaces
{
	public interface IPrettifier
	{
		string Prettify(string number, int accuracy = 1);
		string Prettify(double number, int accuracy = 1);
	}
}
