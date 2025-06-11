using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    using System;

    namespace Project6
    {
        public class CustomerApplication
        {
            // Fields
            private int applicationId;
            private string customerName;
            private string contactNumber;
            private DateTime requestDate;
            private ApplicationStatus applicationStatus;
            private string inquiryReason;

            // Constructor
            public CustomerApplication(int applicationId, string customerName, string contactNumber, DateTime requestDate, ApplicationStatus applicationStatus, string inquiryReason)
            {
                this.applicationId = applicationId;
                this.customerName = customerName;
                this.contactNumber = contactNumber;
                this.requestDate = requestDate;
                this.applicationStatus = applicationStatus;
                this.inquiryReason = inquiryReason;
            }

            // Methods
            public void UpdateStatus(ApplicationStatus newStatus)
            {
                applicationStatus = newStatus;
            }

            public void SendEmailToCustomer()
            {
                Console.WriteLine($"Email sent to {customerName} at {contactNumber}");
            }

            // Optional Getters
            public int GetApplicationId() => applicationId;
            public string GetCustomerName() => customerName;
            public string GetContactNumber() => contactNumber;
            public DateTime GetRequestDate() => requestDate;
            public ApplicationStatus GetApplicationStatus() => applicationStatus;
            public string GetInquiryReason() => inquiryReason;
        }
    }


}
