using System.Configuration;

namespace DDD_Base.Domain
{
    public static class Shared
    {
        public static bool IsFake { get; } = ConfigurationManager.AppSettings["IsFake"] == "1";
    }
}
