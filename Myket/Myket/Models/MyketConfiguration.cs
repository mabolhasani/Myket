namespace Myket.Models
{
    public class MyketConfiguration
    {
        public string AccessToken { get; }

        public string PackageName { get; }

        public MyketConfiguration(string accessToken, string packageName)
        {
            AccessToken = accessToken;
            PackageName = packageName;
        }
    }
}
