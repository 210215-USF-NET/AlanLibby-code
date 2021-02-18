using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2,1,3)]
        [InlineData(1,-1,0)]
        [InlineData(-1,-1,-2)]
        [InlineData(0,0,0)]
        public void TestAdd(int a0, int a1, int expected)
        {
            int result = Calculator.Add(a0, a1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2,1,1)]
        [InlineData(1,2,-1)]
        [InlineData(1,-1,2)]
        [InlineData(-1,-2,1)]
        [InlineData(0,0,0)]
        public void TestSubtract(int a0, int a1, int expected)
        {
            int result = Calculator.Subtract(a0, a1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2,1,2)]
        [InlineData(1,2,2)]
        [InlineData(1,-1,-1)]
        [InlineData(-1,-2,2)]
        [InlineData(1,0,0)]
        [InlineData(0,0,0)]
        public void TestMultiply(int a0, int a1, int expected)
        {
            int result = Calculator.Multiply(a0, a1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2,1,2)]
        [InlineData(1,2,0)]
        [InlineData(1,-1,-1)]
        [InlineData(-2,-1,2)]
        [InlineData(0,1,0)]
        public void TestDivide(int a0, int a1, int expected)
        {
            int result = Calculator.Divide(a0, a1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(-1)]
        [InlineData(0)]
        public void TestDivideByZero(int a0)
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a0, 0));
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(4,3)]
        public void TestFib(int a0, int expected)
        {
            int result = Calculator.Fib(a0);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0,false)]
        [InlineData(1,false)]
        [InlineData(2,true)]
        [InlineData(3,true)]
        [InlineData(4,false)]
        [InlineData(7917,false)] // 87 * 91
        [InlineData(991, true)]
        public void TestPrime(int a0, bool expected)
        {
            bool result = Calculator.Prime(a0);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(")3+5(",false)]
        [InlineData("3+4+(5",false)]
        [InlineData("(3+4)+5",true)]
        [InlineData("((3+4)+5)", true)]
        public void TestBalanced(string equation, bool expected)
        {
            bool result = Calculator.Balanced(equation);
            Assert.Equal(expected, result);
        }
    }
}
