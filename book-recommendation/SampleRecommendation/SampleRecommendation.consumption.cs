// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace SampleRecommendation.ConsoleApp
{
    public partial class SampleRecommendation
    {
        /// <summary>
        /// model input class for SampleRecommendation.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"User-ID")]
            public float User_ID { get; set; }

            [ColumnName(@"ISBN")]
            public string ISBN { get; set; }

            [ColumnName(@"Book-Rating")]
            public float Book_Rating { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for SampleRecommendation.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"User-ID")]
            public uint User_ID { get; set; }

            [ColumnName(@"ISBN")]
            public uint ISBN { get; set; }

            [ColumnName(@"Book-Rating")]
            public float Book_Rating { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("SampleRecommendation.zip");

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