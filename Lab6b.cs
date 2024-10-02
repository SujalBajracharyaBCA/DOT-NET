// Susing System;

namespace Lab6b
{
    public abstract class Customer
    {
        public string Name { get; set; }
    }

    public class Individual : Customer
    {
        // Additional properties specific to individual customers can be added here.
    }

    public class Company : Customer
    {
        // Additional properties specific to company customers can be added here.
    }

    public abstract class Account
    {
        public Customer Customer { get; private set; }
        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; protected set; }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            Customer = customer;
            Balance = balance;
            InterestRate = interestRate;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public abstract decimal CalculateInterest(int months);
    }

    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
                throw new InvalidOperationException("Insufficient balance.");
        }

        public override decimal CalculateInterest(int months)
        {
            if (Balance < 1000 && Balance > 0)
                return 0;
            else
                return months * InterestRate;
        }
    }

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (Customer is Individual && months <= 3)
                return 0;
            if (Customer is Company && months <= 2)
                return 0;
            return months * InterestRate;
        }
    }

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (Customer is Individual && months <= 6)
                return 0;
            if (Customer is Company && months <= 12)
                return (months * InterestRate) / 2;
            return months * InterestRate;
        }
    }

    class Program
    {
        static void Main()
        {
            Customer individual = new Individual { Name = "John Doe" };
            Customer company = new Company { Name = "Tech Corp" };

            Account depositAccount = new DepositAccount(individual, 1200m, 0.05m);
            Account loanAccount = new LoanAccount(company, 5000m, 0.08m);
            Account mortgageAccount = new MortgageAccount(individual, 150000m, 0.07m);

            Console.WriteLine($"Deposit Account Interest (12 months): {depositAccount.CalculateInterest(12)}");
            Console.WriteLine($"Loan Account Interest (12 months): {loanAccount.CalculateInterest(12)}");
            Console.WriteLine($"Mortgage Account Interest (12 months): {mortgageAccount.CalculateInterest(12)}");
        }
    }
}
