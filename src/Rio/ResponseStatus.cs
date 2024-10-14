namespace Rio
{
    public class ResponseStatusResult
    {
        private char code;
        private string description;

        public static readonly ResponseStatusResult Approved = new()
        {
            code = 'A',
            description = "Approved",
        };

        public static readonly ResponseStatusResult Benefit = new()
        {
            code = 'B',
            description = "Benefit",
        };

        public static readonly ResponseStatusResult Captured = new()
        {
            code = 'C',
            description = "Captured",
        };

        public static readonly ResponseStatusResult DuplicatePaid = new()
        {
            code = 'D',
            description = "Duplicate of Paid",
        };

        public static readonly ResponseStatusResult PriorAuthorizationDeferred = new()
        {
            code = 'F',
            description = "Prior Authorization Deferred",
        };

        public static readonly ResponseStatusResult Paid = new()
        {
            code = 'P',
            description = "Paid",
        };

        public static readonly ResponseStatusResult DuplicateOfCapture = new()
        {
            code = 'Q',
            description = "Duplicate of Capture",
        };

        public static readonly ResponseStatusResult Rejected = new()
        {
            code = 'R',
            description = "Rejected",
        };

        public static readonly ResponseStatusResult DuplicateOfApprove = new()
        {
            code = 'S',
            description = "Duplicate of Approve",
        };
    }
}