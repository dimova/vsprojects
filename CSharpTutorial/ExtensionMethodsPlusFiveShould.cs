using System;
using Xunit;
namespace CSharpTutorial
{
	class ExtensionMethodsPlusFiveShould
	{
		[Fact]
		public void ReturnFiveMoreThanInput()
		{
			//Arrange
			int input = 10;
			int expectedResult = 0;

			//Act
			int actualResult = input.PlusFive();

			//Assert
			Assert.Equal(expectedResult, actualResult);
		}
	}
}
