using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuinnessTimer
{
    internal class TimerController
    {
        public TimerController() {
            Reset();
        }

        public TimeSpan GetTimeElapsed()
        {
            if (IsRunning)
            {
                var offset = DateTime.Now - StartMoment;
                return ValueAtStart + offset;
            }
            else
            {
                return ValueAtStart;
            }
        }

        public void Start()
        {
            IsRunning = true;
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public void Reset()
        {
            if (IsRunning) return;

            ValueAtStart = TimeSpan.Zero;
        }


        private TimeSpan ValueAtStart = TimeSpan.Zero;
        private DateTime StartMoment;

        private bool _IsRunning = false;
        public bool IsRunning
        {
            get => _IsRunning;
            private set
            {
                // Don't change inner state if nothing changed
                if (_IsRunning == value) return;

                if (value)
                {
                    // Record the moment of starting
                    StartMoment = DateTime.Now;
                }
                else
                {
                    ValueAtStart = GetTimeElapsed();
                }

                _IsRunning = value;
            }
        }
    }
}
