namespace PrettifierModule.Exceptions
{
	public class NumberNotSupportedException : Exception
	{
		public NumberNotSupportedException(string? number) 
			: base($"{number} is too large and not supported yet")
		{

		}
		public NumberNotSupportedException() : base()
		{
		}
	}
}
