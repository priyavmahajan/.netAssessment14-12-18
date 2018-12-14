// Add a class Calculator with method Calculate accepting 2 parameters of type int, 
//it should return sum of these 2 parameters.
using System;
namespace Assessment3_14_12_18
{
    class Calculator
    {
        public int Calculate(int number1,int number2)  //calculate function with two parameter
        {
            int result=number1+number2;
            Console.WriteLine("Addition of number is = "+result);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();   //object of class calculator
            int number1, number2;
            Console.WriteLine("Enter number1= ");               
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2= ");
            number2 = Convert.ToInt32(Console.ReadLine());
            c.Calculate(number1,number2);      //function call of class calculator
            Console.ReadLine();
        }
    }
}
