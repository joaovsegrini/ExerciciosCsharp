using System;

namespace Composicao.Entities
{
    internal class HoursContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public HoursContract()
        {
        }

        public HoursContract(DateTime date, double valuePerHours, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHours;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

    }
}
