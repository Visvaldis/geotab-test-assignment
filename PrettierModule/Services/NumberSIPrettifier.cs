using PrettifierModule.Constants;
using PrettifierModule.Exceptions;
using PrettifierModule.Interfaces;


namespace PrettifierModule.Services
{
	internal class NumberSIPrettifier : IPrettifier
	{
		public string Prettify(string number, int accuracy)
		{
			var isNumber = double.TryParse(number, out double convertedNumber);
			if (isNumber == false)
				throw new ArgumentException($"{number} is not a number");
			return Prettify(convertedNumber, accuracy);
		}

		public string Prettify(double number, int accuracy)
		{
			int rank = (int)Math.Log10(Math.Abs(number));
			if (rank < 6)
				return number.ToString();
			if (!SIUnitPrefixes.Values.ContainsKey(rank / 3))
				throw new NumberNotSupportedException(number.ToString());

			int rankAfterTruncation = rank - rank % 3;
			var truncatedNumber = number / Math.Pow(10, rankAfterTruncation);
			var roundedTruncatedNumber = Math.Round(truncatedNumber, accuracy);
			return $"{roundedTruncatedNumber}{SIUnitPrefixes.Values[rank / 3]}";

		}

	}
}
