using InfectionRiskAssessment.Models;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfectionRiskAssessment.MachineLearning
{
    public static class Predictor
    {
        public static PredictionModel Predict(ITransformer model, Reading reading)
        {
            var mlContext = new MLContext();
            var predictor = mlContext.Model.CreatePredictionEngine<Reading, PredictionModel>(model);
            var predicted = predictor.Predict(reading);

            return predicted;
        }
    }
}
