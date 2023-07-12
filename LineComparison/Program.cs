using System;

namespace LineComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem");
            Operation operation = new Operation(2,1,4,3);
            operation.CalculateLength();
        }
    }
}