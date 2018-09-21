using System;
using System.IO;

using System.Net.Http;

using Suice;


namespace EnvyRS {
    class RuneScapeConfigLoader {
        public static readonly string CONFIG_URL = "http://oldschool.runescape.com/jav_config.ws";
        
        private readonly HttpClient HttpClient;

        [Inject]
        public RuneScapeConfigLoader(HttpClient client) {
            this.HttpClient = client;
        }
    }
}