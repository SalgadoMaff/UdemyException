using System.Globalization;
using System.Linq.Expressions;
using UdemyException.Entities;
using UdemyException.Entities.Exception;

int readNumber()
{
    Console.Write("Number: ");
    return int.Parse(Console.ReadLine());
}
string readHolder()
{
    Console.Write("Holder: ");
    return Console.ReadLine();
}

double readInitialBalance()
{
    Console.Write("Initial balance: ");
    return double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
}

double readWithdrawLimit()
{
    Console.Write("Withdraw limit: ");
    return double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
}

    

try
{
    Account acc = new Account(readNumber(), readHolder());
    acc.deposit(readInitialBalance());
    acc.WithdrawLimit = readWithdrawLimit();
    Console.Write("\nEnter amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    acc.withdraw(withdraw);
    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: "+e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Unhandled Exception: " +e.Message);
}

