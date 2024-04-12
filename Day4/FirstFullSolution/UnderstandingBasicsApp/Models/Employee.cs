using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingBasicsApp.Models
{
    class Employee
    {
        int id;
        public int GetId()
        {
            return id;
        }


        public void Work()
        {
            Id = 101;
            Console.WriteLine("Work");
        }
    }
}
