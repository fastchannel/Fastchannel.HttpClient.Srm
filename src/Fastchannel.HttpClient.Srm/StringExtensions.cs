using System.Linq;

namespace Fastchannel.HttpClient.Srm
{
    public static class StringExtensions
    {
        public static string GetNumbers(this string value)
        {
            return !string.IsNullOrWhiteSpace(value)
                ? new string(value.Where(char.IsDigit).ToArray())
                : string.Empty;
        }
    }
}