namespace PrettifierModule.Constants
{
	internal static class SIUnitPrefixes
	{
		//https://en.wikipedia.org/wiki/Metric_prefix#List_of_SI_prefixes
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
						{ 9, 'R' },
						{ 10, 'Q' }
					};
			}
		}
	}
}
