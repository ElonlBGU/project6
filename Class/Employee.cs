using System;

namespace Project6
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? QuitDate { get; set; }
        public int Salary { get; set; }
        public int UsedVacationDays { get; set; }
        public int UsedSicknessDays { get; set; }

        public override string ToString()
        {
            return $"{Name} ({EmployeeId}) - {Status}";
        }
    }
}
