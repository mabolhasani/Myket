namespace Myket.Models
{
    public class VerifyPurchaseResult
    {
        public bool Successful { get; }

        public Error Error { get; }

        public PurchaseResult PurchaseResult { get; }

        public VerifyPurchaseResult(PurchaseResult result)
        {
            Successful = true;
            Error = default;
            PurchaseResult = result;
        }

        public VerifyPurchaseResult(Error error = default)
        {
            Successful = false;
            Error = error;
            PurchaseResult = default;
        }
    }
}
