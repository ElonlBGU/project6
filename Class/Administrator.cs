using System;

namespace Project6
{
    public class Administrator
    {
        private string employeeId;
        private string employeeName;
        private string employeeAdress;
        private string employeePhone;
        private DateTime hireDate;
        private int salary;
        private EmployeeStatus employeeStatus;
        private int unUsedVacationDays;
        private DateTime quitDate;

        public Administrator(string id, string name, string address, string phone, DateTime hireDate, int salary, EmployeeStatus status, int vacationDays, DateTime quitDate)
        {
            this.employeeId = id;
            this.employeeName = name;
            this.employeeAdress = address;
            this.employeePhone = phone;
            this.hireDate = hireDate;
            this.salary = salary;
            this.employeeStatus = status;
            this.unUsedVacationDays = vacationDays;
            this.quitDate = quitDate;
        }

        public void UpdateEmployeeInformation(Administrator employee, string newAddress, string newPhone)
        {
            employee.employeeAdress = newAddress;
            employee.employeePhone = newPhone;
        }

        public void CreateNewEmployee()
        {
            Console.WriteLine("New employee created.");
        }

        public string GetEmployeeContract()
        {
            return $"Contract for {employeeName} starts on {hireDate.ToShortDateString()}";
        }
    }
}
