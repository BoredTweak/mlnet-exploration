// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace SampleRegression.ConsoleApp
{
    public partial class SampleRegression
    {
        /// <summary>
        /// model input class for SampleRegression.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"distance")]
            public float Distance { get; set; }

            [ColumnName(@"cab_type")]
            public string Cab_type { get; set; }

            [ColumnName(@"time_stamp")]
            public float Time_stamp { get; set; }

            [ColumnName(@"destination")]
            public string Destination { get; set; }

            [ColumnName(@"source")]
            public string Source { get; set; }

            [ColumnName(@"price")]
            public float Price { get; set; }

            [ColumnName(@"surge_multiplier")]
            public float Surge_multiplier { get; set; }

            [ColumnName(@"id")]
            public string Id { get; set; }

            [ColumnName(@"product_id")]
            public string Product_id { get; set; }

            [ColumnName(@"name")]
            public string Name { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for SampleRegression.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"distance")]
            public float Distance { get; set; }

            [ColumnName(@"cab_type")]
            public float[] Cab_type { get; set; }

            [ColumnName(@"time_stamp")]
            public float Time_stamp { get; set; }

            [ColumnName(@"destination")]
            public float[] Destination { get; set; }

            [ColumnName(@"source")]
            public float[] Source { get; set; }

            [ColumnName(@"price")]
            public float Price { get; set; }

            [ColumnName(@"surge_multiplier")]
            public float Surge_multiplier { get; set; }

            [ColumnName(@"id")]
            public float[] Id { get; set; }

            [ColumnName(@"product_id")]
            public float[] Product_id { get; set; }

            [ColumnName(@"name")]
            public float[] Name { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("SampleRegression.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}