using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.ML;
using InfectionRiskAssessment.MachineLearning;

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
        [Obsolete]
        public IActionResult GetAll()
        {
            var readings = _mlContext.Data.CreateEnumerable<Reading>(_dataset, true);

            return Ok(readings);
        }

        [HttpGet("{id}")]
        [Obsolete]
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
        [Obsolete]
        public IActionResult Train()
        {
            var readings = _mlContext.Data.CreateEnumerable<Reading>(_dataset, true);
            var cleaned = readings.Where(r => r.WasTested == 1);
            var dataset = _mlContext.Data.LoadFromEnumerable<Reading>(cleaned);
            _model = Trainer.Train(_dataset);

            return Ok("Model is created! Proceed to predictions.");
        }

        [HttpPost("predict")]
        public IActionResult TrainAndPredict(Reading reading)
        {
            var readings = _mlContext.Data.CreateEnumerable<Reading>(_dataset, true);
            var cleaned = readings.Where(r => r.WasTested == 1);
            var dataset = _mlContext.Data.LoadFromEnumerable<Reading>(cleaned);
            _model = Trainer.Train(_dataset);
            var result = Predictor.Predict(_model, reading);

            return Ok(result);
        }
    }
}
