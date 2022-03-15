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
            double dailyRate;
            int noOfDays;
            ReadData(out dailyRate, out noOfDays);
            writeFee(calculateFee(dailyRate, noOfDays));
        }

        private void ReadData(out double dailyRate, out int noOfDays)
        {
            dailyRate = readDouble("Enter your daily rate: ");
            noOfDays = readInt("Enter the number of days: ");
        }

        private void writeFee(double v) => Console.WriteLine($"The consultant's fee is {v * 1.1}");
        
        private double calculateFee(double dailyRate, int noOfDays) => dailyRate * noOfDays;

        private int readInt(string prompt)
        {
            Console.Write(prompt);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readDouble(string propmt)
        {
            Console.Write(propmt);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}
