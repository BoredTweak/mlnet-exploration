
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace SampleClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args?.Length < 3) 
            {
                Console.WriteLine("Please specify cap_shape, cap_color and odor");
                return;
            }

            // Create single instance of sample data from first line of dataset for model input
            SampleClassification.ModelInput sampleData = new SampleClassification.ModelInput()
            {
                Cap_shape = args[0],
                Cap_color = args[1],
                Odor = args[2],
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = SampleClassification.Predict(sampleData);

            Console.WriteLine($"\n\nPredicted Class: {predictionResult.PredictedLabel}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}