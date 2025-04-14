using System;

namespace FitnessApp
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _duration; // Minutes

        protected Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public DateTime Date => _date;
        public int Duration => _duration;

        public abstract double GetDistance(); // Abstract method for distance
        public abstract double GetSpeed();    // Abstract method for speed
        public abstract double GetPace();     // Abstract method for pace

        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} ({_duration} min): Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
        }
    }
}