using Microsoft.ML.Data;

namespace InfectionRiskAssessment.Controllers
{
    public class Reading
    {
        [LoadColumn(0)] public long RespondentId { get; set; }
        [LoadColumn(1)] public int IsMedical { get; set; }
        [LoadColumn(2)] public int BirthYear { get; set; }
        [LoadColumn(3)] public int Height { get; set; }
        [LoadColumn(4)] public int Weight { get; set; }
        [LoadColumn(5)] public int Place { get; set; }
        [LoadColumn(6)] public string County { get; set; }
        [LoadColumn(7)] public int IsIsolated { get; set; }
        [LoadColumn(8)] public int Sex { get; set; }
        [LoadColumn(9)] public int IsPregnant { get; set; }
        [LoadColumn(10)] public int HasContact { get; set; }
        [LoadColumn(11)] public int DaysAfterContact { get; set; }
        [LoadColumn(12)] public int WasTested { get; set; }
        [LoadColumn(13)] public int IsPositive { get; set; }
        [LoadColumn(14)] public int InfectedAndNotTested { get; set; }
        [LoadColumn(15)] public int PresentState { get; set; }
        [LoadColumn(16)] public int HasFever { get; set; }
        [LoadColumn(17)] public float FeverTemperature { get; set; }
        [LoadColumn(18)] public int IsCoughing { get; set; }
        [LoadColumn(19)] public int IsTired { get; set; }
        [LoadColumn(20)] public int HasHeadache { get; set; }
        [LoadColumn(21)] public int CanBreathNormally { get; set; }
        [LoadColumn(22)] public int HasSoreThroath { get; set; }
        [LoadColumn(23)] public int IsHoarse { get; set; }
        [LoadColumn(24)] public int CanSmell { get; set; }
        [LoadColumn(25)] public int CanTaste { get; set; }
        [LoadColumn(26)] public int HasDiarrhea { get; set; }
        [LoadColumn(27)] public int HasChestPain { get; set; }
        [LoadColumn(28)] public int HasStomachAche { get; set; }
        [LoadColumn(29)] public int HasMusclePain { get; set; }
        [LoadColumn(30)] public int IsConfused { get; set; }
        [LoadColumn(31)] public int HasAppetite { get; set; }
        [LoadColumn(32)] public int OtherIssues { get; set; }
        [LoadColumn(33)] public int HasHealthIssues { get; set; }
        [LoadColumn(34)] public int NeedsHelp { get; set; }
        [LoadColumn(35)] public int HasHelp { get; set; }
        [LoadColumn(36)] public int UsesWheelchair { get; set; }
        [LoadColumn(37)] public int HasIssuesThatLimtActivity { get; set; }
        [LoadColumn(38)] public int HasCardioVascularIssues { get; set; }
        [LoadColumn(39)] public int UsesBloodPressurePills { get; set; }
        [LoadColumn(40)] public int UsesAspirin { get; set; }
        [LoadColumn(41)] public int HasDiabetes { get; set; }
        [LoadColumn(42)] public int HasLungIssues { get; set; }
        [LoadColumn(43)] public int IsSmoking { get; set; }
        [LoadColumn(44)] public int HasLiverIssues { get; set; }
        [LoadColumn(45)] public int HasKidneyIssues { get; set; }
        [LoadColumn(46)] public int IsDoingDialysis { get; set; }
        [LoadColumn(47)] public int HasCancer { get; set; }
        [LoadColumn(48)] public int UsesImmunosuppressivePills { get; set; }
        [LoadColumn(49)] public int UsesAntiInflammatoryPills { get; set; }
        [LoadColumn(50)] public int HasTwin { get; set; }
        [LoadColumn(51)] public int PlaceNow { get; set; }
        [LoadColumn(52)] public int WillReccomand { get; set; }
        [LoadColumn(53)] public int AgreesContact { get; set; }
        [LoadColumn(54)] public string Email { get; set; }
    }
}