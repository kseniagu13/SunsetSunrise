using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SunsetSunrise
{
    class Program
    {
        static void Main(string[] args)
        {
            string responseUrl = "https://api.sunrise-sunset.org/json?lat=59.437222&lng=24.753574&date=today";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(responseUrl);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                SunMode sunMode = JsonConvert.DeserializeObject<SunMode>(response); //loome objekti, et salvestada sinna andmed jsonist

                Console.WriteLine(sunMode.Status);
                Console.WriteLine($"Sunrise: {sunMode.Results.Sunrise}"); 
                Console.WriteLine($"Sunrise: {sunMode.Results.Sunset}");
            }
        }
    }
}
