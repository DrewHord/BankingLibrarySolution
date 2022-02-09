using AccountFormatLibrary;
using System;

namespace BankingLibraryProject {
    public class Account {

        public int AccountNumber { get; set; } = 1;
        public string Description { get; set; } = "Interest-bearing account";
        public decimal Balance { get; set; } = 100m;
        public decimal InterestRate { get; set; } = 0.12m;

        public decimal CalculateInterest(int months) {
            decimal interestAmount = FormatAccount.CalculateInterestByMonths(months, InterestRate, Balance);
            Balance += interestAmount;
            return interestAmount; 
        }
    }
}
