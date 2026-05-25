using System;

namespace TourAgencyApp
{
    public abstract class TourOrder
    {
        public string OrderCode { get; set; }
        public string CustomerName { get; set; }
        public string TourName { get; set; }
        public string Country { get; set; }
        public int Quantity { get; set; }
        public double PricePerOne { get; set; }

        public abstract double CalculateTotal();
        public abstract string GetTourType();
    }

    public class StandardTour : TourOrder
    {
        public override double CalculateTotal() { return Quantity * PricePerOne; }
        public override string GetTourType() { return "Звичайний"; }
    }

    public class HotTour : TourOrder
    {
        public double DiscountPercent { get; set; }
        public override double CalculateTotal()
        {
            double total = Quantity * PricePerOne;
            return total - (total * DiscountPercent / 100);
        }
        public override string GetTourType() { return "Гарячий"; }
    }
}