using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingBasicsApp.Models
{
    class Employee
    {

        double salary;
        public int Id { get; private set; }

        public string Name { get; set; }

        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return (salary-(salary*10/100));
            }
        }
        public DateTime DateOfBirth { get; set; }
        public  string Email { get; set; }

        public Employee()
        {
            Id = 0;
            Name= string.Empty;
            Email = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Salary = 0;
        }

        public Employee(int id)
        {
            Id = id;
        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <param name="name">Employee Name as string</param>
        /// <param name="salary">Employee salary without TDS deduction</param>
        /// <param name="dateOfBirth">Date of birth</param>
        /// <param name="email">Office Email</param>
        public Employee(int id, string name, double salary, DateTime dateOfBirth, string email) : this(id)
        {
            Name = name;
            Salary = salary;
            DateOfBirth = dateOfBirth;
            Email = email;
        }
        /// <summary>
        /// Prints all teh details of employee
        /// </summary>
        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"Employee Id\t:\t{Id}");
            Console.WriteLine($"Employee name\t:\t{Name}");
            Console.WriteLine($"Employee Date Of Birth\t:\t{DateOfBirth}");
            Console.WriteLine($"Employee Salary\t:\tRs.{Salary}");
            Console.WriteLine($"Employee Email\t:\t{Email}");
        }
        /// <summary>
        /// Displays the work done in the duration
        /// </summary>
        /// <param name="hours">Hors required for work</param>
        /// <returns>Message on hours worked</returns>
        public string Work(int hours)
        {
            Console.WriteLine("Works");
            return $"Done work for {hours} Hours";
        }
    }
}
