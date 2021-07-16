using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using APITestFramework.Utils.Settings;
using TechTalk.SpecFlow;

namespace APITestFramework.Utils.Hooks
{
    [Binding]
    public class ScenarioHooks
    {
        private APITestFramework.Utils.Settings.Settings _settings;
        public ScenarioHooks(APITestFramework.Utils.Settings.Settings settings)
        {
            _settings = settings;
        }
        [BeforeScenario("Post1")]
        public void BeforeScenarioPost1()
        {
            _settings.Body = @"TestData\TubularAPIPost1.txt";
        }
        [BeforeScenario("Post2")]
        public void BeforeScenarioPost2()
        {
            _settings.Body = @"TestData\TubularAPIPost2.txt";
        }
    }
}
