using PrettifierModule.Interfaces;

namespace PrettifierModule.Services
{
	public class NumberSIPrettifier : IPrettifier
	{
		public string Prettify(string number, int accuracy)
		{
			var result = double.TryParse(number, out double convertedNumber);
			return Prettify(convertedNumber);
		}

		public string Prettify(double number, int accuracy = 0)
		{
			return number.ToString();
		}
		
	}
}
