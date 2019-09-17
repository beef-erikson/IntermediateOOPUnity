using System;
using System.IO;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = null;
            Console.WriteLine();
            
            // Outputs file
            try
            {
                // Opens file
                input = File.OpenText("Haiku.txt");

                string line = input.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = input.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                input.Close();
            }
            Console.WriteLine();
            
            // Outputs odd lines (lines 1 and 3 - will read any number of odd lines though)
            try
            {
                // open file
                input = File.OpenText("Haiku.txt");

                // writes lines to a list
                List<string> lines = new List<string>();
                
                string inputline = input.ReadLine();
                lines.Add(inputline);
               
                while (inputline != null)
                {
                    input.ReadLine();
                    
                    inputline = input.ReadLine();
                    lines.Add(inputline);
                }
                
                // outputs odd lines
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                input.Close();
            }
        }
    }
}