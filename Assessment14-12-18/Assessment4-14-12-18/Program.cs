// Override the above method so that new method returns multiple of the parameters.
using System;
namespace Assessment4_14_12_18
{
    class Calculator                         //base class
    {
        public virtual int Calculate(int number1, int number2)  //calculate function with two parameter
        {
            int Addition = number1 + number2;
            return Addition;
        }
    }
    class CalculatorMultiplication : Calculator               //derived class
    {
        public override int Calculate(int number1, int number2)    //override methode of bae class
        {
            int multiplication = number1 * number2;
            return multiplication;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal;                       //object of class calculator
            int number1, number2;
            Console.WriteLine("Enter number1= ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2= ");
            number2 = Convert.ToInt32(Console.ReadLine());
            cal = new Calculator();                //base class method
            Console.WriteLine("Addition of number is: "+cal.Calculate(number1, number2));
            cal = new CalculatorMultiplication();   //derived class method
            Console.WriteLine("Multiplication of number is: " + cal.Calculate(number1, number2));
            Console.ReadLine();
        }
    }
}
