namespace Rio.Enumerations
{
    public class SubmissionClarificationCode
    {
        public string Value { get; private set; }
        public string Description { get; private set; }

        public static readonly SubmissionClarificationCode NoOverride = new SubmissionClarificationCode()
        {
            Value = "1",
            Description = "No Override",
        };

        public static readonly SubmissionClarificationCode OtherOverride = new SubmissionClarificationCode()
        {
            Value = "2",
            Description = "Other Override",
        };

        public static readonly SubmissionClarificationCode VacationSupply = new SubmissionClarificationCode()
        {
            Value = "3",
            Description = "Vacation Supply",
        };

        public static readonly SubmissionClarificationCode LostPrescription = new SubmissionClarificationCode()
        {
            Value = "4",
            Description = "Lost Prescription",
        };

        public static readonly SubmissionClarificationCode TherapyChange = new SubmissionClarificationCode()
        {
            Value = "5",
            Description = "Therapy Change",
        };

        public static readonly SubmissionClarificationCode StarterDose = new SubmissionClarificationCode()
        {
            Value = "6",
            Description = "Starter Dose",
        };

        public static readonly SubmissionClarificationCode MedicallyNecessary = new SubmissionClarificationCode()
        {
            Value = "7",
            Description = "Medically Necessary",
        };

        public static readonly SubmissionClarificationCode ProcessCompoundApprovedIngredients = new SubmissionClarificationCode()
        {
            Value = "8",
            Description = "Process Compound Approved Ingredients",
        };

        public static readonly SubmissionClarificationCode Encounters = new SubmissionClarificationCode()
        {
            Value = "9",
            Description = "Encounters",
        };

        public static readonly SubmissionClarificationCode MeetsPlanLimitations = new SubmissionClarificationCode()
        {
            Value = "10",
            Description = "Meets Plan Limitations",
        };

        public static readonly SubmissionClarificationCode CertificationOnFile = new SubmissionClarificationCode()
        {
            Value = "11",
            Description = "Certification on File",
        };

        public static readonly SubmissionClarificationCode DMEReplacementIndicator = new SubmissionClarificationCode()
        {
            Value = "12",
            Description = "DME Replacement Indicator",
        };

        public static readonly SubmissionClarificationCode EmergencyAssistanceRequest = new SubmissionClarificationCode()
        {
            Value = "13",
            Description = "Emergency Assistance Request",
        };

        public static readonly SubmissionClarificationCode LongTermLeaveOfAbsence = new SubmissionClarificationCode()
        {
            Value = "14",
            Description = "Long Term Leave of Absence",
        };

        public static readonly SubmissionClarificationCode LostTermCareReplacementMedication = new SubmissionClarificationCode()
        {
            Value = "15",
            Description = "Long Term Care Replacement Medication",
        };

        public static readonly SubmissionClarificationCode LostTermCareEmergencyBotKit = new SubmissionClarificationCode()
        {
            Value = "16",
            Description = "Long Term Care Emergency Bot Kit",
        };

        public static readonly SubmissionClarificationCode LongTermCareEmegencyReminder = new SubmissionClarificationCode()
        {
            Value = "17",
            Description = "Long Term Care Emergency Reminder",
        };

        public static readonly SubmissionClarificationCode LongTermCarePatientAdmit = new SubmissionClarificationCode()
        {
            Value = "18",
            Description = "Long Term Care Patient Admit",
        };

        public static readonly SubmissionClarificationCode SplitBilling = new SubmissionClarificationCode()
        {
            Value = "19",
            Description = "Split Billing",
        };

        public static readonly SubmissionClarificationCode _340_B = new SubmissionClarificationCode()
        {
            Value = "20",
            Description = "340B",
        };

        public static readonly SubmissionClarificationCode Other = new SubmissionClarificationCode()
        {
            Value = "21",
            Description = "Other",
        };
    }
}