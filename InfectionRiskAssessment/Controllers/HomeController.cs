using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InfectionRiskAssessment.Models;
using Microsoft.ML;

namespace InfectionRiskAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly IEnumerable<Reading> Readings;

        static HomeController()
        {
            var mlContext = new MLContext();
            const string DATASET_PATH = "./dataset.csv";

            IDataView data = mlContext.Data.LoadFromTextFile<Reading>(
                path: DATASET_PATH,
                hasHeader: true,
                separatorChar: ',');

            Readings = mlContext.Data.CreateEnumerable<Reading>(data, true);
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(Readings);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            if (id == 0)
            {
                return BadRequest($"Id cannot be zero. Try {Readings.First().RespondentId} for example.");
            }

            try
            {
                return Ok(Readings.Single(r => r.RespondentId == id));
            }
            catch (Exception)
            {
                return NotFound($"Id {id} not found. Try {Readings.First().RespondentId} for example.");
            }
        }

        [HttpPost("predict")]
        public IActionResult Predict(Reading reading)
        {
            return Ok();
        }
    }
}
