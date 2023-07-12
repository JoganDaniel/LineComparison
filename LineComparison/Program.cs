using System;

namespace LineComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem");
            Operation operation1 = new Operation(2,1,4,3);
            double line1 = operation1.CalculateLength();
            Operation operation2 = new Operation(2,1,4,3);
            double line2 = operation2.CalculateLength();

            if(line1.Equals(line2))
            {
                Console.WriteLine("The lines are equal");
            }
            else
            {
                Console.WriteLine("The lines are not equal");
            }
        }
    }
}