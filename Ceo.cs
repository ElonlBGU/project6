using Project6.Project6;
using System;

namespace Project6
{
    public class CEO
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

        public CEO(string id, string name, string address, string phone, DateTime hireDate, int salary, EmployeeStatus status, int vacationDays, DateTime quitDate)
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

        public void UpdatePriceOffer(PriceOffer offer, int newPrice)
        {
            offer.SetTotalPrice(newPrice);
        }
    }
}
