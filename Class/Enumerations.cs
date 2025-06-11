using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    public enum ApplicationStatus
    {
        InProgress,
        Approved,
        Rejected
    }

    public enum OrderStatus
    {
        WaitingForPickup,
        Shipped,
        Received,
        Closed,
        Opened
    }

    public enum PaymentStatus
    {
        Paid,
        PartialPayment,
        Unpaid
    }

    public enum ProductCategory
    {
        Camera,
        SecuritySystem,
        Sensor
    }

    public enum EmployeeStatus
    {
        Active,
        Fired,
        Resigned,
        UnpaidLeave
    }

    public enum ShippingType
    {
        Airplane,
        Ship,
        IsraelPost,
        DeliveryCar
    }

    public enum PriceOfferStatus
    {
        Accepted,
        Rejected,
        WaitingForUpdate
    }


}
