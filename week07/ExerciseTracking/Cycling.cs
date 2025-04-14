namespace FitnessApp
{
    public class Cycling : Activity
    {
        private double _speed; // Kilometers per hour

        public Cycling(DateTime date, int duration, double speed) : base(date, duration)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return (_speed / 60) * Duration;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60 / _speed;
        }
    }
}