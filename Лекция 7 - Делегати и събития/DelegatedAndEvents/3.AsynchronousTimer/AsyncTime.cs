using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.AsynchronousTimer
{
    class AsyncTime
    {
        private int interval;
        private int ticks;
        public Action<int> Action { get; private set; }

        public AsyncTime(Action<int> action, int timerSeconds, int ticks)
        {
            this.Action = action;
            this.Interval = timerSeconds;
            this.Ticks = ticks;
        }

        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Value cannot be negative.");
                }
                this.interval = value;
            }
        }

        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Value cannot be negative.");
                }
                this.ticks = value;
            }
        }

        public void Execute()
        {
            Thread thread = new Thread(this.Run);
            thread.Start();
        }

        public void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.Interval);

                if (this.Action != null)
                {
                    this.Action(i);
                }
            }
        }
    }
}
