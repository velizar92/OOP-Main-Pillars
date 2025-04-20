/*============Start of Bad encapsulation example===========*/

using Encapsulation.BadEncapsulation;

/*Here technically we can pass any string for account number 
 which leads to working with wrong data after that and bugs.
 There is not validation in our class - BankAccount for the 
 accountNumber field.*/

BankAccount badBankAccount = new BankAccount(100m, "WhateverString");

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

/*============End of Bad encapsulation example===========*/
