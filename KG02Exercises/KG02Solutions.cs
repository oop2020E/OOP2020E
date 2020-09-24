using KG02Exercises.Parking;
using KG02Exercises.Salary;
using LibOOP;

namespace KG02Exercises
{
    class KG02Solution : IExerciseSolution
    {
        
        public void Run()
        {
            ParkingMeter meter = new ParkingMeter(new WeekdayRate());
            Ticket myticket = meter.InsertCoins(10);

            // time passes, now it is sunday
            meter.RateCalculator = new WeekendRate();

            Ticket myweekendticket = meter.InsertCoins(20);


        }
    }

}
