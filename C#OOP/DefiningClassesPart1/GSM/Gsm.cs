using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 */

namespace GSM
{
    class Gsm
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery bat;
        private Display disp;
        public static Gsm iPhone4S= new Gsm("iphone4s", "apple", 450, "petkan", new Battery(batteryType.EarthBattery, 15,6), new Display(4.5, 6500));
        private List<Call> callHistory = new List<Call>();



        public Gsm(string model, string manufacturer, double price, string owner=null, Battery bat=null, Display disp=null,List<Call> callHistory=null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.Price = price;
            this.owner = owner;
            this.bat = bat;
            this.disp = disp;
            this.callHistory = callHistory;
        
        }
        public Gsm(string model, string manufacturer, double price, string owner = null, Battery bat = null, Display disp = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.Price = price;
            this.owner = owner;
            this.bat = bat;
            this.disp = disp;
           

        }

        public Gsm(string model, string manufacturer,  Battery bat = null, Display disp = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
           
            this.bat = bat;
            this.disp = disp;
        }

        public Gsm(string model, string manufacturer, double price, Display disp = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.Price = price;
          
            this.disp = disp;
        }


       


        public string Model
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

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("the price cant be negative");
                }
                price = value;
            }
        }


        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public Gsm IPhone4S 
        {
            get
            {
                return iPhone4S;
            }
            set
            {
               iPhone4S = value;
            }
        }

        private   void PrintInfo()
        {
            Console.WriteLine("model : {0}", this.model);
            Console.WriteLine("manufacturer : {0}", this.manufacturer);
            Console.WriteLine("price : {0}", this.price);
            Console.WriteLine("owner : {0}", this.owner);
            Console.WriteLine(" battery model : {0}", this.bat.Model);
            Console.WriteLine("hoursidle : {0}", this.bat.HoursIdle);
            Console.WriteLine("hours talk  : {0}", this.bat.HoursTalk);
            Console.WriteLine("Display size : {0}",this.disp.Size);
            Console.WriteLine("number of colours : {0}",this.disp.NumberOfColours);
            
           

           

        }

        private void AddCall(Call newCall)
        {
            this.callHistory.Add(newCall);
        }

       public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

     public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }


       public double CallPrice(double callPrice)
        {
            double cost = 0;
            foreach (var call in this.callHistory)
            {
                cost += (call.Duration/60) * callPrice ;//price is per minute , duration is in seconds and we devide per 60 
            }
            return cost;
        }

       public void RemoveLongestCall()
       {
           Call temp=null;
           
           double longestCall = -1;
           foreach (var call in this.callHistory)
           {
               if (call.Duration>longestCall)
               {
                   longestCall = call.Duration;
               }
           }
           foreach (var call in callHistory)
           {
               if (call.Duration==longestCall)
               {
                  temp = new Call(call.Time, call.DialledNumbers, call.Duration);
                  
                  
               }
              
           }
          
           this.DeleteCall(temp);
           
       }



        public override string ToString()
        {

            string info = "model :  " + model + "\n" + "manufacturer: "+ manufacturer + "\n" +"price:  " + price + "\n"+ "owner : " + owner + "\n"+ "battery model : " + bat.Model + "\n" + "battery hours idel : "+ bat.HoursIdle + "\n"+"battery hours talk : " + bat.HoursTalk + "\n"+ "display numbe of colours : " + disp.NumberOfColours + "\n"+"disp Siza : " + disp.Size +" inches";
            return info ;
        }

   

      /*  public static void Main()
        {
          
             Battery bat = new Battery(batteryType.LiIon, 5, 10);
             Display disp = new Display(5, 65000000);
             Gsm gsm = new Gsm("Z3", "Sonny", 200, "Ivan", bat, disp);
             gsm.PrintInfo();
             Console.WriteLine(gsm.ToString());
            
             
             
        }*/



        


    }
}
