﻿using System;
using System.IO;

namespace TicketingSystemV2
{
    class Program{
        static void Main(string[] args)
        {
            string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read Tickets.");
                Console.WriteLine("2) Create Ticket.");
                Console.WriteLine("1) Read Enhancements.");
                Console.WriteLine("2) Create Enhancements.");
                Console.WriteLine("1) Read Tasks.");
                Console.WriteLine("2) Create Task.");
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
            } while (choice == "1" || choice == "2");
        }
        }
    }
    class WriteEnhancments
    {
        public void RunWriteFile()
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
                        // save the course grade
                    string watching = Console.ReadLine();
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", i, summary, status, priority, submitter, assigned, watching);
                    
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
