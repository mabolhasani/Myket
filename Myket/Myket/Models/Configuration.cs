namespace Myket.Models
{
    public class Configuration
    {
        public string AccessToken { get; }

        public string PackageName { get; }

        public Configuration(string accessToken, string packageName)
        {
            AccessToken = accessToken;
            PackageName = packageName;
        }
    }
}
