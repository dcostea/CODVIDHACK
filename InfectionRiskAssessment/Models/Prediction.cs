using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfectionRiskAssessment.Models
{
    public class PredictionModel
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabel;

        [ColumnName("Score")]
        public float[] Score;
    }
}
