using InfectionRiskAssessment.Models;
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfectionRiskAssessment.MachineLearning
{
    public static class Trainer
    {
        public static ITransformer Train(IDataView dataset)
        {
            var _mlContext = new MLContext();

            var featureColumns = new string[]
            {
                //"IsMedical",
                //"BirthYear",
                //"IsIsolated",
                //"Sex",
                //"IsPregnant",
                //"HasContact",
                //"DaysAfterContact",
                //"PresentState",
                "HasFever",
                //"FeverTemperature",
                "IsCoughing",
                "IsTired",
                "HasHeadache",
                "CanBreathNormally",
                "HasSoreThroath",
                "IsHoarse",
                "CanSmell",
                "CanTaste",
                "HasDiarrhea",
                "HasChestPain",
                "HasStomachAche",
                "HasMusclePain",
                "IsConfused",
                "HasAppetite",
                //"OtherIssues",
                //"HasHealthIssues",
                //"NeedsHelp",
                //"HasHelp",
                //"UsesWheelchair",
                //"HasIssuesThatLimtActivity",
                //"HasCardioVascularIssues",
                //"UsesBloodPressurePills",
                //"UsesAspirin",
                //"HasDiabetes",
                //"HasLungIssues",
                //"IsSmoking",
                //"HasLiverIssues",
                //"HasKidneyIssues",
                //"IsDoingDialysis",
                //"HasCancer",
                //"UsesImmunosuppressivePills",
                //"UsesAntiInflammatoryPills",
                //"HasTwin"
                //"PlaceNow"
            };

            //var featureColumns = new string[]
            //{
            //    "BirthYear",
            //    "IsIsolated",
            //    "Sex",
            //    "IsPregnant"
            //};


            //const string DATASET_PATH = "./dataset.csv";
            //var dataset = _mlContext.Data.LoadFromTextFile<Reading>(
            //    path: DATASET_PATH,
            //    hasHeader: true,
            //    separatorChar: ',');

            //var shuffledData = _mlContext.Data.ShuffleRows(dataset, seed: 2020);
            //var split = _mlContext.Data.TrainTestSplit(shuffledData, testFraction: 0.2);
            //var trainingData = split.TrainSet;
            //var testingData = split.TestSet;

            var trainingData = dataset;

            var preprocessingPipeline = _mlContext.Transforms.Conversion.MapValueToKey("Label", "Label")
                .Append(_mlContext.Transforms.Concatenate("Features", featureColumns))
                .Append(_mlContext.Transforms.NormalizeMinMax("Features", "Features"))
                .AppendCacheCheckpoint(_mlContext);

            var trainer = _mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(labelColumnName: "Label", featureColumnName: "Features")
                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel", "PredictedLabel"));

            var trainingPipeline = preprocessingPipeline.Append(trainer);

            return trainingPipeline.Fit(trainingData);
        }
    }
}
