namespace Burak_CoreEntityCodeFirst.Entity
{
    public class EmployeeContactDetail
    {
        public int EmployeeID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Employee Employee { get; set; }
    }
}