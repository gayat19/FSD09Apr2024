using UnderstandingBasicsApp.Models;

namespace UnderstandingBasicsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 101;
            employee.Work();
        }
    }
}
