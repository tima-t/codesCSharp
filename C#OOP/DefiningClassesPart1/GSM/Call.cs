using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Call
    {
        private DateTime time;
        private string dialledNumbers;
        double duration;

        public Call(DateTime time, string dialledNumbers, double duration)
        {
            this.time = time;
            this.dialledNumbers = dialledNumbers;
            this.duration = duration;
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string DialledNumbers
        {
            get
            {
                return this.dialledNumbers;
            }
            set
            {
                this.dialledNumbers = value;
            }
        }
        public double Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            string info = "the date : " + this.time.ToString() + "\n" + "dialed number: " + this.dialledNumbers + "\n"+ "duration : " + this.duration;
            return info;
        }

    }
}
