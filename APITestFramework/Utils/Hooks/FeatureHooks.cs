using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using APITestFramework.Utils.Settings;
using TechTalk.SpecFlow;

namespace APITestFramework.Utils.Hooks
{
    [Binding]
    public class FeatureHooks
    {
        private APITestFramework.Utils.Settings.Settings _settings;
        public FeatureHooks(APITestFramework.Utils.Settings.Settings settings)
        {
            _settings = settings;
        }

        [BeforeScenario("NASAGETApiScenarios")]
        public void BeforeFeature(FeatureContext featurecontext)
        {
            _settings.File = @"TestData\NASAApi.json";
            Console.WriteLine("Starting " + featurecontext.FeatureInfo.Title);
            Console.WriteLine(_settings.Path);
        }
        [AfterScenario]
        public void AfterFeature(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Finished " + scenarioContext.ScenarioInfo.Title);
        }
    }
}
