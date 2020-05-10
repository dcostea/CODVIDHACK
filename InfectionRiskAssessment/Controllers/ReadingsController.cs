using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InfectionRiskAssessment.Models;
using Microsoft.ML;
using InfectionRiskAssessment.MachineLearning;
using MathNet.Numerics.Statistics;

namespace InfectionRiskAssessment.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingsController : ControllerBase
    {
        private readonly ILogger<ReadingsController> _logger;
        public static readonly IDataView _dataset;
        public static MLContext _mlContext;
        private static ITransformer _model;

        static ReadingsController()
        {
            _mlContext = new MLContext();
            const string DATASET_PATH = "./dataset-fk.csv";
            _dataset = _mlContext.Data.LoadFromTextFile<Reading>(
                path: DATASET_PATH,
                hasHeader: true,
                separatorChar: ',');
        }

        public ReadingsController(ILogger<ReadingsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var readings = _mlContext.Data.CreateEnumerable<Reading>(_dataset, true);

            return Ok(readings);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var readings = _mlContext.Data.CreateEnumerable<Reading>(_dataset, true);

            if (id == 0)
            {
                return BadRequest($"Id cannot be zero. Try {readings.First().RespondentId} for example.");
            }

            try
            {
                return Ok(readings.Single(r => r.RespondentId == id));
            }
            catch (Exception)
            {
                return NotFound($"Id {id} not found. Try {readings.First().RespondentId} for example.");
            }
        }

        [HttpPost("train")]
        public IActionResult Train()
        {
            var readings = _mlContext.Data.CreateEnumerable<Reading>(_dataset, true);
            var cleaned = readings.Where(r => r.WasTested == 1);
            var dataset = _mlContext.Data.LoadFromEnumerable<Reading>(cleaned);
            _model = Trainer.Train(_dataset);

            //    new Graph.Box { y = featuresTemperatures, name = "Temperature" },

            ////"IsMedical",
            ////"BirthYear",
            ////"IsIsolated",
            ////"Sex",
            ////"IsPregnant",
            ////"HasContact",
            ////"DaysAfterContact",
            ////"PresentState",
            ////"HasFever",
            ////"FeverTemperature",
            ////"IsCoughing",
            ////"IsTired",
            ////"HasHeadache",
            ////"CanBreathNormally",
            ////"HasSoreThroath",
            ////"IsHoarse",
            ////"CanSmell",
            ////"CanTaste",
            ////"HasDiarrhea",
            ////"HasChestPain",
            ////"HasStomachAche",
            ////"HasMusclePain",
            ////"IsConfused",
            ////"HasAppetite",
            ////"OtherIssues",
            ////"HasHealthIssues",
            ////"NeedsHelp",
            ////"HasHelp",
            ////"UsesWheelchair",
            ////"HasIssuesThatLimtActivity",
            ////"HasCardioVascularIssues",
            ////"UsesBloodPressurePills",
            ////"UsesAspirin",
            ////"HasDiabetes",
            ////"HasLungIssues",
            ////"IsSmoking",
            ////"HasLiverIssues",
            ////"HasKidneyIssues",
            ////"IsDoingDialysis",
            ////"HasCancer",
            ////"UsesImmunosuppressivePills",
            ////"UsesAntiInflammatoryPills",
            ////"HasTwin",
            ////"PlaceNow",


            //var value = Correlation.Pearson(new double[] { 0, 3, 1 }, new double[] { 0, 7, 0 });

            return Ok();


        }

        [HttpPost("predict")]
        public IActionResult Predict(Reading reading)
        {
            var result = Predictor.Predict(_model, reading);

            return Ok($"{result.PredictedLabel} [{string.Join(",", result.Score)}]");
        }
    }
}
