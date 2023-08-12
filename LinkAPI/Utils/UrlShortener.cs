using LinkAPI.Interfaces;

namespace LinkAPI.Utils
{
    public class UrlShortener : IUrlShortener
    {
        public static string GetShort()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@az";
            var randomStr = new string(Enumerable.Repeat(chars, 8)
                .Select(str => str[random.Next(str.Length)]).ToArray());

            return randomStr;
        }

        string IUrlShortener.GetShortUrl()
        {
            return UrlShortener.GetShort();
        }
    }
}
