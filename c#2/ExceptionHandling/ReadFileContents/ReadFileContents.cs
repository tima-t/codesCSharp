using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("enter  full path to the file: ");
        string filePath = Console.ReadLine();
        try
        {
            Console.WriteLine(File.ReadAllText(filePath));
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path or file name");
        }
     
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found");
        }
       
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
    }
}



