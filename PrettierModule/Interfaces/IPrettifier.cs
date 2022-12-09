using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettifierModule.Interfaces
{
	public interface IPrettifier
	{
		/// <summary>
		/// Will prettify number. The prettified version should include one number after the decimal when the truncated number is not an integer. 
		/// It will prettify numbers greater than 6 digits.
		/// </summary>
		/// <param name="number">Big number for prettified.</param>
		/// <param name="accuracy">Accuracy of fractional part of prettified number. Default: 1.</param>
		/// <returns>Prettified number. E.g. 3.5B, 1M etc.</returns>
		string Prettify(string number, int accuracy = 1);
		/// <summary>
		/// Will prettify number. The prettified version should include one number after the decimal when the truncated number is not an integer. 
		/// It will prettify numbers greater than 6 digits.
		/// </summary>
		/// <param name="number">Big number for prettified.</param>
		/// <param name="accuracy">Accuracy of fractional part of prettified number. Default: 1.</param>
		/// <returns>Prettified number. E.g. 3.5B, 1M etc.</returns>
		string Prettify(double number, int accuracy = 1);
	}
}
