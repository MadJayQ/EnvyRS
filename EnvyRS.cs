using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


using Suice;

namespace EnvyRS
{
    class EnvyRS
    {

        private static readonly HttpClient HttpClient;

        public static readonly string CONFIG_URL_STRING = "http://oldschool.runescape.com/jav_config.ws";
        
        static async Task Main() {
            HttpClient client = new HttpClient();
            try {
                var url = new Uri(CONFIG_URL_STRING);
                HttpResponseMessage resposne = await client.GetAsync(url);
                resposne.EnsureSuccessStatusCode();
                var responseBody = await resposne.Content.ReadAsStreamAsync();
                var responseReader = new StreamReader(responseBody);
                var configLine = "" as string;
                while((configLine = responseReader.ReadLine()) != null) {
                    Console.WriteLine(configLine);
                }
            }
            catch(HttpRequestException e) {
                Console.WriteLine("\nException caught!");
                Console.WriteLine("Message: {0} ", e.Message);
            }
            client.Dispose();
        }
    }
}
