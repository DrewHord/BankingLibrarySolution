using AccountFormatLibrary;
using System;
using Xunit;

namespace TestInterestCalculation {
    public class UnitTest1 {
        [Theory]
        [InlineData(36, 36, 0.12, 100)]
        [InlineData(12, 12, 0.12, 100)]
        [InlineData(24, 12, 0.12, 200)]
        public void TestCalcIntByMonths(decimal interestAmount, int months, decimal interestRate, decimal balance ) {
            Assert.Equal(interestAmount, FormatAccount.CalculateInterestByMonths(months, interestRate, balance));                    

        }
        [Fact]
        public void TestNegativeBalance() {
            Action MakeBalanceNegative = () => FormatAccount.CalculateInterestByMonths(1, 0.01m, -100);
            Assert.Throws<ArgumentException>(MakeBalanceNegative);
        }
    }
}
