using Math;

namespace MathTesting
{
    public class ArithmeticTesting
    {
        [Fact]
        public void Add()
        {
            // arrange
            int first = 3; 
            int second = 2;
            //int expectedResult = first + second;
            int expectedResult = 5;
            Arithmetic arithmetic = new Arithmetic();

            // action
            int actualResult = arithmetic.Add(first, second);

            // assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}