using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter OurStream;
            OurStream = File.CreateText(@"C:\temp\text.txt");
            OurStream.WriteLine("This text is for task scheduler demo test file created on at : " + DateTime.Now);
            OurStream.Close();
            Console.WriteLine("File Created successfully!");

            string logFilePath = @"C:\temp\log.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine("Logging at " + DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while logging: {ex.Message}");
            }
        }
    }
}