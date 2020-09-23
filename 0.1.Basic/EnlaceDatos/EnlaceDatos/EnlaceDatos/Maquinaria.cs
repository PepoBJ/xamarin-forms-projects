using System;
using System.Timers;

namespace EnlaceDatos
{
    public class Maquinaria : NotificationObject
    {
        private int hour;

        public int Hour
        {
            get { return hour; }
            set 
            {
                hour = value;
                OnPropertyChanged();
            }
        }

        private int minute;

        public int Minute
        {
            get { return minute; }
            set 
            { 
                minute = value;
                OnPropertyChanged();
            }
        }

        private int second;

        public int Second
        {
            get { return second; }
            set 
            { 
                second = value;
                OnPropertyChanged();
            }
        }

        public Maquinaria()
        {
            Hour = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
            Second = DateTime.Now.Second;

            var timer = new Timer();

            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += (s, e) =>
            {
                Hour = DateTime.Now.Hour;
                Minute = DateTime.Now.Minute;
                Second = DateTime.Now.Second;
            };
            timer.Enabled = true;
            timer.Start();
        }

    }
}
