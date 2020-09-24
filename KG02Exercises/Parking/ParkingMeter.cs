using System;

namespace KG02Exercises.Parking
{
    class ParkingMeter
    {
        public ParkingMeter(ParkingRate rateCalculator)
        {
            RateCalculator = rateCalculator;
        }
        public Ticket InsertCoins(decimal coinSum)
        {
            return new Ticket(coinSum, (int)Math.Floor(coinSum / RateCalculator.CalculateRate()));
        }
        public ParkingRate RateCalculator { get; set; }
    }
}