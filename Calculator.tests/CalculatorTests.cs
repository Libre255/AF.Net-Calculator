using Xunit;

namespace CalcutatorProject.tests
{
    public class CalculatorTest:Calculator
    {

        [Fact]
        public void TestSum()
        {
            double SumResult = Sum(new double[] { 1, 2 });
            Assert.Equal(3, SumResult);
        }

        [Fact]
        public void TestSubstraction()
        {
            double SubResult = Minus(new double[] { 1, 2 });
            Assert.Equal(-1, SubResult);
        }

        [Fact]
        public void TestMultiplication()
        {
            double MultiResult = Multiplication(new double[] { 1, 2 });
            Assert.Equal(2, MultiResult);
        }
        [Fact]
        public void TestDivision()
        {
            double DivResult = Division(new double[] { 0, 23432 });
            Assert.Equal(0, DivResult);
        }
    }
}