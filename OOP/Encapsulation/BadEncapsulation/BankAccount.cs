namespace Encapsulation.BadEncapsulation
{
    public class BankAccount
    {
        /*Using of public fields is VERY BAD practice.
         The problem now is that because they are public,
         everyone from outside can change their values as
         they want even with invalid values without any validation.*/

        public decimal _balance;
        public string? _accountNumber;

        /*Technically this object can be created with invalid information.*/
        public BankAccount(decimal balance, string accountNumber)
        {
            _balance = balance;
            _accountNumber = accountNumber;
        }
    }
}
