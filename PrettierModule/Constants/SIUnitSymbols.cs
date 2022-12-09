using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettifierModule.Constants
{
	internal static class SIUnitSymbols
	{
		static public Dictionary<int, char> Values
		{
			get
			{
				return new Dictionary<int, char>
					{
						{ 2, 'M' },
						{ 3, 'B' },
						{ 4, 'T' },
						{ 5, 'P' },
						{ 6, 'E' },
						{ 7, 'Z' },
						{ 8, 'Y' },
						{ 9, 'O' },
						{ 10, 'N' }
					};
			}
		}
	}
}
