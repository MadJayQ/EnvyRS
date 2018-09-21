using System;

using Suice;

namespace EnvyRS {
    public class EnvyRSModule : AbstractModule {
        protected override void Configure() {
            Bind<System.Net.Http.HttpClient>().ToInstance(EnvyRS.HttpClient);
        }
    } 
}