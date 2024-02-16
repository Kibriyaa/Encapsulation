// See https://aka.ms/new-console-template for more information
using BankAccount;

Customer customer = new Customer("John", "Smith");
Customer customer2 = new Customer("Gordan", "Ramsey");

Console.WriteLine($"{customer.FirstName} {customer.LastName}");
Console.WriteLine($"{customer2.FirstName} {customer2.LastName}");