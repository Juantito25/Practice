using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace StopWatch
{
    public class Timer
    {
        private DateTime _startTime;
        private Boolean _isRunning;
        private TimeSpan _stopTime;
        public bool isRunning;

        public void StartTimer()
        {
            
            this._isRunning =  isRunning;
            if (isRunning) 
            {
                Console.WriteLine("The timer already started.");
                return;
            }
            isRunning = true;
            _startTime = DateTime.Now;
        }

        public void StopTimer()
        {

            this._isRunning = isRunning;

            if (isRunning != true)
            {
                Console.WriteLine("The timer has not started.");
                return;
            }

            isRunning = false;
            _stopTime = DateTime.Now - _startTime;
            Console.WriteLine("The time that elaped was : {0}", _stopTime);
        }
    }
}