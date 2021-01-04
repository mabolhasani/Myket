namespace Myket.Models
{
    public class VerifyPurchaseResult
    {
        public bool Successful { get; }

        public Error Error { get; }

        public Result Result { get; }

        public VerifyPurchaseResult(Result result)
        {
            Successful = true;
            Error = default;
            Result = result;
        }

        public VerifyPurchaseResult(Error error = default)
        {
            Successful = false;
            Error = error;
            Result = default;
        }
    }
}
