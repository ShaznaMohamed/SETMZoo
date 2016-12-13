using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Salary
    {
        #region Attributes
        private int noOfHoursWorked;
        private double employeeRate;
        private double monthlySalary;
        public Guid empID;
        private Employee e1 = new Employee();
        #endregion 
        
        #region Getters and Setters

        public int NoOfHoursWorked
        {
            get
            {
                return noOfHoursWorked;
            }

            set
            {
                noOfHoursWorked = value;
            }
        }

        public double EmployeeRate
        {
            get
            {
                return employeeRate;
            }

            set
            {
                employeeRate = value;
            }
        }

        public double MonthlySalary
        {
            get
            {
                return monthlySalary;
            }

            set
            {
                monthlySalary = value;
            }
        }
        #endregion

        #region Methods
        public double CalculateMonthlySalary()
        {
            return MonthlySalary = EmployeeRate * NoOfHoursWorked; 
        }

        public void PrintSalary()
        {
            Console.WriteLine(e1.firstName + " 's salary is " + MonthlySalary);
        }
        #endregion 

    }
}
