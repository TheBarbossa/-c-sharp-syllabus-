using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    public class FlightPlannerExtension
    {
        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }
        public static bool VerifyCity(Dictionary<string, List<string>> dictionary, string city)
        {
            return dictionary.ContainsKey(city);
        }
    }
}