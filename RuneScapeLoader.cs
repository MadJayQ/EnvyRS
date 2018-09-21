using System;


using Suice;


namespace EnvyRS {
    [Singleton]
    class RuneScapeLoader {
            
        [Inject]
        private RuneScapeLoader(RuneScapeConfigLoader loader) {

        }
    }
}