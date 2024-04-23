using RequestTrackerDALLibrary;
using RequestTrakerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerTest
{
    public class DepartmentGetTest
    {
        IRepository<int, Department> repository;
        [SetUp]
        public void Setup()
        {
            repository = new DepartmentRepository();
            Department department = new Department() { Name = "IT", Department_Head = 101 };
            repository.Add(department);
        }

        [TestCase(1, "Hr", 101)]
        [TestCase(2, "Admin", 101)]
        public void GetPassTest(int id, string name, int hid)
        {

            //Action
            var result = repository.Get(id);
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
