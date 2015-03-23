using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
        public  enum batteryType
        {
           LiIon=1, NiMH=2, NiCd=3,BunseCell=4,NuclearMicroBattery=5,EarthBattery=6
        };
    class Battery
    {
    
       
       private batteryType model;
        private double hoursIdle;
        private double hoursTalk;



        public Battery(batteryType model, double hoursIdle=0, double hoursTalk=0)
        {
            this.model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(batteryType model,  double hoursTalk)
        {
            this.model = model;
           
            this.HoursTalk = hoursTalk;
        }


      



        public batteryType Model
        {
            get
            {
                return model;
            }
            set
            {
               model = value;
            }
        }

        public double HoursIdle
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("hours shoud be positive");
                }
                hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return hoursTalk;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("hours shoud be positive");
                    
                }
               
                hoursTalk = value;
            }
        }

    }
}
