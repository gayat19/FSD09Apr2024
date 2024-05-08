
using RequestTrackerBLLibrary;
using RequestTrackerDALLibrary;
using RequestTrakerModelLibrary;
using System.Collections;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;

namespace RequestTrackerApp
{
    internal class Program
    {
        void AddDepartment()
        {
           
            DepartmentBL departmentBL = new DepartmentBL(new DepartmentRepository());
            try
            {
                Console.WriteLine("Pleae enter the department name");
                string name = Console.ReadLine();
                Department department = new Department() { Name = name };
                int id = departmentBL.AddDepartment(department);
                Console.WriteLine("Congrats. We ahve created the department for you and the Id is " + id);
                Console.WriteLine("Pleae enter the department name");
                name = Console.ReadLine();
                department = new Department() { Name = name };
                id = departmentBL.AddDepartment(department);
                Console.WriteLine("Congrats. We ahve created the department for you and the Id is "+id);
            }
            catch (DuplicateDepartmentNameException ddne)
            {
                Console.WriteLine(ddne.Message);
            }
        }

       
        static void Main(string[] args)
        {
            //new Program().AddDepartment();
            SqlConnection conn = new SqlConnection(@"Data Source=G3SLAPTOP\SQLEXPRESS;Integrated Security=true;Initial Catalog=dbEmployeeTracker;");
            Console.WriteLine("Conenction Established");
            SqlCommand command = new SqlCommand("Select * from areas",conn);
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            List<Area> areas = new List<Area>();
            dataAdapter.Fill(dataSet);//Connects->Fetches data->puts in dataset->disconnects
            foreach (DataRow item in dataSet.Tables[0].Rows)
            {
                Area area = new Area();
                area.AreaName = item["Area"].ToString();
                area.Zipcode = item[1].ToString();
                areas.Add(area);
            }
            foreach (var item in areas)
            {
                Console.WriteLine(item);
            }

        }

        private static Area GetAreaFromUser()
        {
            Console.WriteLine("Please enter the Area name");
            Area area = new Area();
            area.AreaName = Console.ReadLine();
            Console.WriteLine("Please enter the Zipcode");
            area.Zipcode = Console.ReadLine();
            return area;
        }
    }

    public class Area
    {
        public string AreaName { get; set; }
        public string Zipcode { get; set; }
        public override string ToString()
        {
            return AreaName+" "+Zipcode;
        }
    }
}
