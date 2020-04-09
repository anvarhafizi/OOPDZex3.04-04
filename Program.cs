using System;

namespace Myapp
{
    class Employee
    {
         static void Main(string[] args)
    {
         string[] position1=new string[5] {"Accountant","lawyer","Auditor","Оpertor","Loan officer"};
          int[] salary=new int[5]  {2000,3000,3400,4500,5000};
          Console.WriteLine("Please enter name:");
          string name=Console.ReadLine();

          Console.WriteLine("Please enter firstname:");
          string surname=Console.ReadLine();

          Console.WriteLine("Choose your position so enter the number that stands next to your position in the following list:");
          for(int i=1;i<=5;i++)
          {
            Console.WriteLine($"{i}. {position1[i-1]}");
          }
          int n=Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter the Experience");
          int experience=Convert.ToInt32(Console.ReadLine());
          Employee employe=new Employee(name,surname); 
          employe.position=position1[n-1];///
          employe.salary=salary[n-1];
          employe.experience=experience;
          employe.getinfo();
    }
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
