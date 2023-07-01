using static System.Formats.Asn1.AsnWriter;
using System;
using System.Security.Cryptography;

namespace BankEncapsulation
{
    internal class Program
    {

        //Create a new public class named BankAccount
        //In your BankAccount class, create the following:
        //A private field of type double named **balance** with a value of 0
        //Define a method named Deposit that will accept a double and store that value in the balance field
        //Define a method named GetBalance that will return the amount stored in the balance field
        //In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
        //Once finished save, commit, and push back to Github

        static void Main(string[] args)
        {
            //initialize the bankaccount and add money(initial deposit)
            BankAccount myriamsBankAccount = new BankAccount();

            //add money(initial deposit)
            Console.WriteLine(" ");
            Console.WriteLine("Enter Deposit Amount:");
            double userInput = double.Parse(Console.ReadLine());

            //call deposit Method
            myriamsBankAccount.Deposit(userInput);

            //call getbalance Method and Print it
            Console.WriteLine(" ");
            Console.WriteLine($" My balance is: {myriamsBankAccount.GetBalance()}");

            //add money
            Console.WriteLine(" ");
            Console.WriteLine("Deposit more money:");
            double userInput2 = double.Parse(Console.ReadLine());


            //call deposit Method again to see the updated balance
            myriamsBankAccount.Deposit(userInput2);

            //get the updated balance and Print it
            Console.WriteLine(" ");
            Console.WriteLine($" My New balance is: {myriamsBankAccount.GetBalance()}");


            //From the exercize video
            //how to call Methods
            //Static
            //ClassName.MethodName();
            //instance Method
            //instanceName.MethodName();


        }
    }
}
