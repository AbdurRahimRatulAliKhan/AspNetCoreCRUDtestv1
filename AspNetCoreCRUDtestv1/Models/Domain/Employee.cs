namespace AspNetCoreCRUDtestv1.Models.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeDescription { get; set; }
        public string? EmployeePhone { get; set; }
        public int? EmployeePhoneId { get; set; }
        public string? EmployeePhoneName { get; set;}
        public string? EmployeePhoneDescription { get; set;}
    }
}
