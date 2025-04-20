namespace Encapsulation.GoodEncapsulation
{
    public class BankAccount
    {
        private const int ACCOUNT_NUMBER_LENGTH = 7;

        private string? _accountNumber;

        public event EventHandler<BankEventArgs> BalanceChanged;

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }

        //Balance cannot be changed directly from outside of the class.
        public decimal Balance { get; private set; }

        public string? AccountNumber
        {
            get
            {
                return _accountNumber;
            }

            //We make validation for the account number.
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(_accountNumber));
                }

                var validationObject = ValidateAccountNumber(_accountNumber);

                if (!validationObject.result)
                {
                    throw new ArgumentException($"{validationObject.message}");
                }

                _accountNumber = value;
            }
        }

        //We change the balance property only via this public interface of the methods "Deposit" and "Withdraw" in controlled way.
        //The event for changed balance is called in each of these methods.

        public void Deposit(decimal amount)
        {
            Balance += amount;
            OnBalanceChanged(Balance);
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive.");
            }

            if (amount > Balance)
            {
                throw new ArgumentException("Insufficient funds.");
            }

            Balance -= amount;
            OnBalanceChanged(Balance);
        }

        private (bool result, string message) ValidateAccountNumber(string accountNumber)
        {
            if (accountNumber.Length != ACCOUNT_NUMBER_LENGTH)
            {
                return (false, "The length of the account number must be 7 symbols (digits).");
            }

            if (accountNumber.Any(char.IsLetter))
            {
                return (false, "Account number must contains only digits.");
            }

            //More validation logic...not important for the encapsulation example.

            return (true, string.Empty);
        } 

        private void OnBalanceChanged(decimal balance)
        {
            BalanceChanged?.Invoke(this, new BankEventArgs() { Balance = balance });
        }
    }
}
