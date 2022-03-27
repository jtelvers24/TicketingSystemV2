using System;

using System.IO;
using System.Linq;

namespace TicketingSystemV2
{
    class Program{
        static void Main(string[] args)
        {
                        string path = Directory.GetCurrentDirectory() + "//nlog.config";

            // create instance of Logger
            var logger = NLog.Web.NLogBuilder.ConfigureNLog(path).GetCurrentClassLogger();

            // log sample messages
            logger.Trace("Sample trace message");
            logger.Debug("Sample debug message");
            logger.Info("Sample informational message");
            logger.Warn("Sample warning message");
            logger.Error("Sample error message");
            logger.Fatal("Sample fatal error message");
            string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read Tickets.");
                Console.WriteLine("2) Create Ticket.");
                Console.WriteLine("3) Read Enhancements.");
                Console.WriteLine("4) Create Enhancements.");
                Console.WriteLine("5) Read Tasks.");
                Console.WriteLine("6) Create Task.");
                Console.WriteLine("7) Search for Ticket");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                   ReadFile runReadFile = new ReadFile();
                   runReadFile.RunReadFile();
                }
                else if (choice == "2")
                {
                  WriteFile runWriteFile = new WriteFile();
                  runWriteFile.RunWriteFile();
                }
                else if (choice == "3"){
                   ReadEnhancements runReadFile = new ReadEnhancements();
                   runReadFile.RunReadFile(); 
                }
                else if (choice == "4"){
                    WriteEnhancments runWriteFile = new WriteEnhancments();
                  runWriteFile.RunWriteFile();
                }
                 else if (choice == "5"){
                    ReadTask runReadFile = new ReadTask();
                   runReadFile.RunReadFile(); 
                }
                 else if (choice == "6"){
                    WriteTask runWriteFile = new WriteTask();
                  runWriteFile.RunWriteFile();
                }
                else if (choice == "7"){
                    TicketSearch TicketSearchOperation = new TicketSearch();
                    TicketSearchOperation.TicketSearchOperation();
                }
                
            } while (choice == "1" || choice == "2");
        }
        }
    }

    class TicketSearch
    {
        public void TicketSearchOperation(){

            

            





                string task = "Task.csv";
                string ticket = "tickets.csv";
                string enhancement = "Enhancements.csv";
                string search = Console.ReadLine();
                                   
                 if (File.Exists(task))
                    {
                        StreamReader sr = new StreamReader(task);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] arr = line.Split('|');
                            var myLinqQuery = from arrs in arr[3]
                                                where arr.Contains(search)
                                                select arrs;

                            foreach(var arrs in myLinqQuery)
                            Console.Write(arrs);
                        }
                        sr.Close();
                    }
                    


        }
    }
    class WriteTask
    {
        public void RunWriteFile()
        {
            string choice = " ";
            StreamWriter sw = new StreamWriter("Task.csv", append: true);
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
                     Console.WriteLine("ProjectName");
                        // save the course grade
                    string ProjectName = Console.ReadLine();
                     Console.WriteLine("Due Date");
                        // save the course grade
                    string dueDate = Console.ReadLine();


                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}", i, summary, status, priority, submitter, assigned, watching, ProjectName, dueDate);
                    
                    sw.Close();
                }while (choice == "1" || choice == "2");
      

        }
    }
    class ReadTask
    {
        public void RunReadFile(){
            string file = "Task.csv";
               // read data from file
                    if (File.Exists(file))
                    {
                        // accumulators needed for GPA
                    
                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|');
                            // display array data
                            Console.WriteLine(arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6] + "," + arr[7] + "," + arr[8]);
                           
                        }
                        sr.Close();
                        
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
        
        }
    }
    class WriteEnhancments
    {
        public async void RunWriteFile()
        {
            string choice = " ";
            StreamWriter sw = new StreamWriter("Enhancements.csv", append: true);
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
                    string watching = Console.ReadLine();
                    Console.WriteLine("Software");
                    string software = Console.ReadLine();
                    Console.WriteLine("Cost");
                    string cost = Console.ReadLine();
                    Console.WriteLine("Reason");
                    string reason = Console.ReadLine();
                    Console.WriteLine("Estimate");
                    string estimate = Console.ReadLine();

                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}", i, summary, status, priority, submitter, assigned, watching,software,cost,reason,estimate);
                    
                    sw.Close();
                }while (choice == "1" || choice == "2");
      

        }
    }

    class ReadEnhancements
    {
public void RunReadFile(){
            string file = "Enhancements.csv";
               // read data from file
                    if (File.Exists(file))
                    {
                        // accumulators needed for GPA
                    
                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|');
                            // display array data
                            Console.WriteLine(arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6] + "," + arr[7] + "," + arr[8] + "," + arr[9] + "," + arr[10]);
                           
                        }
                        sr.Close();
                        
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
        
        }

    }
    class ReadFile
    {
       public string hello(){
           return "hello";
       }
        public void RunReadFile(){
            string file = "tickets.csv";
               // read data from file
                    if (File.Exists(file))
                    {
                        // accumulators needed for GPA
                    
                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|');
                            // display array data
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
        public void RunWriteFile()
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
      

        }
    
}
