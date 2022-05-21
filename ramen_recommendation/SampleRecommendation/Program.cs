
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace SampleRecommendation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args?.Length < 2) 
            {
                Console.WriteLine("Please specify style and country");
                return;
            }

            // Create single instance of sample data from first line of dataset for model input
            SampleRecommendation.ModelInput sampleData = new SampleRecommendation.ModelInput()
            {
                User = 1,
                Style = args[0],
                Country = args[1],
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = SampleRecommendation.Predict(sampleData);

            Console.WriteLine($"\n\nPredicted Stars: {predictionResult.Score}\n\n");
            Console.WriteLine($"\n\nPredicted Brand: {predictionResult.Brand}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
