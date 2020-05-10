using Microsoft.ML.Data;

namespace InfectionRiskAssessment.Models
{
    public class Reading
    {
        [LoadColumn(0)] public long RespondentId { get; set; }
        [LoadColumn(1)] public float IsMedical { get; set; }
        [LoadColumn(2)] public float BirthYear { get; set; }
        [LoadColumn(3)] public float Height { get; set; }
        [LoadColumn(4)] public float Weight { get; set; }
        [LoadColumn(5)] public float Place { get; set; }
        [LoadColumn(6)] public string County { get; set; }
        [LoadColumn(7)] public float IsIsolated { get; set; }
        [LoadColumn(8)] public float Sex { get; set; }
        [LoadColumn(9)] public float IsPregnant { get; set; }
        [LoadColumn(10)] public float HasContact { get; set; }
        [LoadColumn(11)] public float DaysAfterContact { get; set; }
        [LoadColumn(12)] public float WasTested { get; set; }
        [ColumnName("Label"), LoadColumn(13)] public string Label { get; set; }
        [LoadColumn(14)] public float InfectedAndNotTested { get; set; }
        [LoadColumn(15)] public float PresentState { get; set; }
        [LoadColumn(16)] public float HasFever { get; set; }
        [LoadColumn(17)] public float FeverTemperature { get; set; }
        [LoadColumn(18)] public float IsCoughing { get; set; }
        [LoadColumn(19)] public float IsTired { get; set; }
        [LoadColumn(20)] public float HasHeadache { get; set; }
        [LoadColumn(21)] public float CanBreathNormally { get; set; }
        [LoadColumn(22)] public float HasSoreThroath { get; set; }
        [LoadColumn(23)] public float IsHoarse { get; set; }
        [LoadColumn(24)] public float CanSmell { get; set; }
        [LoadColumn(25)] public float CanTaste { get; set; }
        [LoadColumn(26)] public float HasDiarrhea { get; set; }
        [LoadColumn(27)] public float HasChestPain { get; set; }
        [LoadColumn(28)] public float HasStomachAche { get; set; }
        [LoadColumn(29)] public float HasMusclePain { get; set; }
        [LoadColumn(30)] public float IsConfused { get; set; }
        [LoadColumn(31)] public float HasAppetite { get; set; }
        [LoadColumn(32)] public float OtherIssues { get; set; }
        [LoadColumn(33)] public float HasHealthIssues { get; set; }
        [LoadColumn(34)] public float NeedsHelp { get; set; }
        [LoadColumn(35)] public float HasHelp { get; set; }
        [LoadColumn(36)] public float UsesWheelchair { get; set; }
        [LoadColumn(37)] public float HasIssuesThatLimtActivity { get; set; }
        [LoadColumn(38)] public float HasCardioVascularIssues { get; set; }
        [LoadColumn(39)] public float UsesBloodPressurePills { get; set; }
        [LoadColumn(40)] public float UsesAspirin { get; set; }
        [LoadColumn(41)] public float HasDiabetes { get; set; }
        [LoadColumn(42)] public float HasLungIssues { get; set; }
        [LoadColumn(43)] public float IsSmoking { get; set; }
        [LoadColumn(44)] public float HasLiverIssues { get; set; }
        [LoadColumn(45)] public float HasKidneyIssues { get; set; }
        [LoadColumn(46)] public float IsDoingDialysis { get; set; }
        [LoadColumn(47)] public float HasCancer { get; set; }
        [LoadColumn(48)] public float UsesImmunosuppressivePills { get; set; }
        [LoadColumn(49)] public float UsesAntiInflammatoryPills { get; set; }
        [LoadColumn(50)] public float HasTwin { get; set; }
        [LoadColumn(51)] public float PlaceNow { get; set; }
        [LoadColumn(52)] public float WillReccomand { get; set; }
        [LoadColumn(53)] public float AgreesContact { get; set; }
        [LoadColumn(54)] public string Email { get; set; }
    }
}