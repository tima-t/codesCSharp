using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace DownLoadFile
{
    class DownLoadFile
    {
        static void Main()
        {
            Console.WriteLine("downloading........");
            string Url = "http://en.wikipedia.org/wiki/Bulgaria#mediaviewer/File:SS.Forty_Martyrs_Church_%28Veliko_Tarnovo%29_E3.jpg";
            string FileName = "SS.Forty_Martyrs_Church_%28Veliko_Tarnovo%29_E3.jpg";
            try
            {
                WebClient webCilend = new WebClient();
                webCilend.DownloadFile(Url, FileName);
                Console.WriteLine("The picture is saved at {0}.", Directory.GetCurrentDirectory());

            }
            catch (NotSupportedException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (WebException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
