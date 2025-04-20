/*============START OF BAD ENCAPSULATION EXAMPLE===========*/

/*Here technically we can pass any string for account number 
 which leads to working with wrong data after that and bugs.
 There is not validation in our class - BankAccount for the 
 accountNumber field.*/

var badBankAccount = new Encapsulation.BadEncapsulation.BankAccount(100m, "WhateverString");

/*Now we set a negative value to the balance which is totally unacceptable.
  This leads to working with invalid data in the application.
  Imagine this data is published to official report for the customer and
  he sees this balance...*/

badBankAccount._balance = -300;

/*Imagine we want some logic to be called when the balance is changed.
 In the current situation we have to add manually this logic (ReportBalance method) after
 the changed balance EVERY time when we change it. See the example below:*/

badBankAccount._balance = 600;
ReportBalance(badBankAccount._balance);

badBankAccount._balance = 100;
ReportBalance(badBankAccount._balance);

badBankAccount._balance = 400;
ReportBalance(badBankAccount._balance);

badBankAccount._balance = 1000;
ReportBalance(badBankAccount._balance); 

/*Now imagine that you have 100 places (classes) in your codebase where you have to do that...
 This is totally wrong. Please see the good example in the GoodEncapsulation folder.*/


static void ReportBalance(decimal balance)
{
    Console.WriteLine($"The current balance for this account is: {balance}.");
}

/*============END OF BAD ENCAPSULATION EXAMPLE===========*/


//==============================================================================
//==============================================================================
//==============================================================================


/*============START OF GOOD ENCAPSULATION EXAMPLE===========*/

/*Here when we pass account number we have validation inside of BankAccount class.*/

var bankAccount = new Encapsulation.GoodEncapsulation.BankAccount("1234567");

//The line below does not compile because we cannot set balance from outside of the BankAccount class.
//Uncomment the line below to see.

//bankAccount.Balance = -100; 

/*The methods below are the public interface (API) of the class and only with them we can
  change the balance in controlled way this time + validation. */

bankAccount.Deposit(100);

bankAccount.Withdraw(50);

/*We cannot set negative amount or to withdraw more money than the available at the moment into the account.
 We will get an exception if we try this. See the BankAccount class for more information.*/

/*Now after every change of the balance will be raised an event. But the difference now is 
that raising of the event is in the class itself in centralized way but is not needed after every change of balance to 
be called manually some method. */

/*============END OF GOOD ENCAPSULATION EXAMPLE===========*/
