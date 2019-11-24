using System;

namespace SalaryCalculator
{
    class Program
    {
               static void Main(string[] args)
               {
                   Int16 a;
                   Console.WriteLine("Welcome Dear Sir/Madam/Miss. Please select from the following choices:");
                   Console.WriteLine("1 If you are monthly employee.\n2 If you are One-Time employee\n3 If you are Hourly employee ");
                   Console.WriteLine("Waiting for your choice!");
                   a = Convert.ToInt16(Console.ReadLine());
                   switch (a)
                   {
                       case 1:
                           Executer ExecuterAccessor=new Executer();
                           Console.WriteLine("Enter your Id:");
                           ExecuterAccessor.EmployeeId = Convert.ToInt32(Console.ReadLine());
                   
                           Console.WriteLine("Enter your names:");
                           ExecuterAccessor.EmployeeName = Console.ReadLine();
                           Console.WriteLine("Enter your position:");
                           ExecuterAccessor.EmployeePosition = Console.ReadLine();
                           Console.WriteLine("Enter your gender:");
                           ExecuterAccessor.EmployeeGender= Console.ReadLine();
                           Console.WriteLine("Enter your gross salary:");
                           double grossSalary;
                
                           grossSalary = Convert.ToDouble(Console.ReadLine());
                   
                           Console.WriteLine($"{ExecuterAccessor.EmployeeName} your monthly salary on position of {ExecuterAccessor.EmployeePosition}   is {ExecuterAccessor.EmployeeSalary(grossSalary)}");
                        break;
                       
                       case 2:
                           //one time employee
                           Executer ExecuterAccessor1=new Executer();
                           Console.WriteLine("Enter your Id:");
                           ExecuterAccessor1.EmployeeId = Convert.ToInt32(Console.ReadLine());
                   
                           Console.WriteLine("Enter your names:");
                           ExecuterAccessor1.EmployeeName = Console.ReadLine();
                           Console.WriteLine("Enter your position:");
                           ExecuterAccessor1.EmployeePosition = Console.ReadLine();
                           Console.WriteLine("Enter your gender:");
                           ExecuterAccessor1.EmployeeGender= Console.ReadLine();
                           Console.WriteLine("Enter your one-time salary to calculate your net salary:");
                           Int32 Salarygross = Convert.ToInt32(Console.ReadLine());
                   
                           Console.WriteLine($"{ExecuterAccessor1.EmployeeName} your one-time salary on position of {ExecuterAccessor1.EmployeePosition} is {ExecuterAccessor1.EmployeeSalary(Salarygross)}.00rwf");
break;
                       case 3:
                           Executer ExecuterAccessor2=new Executer();
                           Int16 hour;
                           
                           Console.WriteLine("Enter your Id:");
                           ExecuterAccessor2.EmployeeId = Convert.ToInt32(Console.ReadLine());
                   
                           Console.WriteLine("Enter your names:");
                           ExecuterAccessor2.EmployeeName = Console.ReadLine();
                           Console.WriteLine("Enter your position:");
                           ExecuterAccessor2.EmployeePosition = Console.ReadLine();
                           Console.WriteLine("Enter your gender:");
                           ExecuterAccessor2.EmployeeGender= Console.ReadLine();
                           Console.WriteLine("Enter your rate to calculate your net salary:");
                           double rate;
                           rate = Convert.ToDouble(Console.ReadLine());
                   
                  Console.WriteLine("Enter your working hours:");
                           hour = Convert.ToInt16(Console.ReadLine());
                           if ((rate != 0) && (hour != 0))
                           {
                               Console.WriteLine($"{ExecuterAccessor2.EmployeeName} Your hourly salary for { hour} hours is {ExecuterAccessor2.EmployeeSalary(rate,hour)}.00rwf");
                           }
                           else
                           {
                               Console.WriteLine(" Your hourly salary is 0");
                           }
                           
                           break;
                           
                           
                   }
                  
                   
                  
                   
                   
               }

    }
}