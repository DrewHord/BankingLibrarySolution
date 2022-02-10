using System;

namespace AccountFormatLibrary {
    public class FormatAccount {

        public static decimal CalculateInterestByMonths(int months, decimal interestRate, decimal balance) {
            if(balance < 0) {
                throw new ArgumentException("Balance can not be negative!");
            }
            return balance * (interestRate / 12) * months;

        }     
        
    }
}
