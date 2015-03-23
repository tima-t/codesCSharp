using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Timer
{
    public delegate void TimerDlg();
    class Timer
    {
        

        public TimerDlg SomeMethods { get; set; }
           
            public int Time { get; private set; }

            public Timer(int time)
            {
                this.Time = time;
            }

            public void ExecuteMethods()
            {
                while (true)
                {
                    this.SomeMethods();
                    Thread.Sleep(this.Time*100);
                }
            }



        
    }
}
