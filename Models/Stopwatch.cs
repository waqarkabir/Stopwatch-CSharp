namespace Models
{
    public class StopWatch
    {
        private TimeSpan _timeTaken;
        private DateTime _time;
        private bool _running;

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Cannot start without stopping.");
            }

            _time = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
            {
                throw new InvalidOperationException("Cannot stop without starting.");
            }

            _running = false;
        }

        public TimeSpan TimeTook()
        {
            return _timeTaken += DateTime.Now - _time;
        }
    }
}