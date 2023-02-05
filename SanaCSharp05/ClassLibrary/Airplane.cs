using System;

namespace ClassLibrary
{
    public class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public Date StartDate { get; set; }
        public Date FinishDate { get; set; }

        public Airplane()
        {
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(Airplane airplane) : this(airplane.StartCity, airplane.FinishCity, airplane.StartDate, airplane.FinishDate)
        {
        }

        public double GetTotalTime()
        {
            var finishDate = new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day, FinishDate.Hours, FinishDate.Minutes, 0);
            var startDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hours, StartDate.Minutes, 0);

            return (finishDate - startDate).TotalMinutes;
        }
        public bool IsArrivingToday()
        {
            return GetTotalTime() < 1440;
        }
    }
}
