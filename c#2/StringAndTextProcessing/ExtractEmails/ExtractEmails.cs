using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {// example
            // string email = "my name is ... and email is tmt940@abv.bg , fsdfgdg gfg ! *  ff@abv.co!! ff@abv.gb.";
            Console.WriteLine("write your twxt and we will extract the emails from it ");
            string email = Console.ReadLine();
            char[] separators = {'!','?',' '};
            string[] parts = email.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            StringBuilder emails=new StringBuilder();
           
            foreach (var part  in parts)
            {
                if (part.Contains('@')&& part.Contains('.'))
                {
                    if ((part[0]>='a'&& part[0]<='z')||(part[0]>='A'&& part[0]<='Z'));
                    {
                        emails.Append(part);
                      
                    }
                        Console.WriteLine(emails);
                    emails.Clear();
                       
                    }
                }

            }
            
        }
    }

