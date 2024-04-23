using RequestTrackerDALLibrary;
using RequestTrakerModelLibrary;

namespace RequestTrackerTest
{
    public class DepartmentRepositoryTest
    {
        IRepository<int, Department> repository;
        [SetUp]
        public void Setup()
        {
            repository = new DepartmentRepository();
        }

        [Test]
        public void AddSuccessTest()
        {
            //Arrange 
            Department department = new Department() { Name = "IT", Department_Head = 101 };
            //Action
            var result = repository.Add(department);
            //Assert
            Assert.AreEqual(1,result.Id);
        }

        [Test]
        public void AddFailTest()
        {
            //Arrange 
            Department department = new Department() { Name = "IT", Department_Head = 101 };
            repository.Add(department);
            department = new Department() { Name = "IT", Department_Head = 102 };
            //Action
            var result = repository.Add(department);
            //Assert
            Assert.IsNull(result);
        }
        [TestCase(1,"Hr",101)]
        [TestCase(2,"Admin",101)]
        public void GetPassTest(int id,string name,int hid)
        {
            //Arrange 
            Department department = new Department() { Name = name, Department_Head = hid };
            repository.Add(department);
            
            //Action
            var result = repository.Get(id);
            //Assert
            Assert.IsNotNull(result);
        }
    }
}