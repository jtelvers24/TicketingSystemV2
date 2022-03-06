using System;
using System.IO;

namespace TicketingSystemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class ReadFile
    {
    static void Main(string[] args)
    {
        
        if (File.Exists("tickets.csv"))
            {
            StreamReader sr = new StreamReader("tickets.csv");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] arr = line.Split('|');
                    Console.WriteLine(arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6]);
                }
                sr.Close(); 
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
        }
    }

}
