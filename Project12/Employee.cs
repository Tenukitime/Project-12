using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12
{
    class Employee
    {
        const double FEDERAL_TAX = 0.2;
        const double STATE_TAX = 0.075;
        const int FULL_TIME = 40;
        const double OVERTIME = 1.5;

        private int employeeNumber;
        private string employeeName;
        private string streetAddress;
        private double hourlyWage;
        private double hoursWorked;


        public Employee(int p1, string p2, string p3, double p4, double p5)
        {
            employeeNumber = p1;
            employeeName = p2;
            streetAddress = p3;
            hourlyWage = p4;
            hoursWorked = p5;

        }


        public int GetEmployeeNumber()
        {
            return employeeNumber;
        }


        public void SetEmployeeNumber(int number)
        {
            employeeNumber = number;

        }


        public string GetName()
        {
            return employeeName;
        }


        public void SetName(string name)
        {
            employeeName = name;
        }


        public string GetStreetAddress()
        {
            return streetAddress;
        }


        public void SetStreetAddress(string address)
        {
            streetAddress = address;
        }


        public double GetHourlyWage()
        {
            return hourlyWage;
        }


        public void SetHourlyWage(double wage)
        {
            hourlyWage = wage;
        }


        public double GetHoursWorked()
        {
            return hoursWorked;
        }


        public void SetHoursWorked(double hours)
        {
            hoursWorked = hours;
        }

        public double CalcSalary()
        {
            double overtimeHours = 0;            

            if (hoursWorked > 40)
            {
                overtimeHours = hoursWorked - FULL_TIME;
                hoursWorked -= overtimeHours;
            }

            double grossSalary = hoursWorked * hourlyWage;
            grossSalary += overtimeHours * (hourlyWage * OVERTIME);

            double netSalary = (grossSalary - ((grossSalary * STATE_TAX) + (grossSalary * FEDERAL_TAX)));

            return netSalary;
        }



    }
}
