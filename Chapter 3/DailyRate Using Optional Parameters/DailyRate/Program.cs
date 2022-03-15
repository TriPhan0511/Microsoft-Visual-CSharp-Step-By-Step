using System;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            //double fee = CalculateFee();
            //double fee = CalculateFee(650.0);
            //double fee = CalculateFee(500.0, 3);
            //double fee = CalculateFee(dailyRate: 375.0);
            //double fee = CalculateFee(noOfDays: 4);
            double fee = CalculateFee(theDailyRate: 375.0);
            Console.WriteLine($"Fee is {fee}");
        }

        //private double CalculateFee(double dailyRate = 500.0, int noOfDays = 1)
        private double CalculateFee(double theDailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("CalculateFee using two optional parameters.");
            return theDailyRate * noOfDays;
        }

        private double CalculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("CalculateFee using one optional parameter.");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }

        private double CalculateFee()
        {
            Console.WriteLine("CalculateFee using hardcoded values.");
            double dailyRate = 400.0;
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }
    }
}
