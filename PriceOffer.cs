using System;

namespace Project6
{
    public class PriceOffer
    {
        private string offerId;
        private DateTime offerDate;
        private PriceOfferStatus status;
        private int totalPrice;

        public PriceOffer(string offerId, DateTime offerDate, PriceOfferStatus status, int totalPrice)
        {
            this.offerId = offerId;
            this.offerDate = offerDate;
            this.status = status;
            this.totalPrice = totalPrice;
        }

        public int CalculateTotalOfferAmount()
        {
            return totalPrice;
        }

        public void SetTotalPrice(int price)
        {
            totalPrice = price;
        }

        public string GetOfferId() => offerId;
        public DateTime GetOfferDate() => offerDate;
        public PriceOfferStatus GetStatus() => status;
        public int GetTotalPrice() => totalPrice;
    }
}
