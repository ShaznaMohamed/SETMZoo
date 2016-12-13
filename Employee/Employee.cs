using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        //member variables
        private Guid employeeID;
        public  String firstName;
        public  String lastName;

        public Guid EmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                employeeID = value;
            }
        }

        public Employee()
        {
            this.EmployeeID = new Guid();
        }
        private String GetFullName (String fname, String lname)
        {
            return fname + lname;
        }

        public void DisplayFullName()
        {
            Console.WriteLine("Full Name is " + GetFullName(firstName, lastName));
        }
        
    }
}
