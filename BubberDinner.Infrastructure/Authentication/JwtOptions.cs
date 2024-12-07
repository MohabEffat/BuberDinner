namespace BubberDinner.Infrastructure.Authentication
{
    public class JwtOptions
    {
        public const string sectionName = "JWT";
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiryInMins { get; set; }

    }
}
