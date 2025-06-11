using System;
using System.Collections.Generic;
using System.Linq;

namespace Project6
{
    public class EmployeeDayOff
    {
        // Fields
        private DateTime dayOffDate;
        private string employeeId;
        private string dayOffType; // Example values: "Vacation", "Sick"

        // Constructor
        public EmployeeDayOff(DateTime dayOffDate, string employeeId, string dayOffType)
        {
            this.dayOffDate = dayOffDate;
            this.employeeId = employeeId;
            this.dayOffType = dayOffType;
        }

        // Method to calculate number of vacation days from a list
        public static int CalcUsedVacationDays(List<EmployeeDayOff> daysOff)
        {
            return daysOff.Count(d => d.dayOffType.Equals("Vacation", StringComparison.OrdinalIgnoreCase));
        }

        // Method to calculate number of sickness days from a list
        public static int CalcUsedSicknessDays(List<EmployeeDayOff> daysOff)
        {
            return daysOff.Count(d => d.dayOffType.Equals("Sick", StringComparison.OrdinalIgnoreCase));
        }

        // Optional Getters
        public DateTime GetDayOffDate() => dayOffDate;
        public string GetEmployeeId() => employeeId;
        public string GetDayOffType() => dayOffType;
    }
}
