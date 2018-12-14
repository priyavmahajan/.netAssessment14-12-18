//2. Add a Class Person with properties Name(string) and Age(int),
//derive Employee from Person, put some values to employee and print on console.

using System;
namespace Assessment14_12_18
{
    class Person                            //base class
    {
        public  string name;
        public int age;
        public void Accept()             //Accept records for five persons
        {
                Console.WriteLine("Enter Name of Person: ");
                this.name = Console.ReadLine();
                Console.WriteLine("Enter Age of Person: ");
                this.age = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()           //Display records for five persons
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
        }
    }
    class Employee : Person                //derived class
    {
        public int empId;
        public string department;
        public void AcceptEmployee()             //accept record 
        {
                Console.WriteLine("Enter Employee Id: ");
                this.empId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Department: ");
                this.department = Console.ReadLine();
        }
        public void DisplayEmployee()                //display record
        {
            Console.WriteLine("EmpID: "+empId);
            Console.WriteLine("Department: "+department);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee();             //derived class object
            emp.Accept();
            emp.AcceptEmployee();
            emp.Display();
            emp.DisplayEmployee();
            Console.Read();
        }
    }
}
