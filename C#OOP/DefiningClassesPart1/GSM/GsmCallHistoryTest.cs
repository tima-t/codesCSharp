using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it.*/
namespace GSM
{
    class GsmCallHistoryTest
    {
        public static void Main()
        {
            List<Call> calls = new List<Call>();
           
            calls.Add(new Call(new DateTime(2015,2,27),"088554675",120));
            calls.Add(new Call(new DateTime(2015,3,5),"088554654",129));
            calls.Add(new Call(new DateTime(2015,3,6),"0885546325",45));
            calls.Add(new Call(new DateTime(2015,3,10),"088554672",150));

            Gsm gs=new Gsm("z1", "sony", 650, "gosho", new Battery(batteryType.BunseCell, 20, 10), new Display(5, 6500),calls);
            double tempLongestCall = -1;
            foreach (var call in gs.CallHistory)
            {
                Console.WriteLine(call.ToString());
            
            }
            Console.WriteLine("the total price for all calls is : {0:C} " , gs.CallPrice(0.37));
            gs.RemoveLongestCall();
            Console.WriteLine("the total price for all calls after removing  is : {0:C} ", gs.CallPrice(0.37));
            gs.ClearCallHistory();
            foreach (var call in gs.CallHistory)
            {
                Console.WriteLine(call.ToString());

            }


          
        }
    }
}
