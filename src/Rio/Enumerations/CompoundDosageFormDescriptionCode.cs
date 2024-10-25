namespace Rio.Enumerations
{
    public class CompoundDosageFormDescriptionCode
    {
        public string Value { get; private set; }
        public string Description { get; private set; }

        public static readonly CompoundDosageFormDescriptionCode NotSpecified = new()
        {
            Value = "",
            Description = "Not Specified",
        };

        public static readonly CompoundDosageFormDescriptionCode Capsule = new()
        {
            Value = "01",
            Description = "Capsule",
        };

        public static readonly CompoundDosageFormDescriptionCode Ointment = new()
        {
            Value = "02",
            Description = "Ointment",
        };

        public static readonly CompoundDosageFormDescriptionCode Cream = new()
        {
            Value = "03",
            Description = "Cream",
        };

        public static readonly CompoundDosageFormDescriptionCode Suppository = new()
        {
            Value = "04",
            Description = "Suppository",
        };

        public static readonly CompoundDosageFormDescriptionCode Poweder = new()
        {
            Value = "05",
            Description = "Powder",
        };

        public static readonly CompoundDosageFormDescriptionCode Emulsion = new()
        {
            Value = "06",
            Description = "Emulsion",
        };

        public static readonly CompoundDosageFormDescriptionCode Liquid = new()
        {
            Value = "07",
            Description = "Liquid",
        };

        public static readonly CompoundDosageFormDescriptionCode Tablet = new()
        {
            Value = "10",
            Description = "Tablet",
        };

        public static readonly CompoundDosageFormDescriptionCode Solution = new()
        {
            Value = "11",
            Description = "Solution",
        };

        public static readonly CompoundDosageFormDescriptionCode Suspension = new()
        {
            Value = "12",
            Description = "Suspension",
        };

        public static readonly CompoundDosageFormDescriptionCode Lotion = new()
        {
            Value = "13",
            Description = "Lotion",
        };

        public static readonly CompoundDosageFormDescriptionCode Shampoo = new()
        {
            Value = "14",
            Description = "Shampoo",
        };

        public static readonly CompoundDosageFormDescriptionCode Elixir = new()
        {
            Value = "15",
            Description = "Elixir",
        };

        public static readonly CompoundDosageFormDescriptionCode Syrup = new()
        {
            Value = "16",
            Description = "Syrup",
        };
    }
}