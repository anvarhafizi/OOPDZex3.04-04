using System;

namespace Myapp
{
    class Employee
    {
        static void Main(string[] args)
        {
            public string name {set;get;}
     public string surname {set;get;}
     public string position;
     public double salary;
     public int experience;

     public Employee(string name, string surname)
     {
       this.name=name;
       this.surname=surname;
     }
     public void getinfo()
     {
        double wages,tax,finalysalary;
        
        wages=salary+salary*experience/100;
        tax=wages*13/100;

        finalysalary=wages-tax;

        Console.WriteLine($"Name:{this.name}");
        Console.WriteLine($"firstname:{this.surname}"); 
        Console.WriteLine($"Pasition:{position}"); 
        Console.WriteLine($"Salary taking into account the experience :{wages}" );
        Console.WriteLine($"Salary and pensiond fund {tax} ");
        Console.WriteLine($"Salary Payable {finalysalary}");
        }
    }
}
