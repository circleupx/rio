namespace Rio.Enumerations
{
    public class BenefitStageCode
    {
        public string Value { get; private set; }
        public string Description { get; private set; }

        public static readonly BenefitStageCode Deductible = new()
        {
            Value = "01",
            Description = "Deductible",
        };

        public static readonly BenefitStageCode InitialBenefit = new()
        {
            Value = "02",
            Description = "Initial Benefit",
        };

        public static readonly BenefitStageCode CoverageGap = new()
        {
            Value = "03",
            Description = "Coverage Gap",
        };

        public static readonly BenefitStageCode CatastrophicCoverage = new()
        {
            Value = "04",
            Description = "Catastrophic Coverage",
        };
    }
}