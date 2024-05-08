using SampleEFApp.Model;

namespace SampleEFApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dbEmployeeTrackerContext context = new dbEmployeeTrackerContext();
            //Area area = new Area();
            //area.Area1 = "POPO";
            //area.Zipcode = "44332";
            //context.Areas.Add(area);
            //context.SaveChanges();


            var areas = context.Areas.ToList();
            var area = areas.SingleOrDefault(a => a.Area1 == "TTTT");
            area.Zipcode = "00000";
            context.Areas.Update(area);
            context.SaveChanges();

            area = areas.SingleOrDefault(a => a.Area1 == "HYHY");
            context.Areas.Remove(area);
            context.SaveChanges();
            foreach ( var a in areas )
            {
                Console.WriteLine(a.Area1+" "+a.Zipcode);
            }

        }
    }
}
