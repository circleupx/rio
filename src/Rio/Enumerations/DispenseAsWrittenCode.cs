namespace Rio.Enumerations
{
    public class DispenseAsWrittenCode
    {
        public string Value { get; private set; }
        public string Description { get; private set; }

        public static readonly DispenseAsWrittenCode NoSubstitution = new()
        {
            Value = "0",
            Description = "No Product Selection Indicated",
        };

        public static readonly DispenseAsWrittenCode SubstitutionAllowed = new()
        {
            Value = "1",
            Description = "Substitution Not Allowed by Prescriber",
        };

        public static readonly DispenseAsWrittenCode DispenseAsWritten = new()
        {
            Value = "2",
            Description = "Dispense As Written - Patient selected product dispensed",
        };

        public static readonly DispenseAsWrittenCode SubstitutionAllowedBrand = new()
        {
            Value = "3",
            Description = "Substitution Allowed - Pharmacist selected product dispensed",
        };

        public static readonly DispenseAsWrittenCode SubstitutionAllowedGeneric = new()
        {
            Value = "4",
            Description = "Substitution Allowed - Generic drug not in stock",
        };

        public static readonly DispenseAsWrittenCode SubstitutionAllowedGenericBrand = new()
        {
            Value = "5",
            Description = "Substitution Allowed - Drug dispensed as generic",
        };

        public static readonly DispenseAsWrittenCode SubstitutionAllowedGenericBrandDispenseAsWritten = new()
        {
            Value = "6",
            Description = "Override",
        };

        public static readonly DispenseAsWrittenCode SubstitutionAllowedGenericBrandDispenseAsWrittenPatientSelected = new()
        {
            Value = "7",
            Description = "Substitution Not Allowed - Brand drug mandated by law",
        };

        public static readonly DispenseAsWrittenCode SubstitutionAllowedGenericBrandDispenseAsWrittenPharmacistSelected = new()
        {
            Value = "8",
            Description = "Substitution Allowed - Generic drug not available in marketplace",
        };

        public static readonly DispenseAsWrittenCode SubstitutionAllowedGenericBrandDispenseAsWrittenPatientSelectedPharmacistSelected = new()
        {
            Value = "9",
            Description = "Substitution Allowed - Patient's plan requires branch for product to be dispensed",
        };

    }
}