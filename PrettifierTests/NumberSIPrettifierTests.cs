using Microsoft.Extensions.DependencyInjection;
using PrettifierModule.Interfaces;
using PrettifierModule.Exceptions;
using NUnit.Framework;


namespace PrettifierTests
{
	internal class NumberSIPrettifierTests: TestBase
	{
		private IPrettifier prettifierService;

		[SetUp]
		public void Setup()
		{
			prettifierService = ServiceProvider.GetService<IPrettifier>() 
				?? throw new NullReferenceException("IPrettifier service was null");
		}


		[TestCase(123.0, "123")]
		[TestCase(1234.0, "1234")]
		[TestCase(12345.0, "12345")]
		[TestCase(123456.0, "123456")]
		[TestCase(1234567.0, "1.2M")]
		[TestCase(1000000.0, "1M")]
		[TestCase(12345678.0, "12.3M")]
		[TestCase(123456789.0, "123.5M")]
		[TestCase(1234567890.0, "1.2B")]
		[TestCase(12345678901.0, "12.3B")]
		[TestCase(123456789012.0, "123.5B")]
		[TestCase(1234567890123.0, "1.2T")]
		[TestCase(1234567890123456.0, "1.2P")]
		[TestCase(1234567890123456789.0, "1.2E")]
		[TestCase(1234567890123456789012.0, "1.2Z")]
		[TestCase(1234567890123456789012345.0, "1.2Y")]
		[TestCase(1234567890123456789012345678.0, "1.2R")]
		[TestCase(1234567890123456789012345678901.0, "1.2Q")]
		public void Prettify_Integer_ShouldReturn_Expected(double number, string expected)
		{
			//act
			var actual = prettifierService.Prettify(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}


		[TestCase(-1234.0, "-1234")]
		[TestCase(12345.999, "12345.999")]
		[TestCase(-12345678.0, "-12.3M")]
		[TestCase(-1000000.987, "-1M")]
		[TestCase(-1234567890123456789012.87654, "-1.2Z")]
		public void Prettify_NegativeAndFractional_ShouldReturn_Expected(double number, string expected)
		{
			//act
			var actual = prettifierService.Prettify(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[TestCase(-1234567890123456789012345678901234.87654)]
		[TestCase(1234567890123456789012345678901234.0)]
		public void Prettify_Integer_ShouldThrow_NumberNotSupportedException(double number)
		{
			//act & assert
			Assert.That(() => prettifierService.Prettify(number), Throws.InstanceOf<NumberNotSupportedException>());
		}


		[TestCase("123456", "123456")]
		[TestCase("12345678.0", "12.3M")]
		[TestCase("12345678", "12.3M")]
		[TestCase("12345.999", "12345.999")]
		[TestCase("-12345678.0", "-12.3M")]
		public void Prettify_String_ShouldReturn_Expected(string number, string expected)
		{
			//act
			var actual = prettifierService.Prettify(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}


		[Test]
		public void Prettify_String_ShouldThrow_ArgumentException()
		{
			//arrange
			string input = "2345678q";

			//act & assert
			Assert.That(() => prettifierService.Prettify(input), Throws.ArgumentException);
		}


		[TestCase(123.0, "123", 1)]
		[TestCase(123456, "123456", 10)]
		[TestCase(1234567.0, "1.235M", 3)]
		[TestCase(1000000.0, "1M",3)]
		[TestCase(12345678.0, "12M",0)]
		[TestCase(123456789.0, "123.4568M",4)]
		[TestCase(1234567890.0, "1.23456789B", 10)]
		public void Prettify_Accuracy_ShouldReturn_Expected(double number, string expected, int accuracy)
		{
			//act
			var actual = prettifierService.Prettify(number, accuracy);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}