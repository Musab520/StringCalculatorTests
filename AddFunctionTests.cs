using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculator;
using Xunit;

namespace StringCalculatorTests
{
    public class AddFunctionTests
    {
        private IStringCalculator _stringCalculator;

        public AddFunctionTests()
        {
            _stringCalculator = new StringCalculatorKata();
        }
        [Fact]
        public void TestEmptyString()
        {
            string numbers = "";
            int actual = 0;
            int sum=_stringCalculator.add(numbers);
            Assert.Equal(actual, sum);
        }
        [Fact]
        public void TestOneNumber()
        {
            string numbers = "1";
            int actual = 1;
            int sum = _stringCalculator.add(numbers);
            Assert.Equal(actual, sum);
        }
        [Fact]
        public void TestTwoNumbers()
        {
            string numbers = "1,2";
            int actual = 3;
            int sum = _stringCalculator.add(numbers);
            Assert.Equal(actual, sum);
        }
        [Fact]
        public void TestUnknownAmount()
        {
            string numbers = "123,456,789,4,1,7,2,0,3";
            int actual = 1385;
            int sum = _stringCalculator.add(numbers);
            Assert.Equal(actual, sum);
        }
         [Fact]
        public void TestNewLines()
        {
            string numbers = "123\n456,789,4\n,1,7,2,0,3,\n";
            int actual = 1385;
            int sum = _stringCalculator.add(numbers);
            Assert.Equal(actual, sum);
        }
        [Fact]
        public void TestDifferentDelimeters()
        {
            string numbers = "//;\n1;2;3";
            int actual=6;
            int sum = _stringCalculator.add(numbers);
            Assert.Equal(actual, sum);
        }
    }
}
