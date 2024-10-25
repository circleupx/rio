namespace Rio.Enumerations
{
    public class OtherAmountClaimedSubmitted
    {
        public string Value { get; private set; }
        public string Description { get; private set; }

        public static readonly OtherAmountClaimedSubmitted DeliveryCost = new()
        {
            Value = "01",
            Description = "Delivery cost",
        };

        public static readonly OtherAmountClaimedSubmitted ShippingCost = new OtherAmountClaimedSubmitted()
        {
            Value = "02",
            Description = "Shipping cost",
        };

        public static readonly OtherAmountClaimedSubmitted PostageCost = new OtherAmountClaimedSubmitted()
        {
            Value = "03",
            Description = "Postage cost",
        };

        public static readonly OtherAmountClaimedSubmitted AdministrativeCost = new OtherAmountClaimedSubmitted()
        {
            Value = "04",
            Description = "Administrative cost",
        };

        public static readonly OtherAmountClaimedSubmitted CompoundPreparationCost = new OtherAmountClaimedSubmitted()
        {
            Value = "09",
            Description = "Compound preparation cost",
        };

        public static readonly OtherAmountClaimedSubmitted Other = new OtherAmountClaimedSubmitted()
        {
            Value = "99",
            Description = "Other",
        };
    }
}