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

    class WriteFile
    {
        static void Main(string[] args)
        {
            string choice = " ";
            StreamWriter sw = new StreamWriter("tickets.csv", append: true);
                for (int i = 0; i < 7; i++)
                {
                    
                    int ticketid = 0;
                    ticketid +=1;
                                            // ask a question
                     Console.WriteLine("Enter a ticket (Y/N)?");
                        // input the response
                    string resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                    if (resp != "Y") { break; }
                        // prompt for course name
                    Console.WriteLine("Enter Summary");
                        // save the course name
                    string summary = Console.ReadLine();
                        // prompt for course grade
                     Console.WriteLine("Status");
                        // save the course grade
                        string status = Console.ReadLine();
                    Console.WriteLine("Priority");
                        // save the course grade
                    string priority = Console.ReadLine();
                     Console.WriteLine("Submitter");
                        // save the course grade
                    string submitter = Console.ReadLine();
                    Console.WriteLine("Assigned");
                        // save the course grade
                    string assigned = Console.ReadLine();
                    Console.WriteLine("Watching");
                        // save the course grade
                    string watching = Console.ReadLine();
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", i, summary, status, priority, submitter, assigned, watching);
                    
                    sw.Close();
                }while (choice == "1" || choice == "2");
      

        }}
    
}
