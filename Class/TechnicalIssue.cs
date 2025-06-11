using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    public class TechnicalIssue
    {
        public string ErrorType { get; set; }
        public bool IsFixable { get; set; }

        public bool CanBeLocallyRepaired() => IsFixable;
        public string GetProductID() => "Unknown"; // צריך לחבר למוצר
        public string GetTechnician() => "Unknown"; // צריך לחבר לטכנאי
        public int GetCustomerApplicationID() => 0;
        public int GetTicketID() => 0;
    }

}
