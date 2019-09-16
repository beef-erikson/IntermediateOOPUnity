using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a score (-32,768 to 32,767): ");
                short input = short.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use the proper format (integers only)");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Out of integer limit - Enter a score in the bounds.");
            }
            finally
            {
                Console.WriteLine("Program run.");
            }
        }
    }
}