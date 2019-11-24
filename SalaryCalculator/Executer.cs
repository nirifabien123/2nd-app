using System;

namespace SalaryCalculator
{
    public class Executer
    {
       
        
            public int EmployeeId;
            public string EmployeeName;
            public string EmployeePosition;
            public string EmployeeGender;

            public double EmployeeSalary(double grossSalary)
            {
                double NetSalary;
                NetSalary = grossSalary - (((grossSalary * 30) / 100) + ((grossSalary * 5) / 100) + ((grossSalary * 3) / 100));
                return NetSalary;
            }

            public double EmployeeSalary(double rate, int hour)
            {
                double salary;
                salary=(rate*hour)-((((rate*hour)*5)/100)+(((rate*hour)*3)/100));
                return salary;
            }

            public int EmployeeSalary(int Salarygross)
            {
                
                Int32 salary;
                salary = Salarygross - ((Salarygross * 30) / 100);
                return salary;
            }

    }
} 