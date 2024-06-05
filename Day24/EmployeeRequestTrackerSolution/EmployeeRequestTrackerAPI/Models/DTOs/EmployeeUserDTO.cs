namespace EmployeeRequestTrackerAPI.Models.DTOs
{
    public class EmployeeUserDTO :Employee
    {
        public string Password { get; set; }//Worng- Adding new attribute is not allowed
    }
}
