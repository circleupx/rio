namespace Rio.Enumerations
{
    public class PatientIdentityCode
    {
        public string Value { get; private set; }
        public string Description { get; private set; }

        public static readonly PatientIdentityCode SocialSecurity = new PatientIdentityCode()
        {
            Value = "01",
            Description = "Social Security Number",
        };

        public static readonly PatientIdentityCode FacilityId = new PatientIdentityCode()
        {
            Value = "1J",
            Description = "Facility ID",
        };

        public static readonly PatientIdentityCode DriversLicense = new PatientIdentityCode()
        {
            Value = "02",
            Description = "Driver's License Number",
        };

        public static readonly PatientIdentityCode MilitaryId = new PatientIdentityCode()
        {
            Value = "03",
            Description = "US Military Id",
        };

        public static readonly PatientIdentityCode NonSocialSecurityBase = new PatientIdentityCode()
        {
            Value = "04",
            Description = "Non-Social Security Number",
        };

        public static readonly PatientIdentityCode SocialSecurityBasedId = new PatientIdentityCode()
        {
            Value = "05",
            Description = "Social Security Based ID",
        };

        public static readonly PatientIdentityCode Medicaid = new PatientIdentityCode()
        {
            Value = "06",
            Description = "Medicaid Number",
        };

        public static readonly PatientIdentityCode StateIssuedId = new PatientIdentityCode()
        {
            Value = "07",
            Description = "State Issued ID",
        };

        public static readonly PatientIdentityCode PassportId = new PatientIdentityCode()
        {
            Value = "08",
            Description = "Passport Id",
        };

        public static readonly PatientIdentityCode MedicareId = new PatientIdentityCode()
        {
            Value = "09",
            Description = "Medicare HIC Number",
        };

        public static readonly PatientIdentityCode EmployerAssignedId = new PatientIdentityCode()
        {
            Value = "10",
            Description = "Employer Assigned Number",
        };

        public static readonly PatientIdentityCode PayerAssignedId = new PatientIdentityCode()
        {
            Value = "11",
            Description = "Payer Assigned Number",
        };

        public static readonly PatientIdentityCode AlienNumber = new PatientIdentityCode()
        {
            Value = "12",
            Description = "Alien Number",
        };

        public static readonly PatientIdentityCode StudentVisaNumber = new PatientIdentityCode()
        {
            Value = "13",
            Description = "Student Visa Number",
        };

        public static readonly PatientIdentityCode NationalHealthPlanId = new PatientIdentityCode()
        {
            Value = "14",
            Description = "Idian Tribe Id",
        };

        public static readonly PatientIdentityCode Other = new PatientIdentityCode()
        {
            Value = "15",
            Description = "Other",
        };
    }
}