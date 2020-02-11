using System;

namespace VVV
{
  class Program
  {
    static void Main(string[] args)
    {
      //number of coffee drinks a day
      var numberOfCupsOfCoffee = 1;
      //my full name
      var fullName = "Bianca Brown";
      //today's date
      var today = "2/10/20";
      //print these
      Console.WriteLine("Hi, my name is " + fullName + ". On " + today + ", I drank " + numberOfCupsOfCoffee + " cup of coffee.");
      //Console.WriteLine(fullName);
      //Console.WriteLine(today);
      //ask user name
      Console.WriteLine("What's your name?");
      var user = Console.ReadLine();
      //greet user
      Console.WriteLine("Hi there, " + user + "!");
      //ask to input two numbers
      Console.WriteLine(user + ", please enter two numbers.");
      //takes in first number
      var number1 = Console.ReadLine();
      var operand1 = Double.Parse(number1);
      //takes in second number
      var number2 = Console.ReadLine();
      var operand2 = Double.Parse(number2);
      //gets total
      var sum = operand1 + operand2;
      var difference = operand1 - operand2;
      var product = operand1 * operand2;
      var quotient = operand1 / operand2;
      var remainder = operand1 % operand2;
      Console.WriteLine("The total of your first and second number is " + sum + ". " + "The difference of those numbers is " + difference + ". " + "Multiplied they are " + product + ". " + "Divided they are " + quotient + ", " + "and the remainder would be " + remainder + ". ");
    }
  }
}
