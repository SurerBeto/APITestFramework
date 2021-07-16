using APITestFramework.Utils.Settings;
using APITestFramework.Apis.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using System.IO;
using NUnit.Framework;
namespace APITestFramework.Steps
{
    [Binding]
    public class TubularPOSTApiScenariosSteps
    {
        private Settings _settings;
        public TubularAPI jsonData;
        public TubularPOSTApiScenariosSteps(Settings settings) => _settings = settings;
        
        [Given(@"The Tubular API information is loaded")]
        public void GivenTheTubularAPIInformationIsLoaded()
        {
            _settings.Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _settings.File);
            jsonData = JsonConvert.DeserializeObject<TubularAPI>(File.ReadAllText(_settings.Path).ToString());
        }


        [When(@"The Tubular Post Request Is Sent")]
        public void WhenTheTubularPostRequestIsSent()
        {
            
            string Url = jsonData.Url;
            Method Type = jsonData.Type;
            _settings.Request = new RestRequest(Url, Type);
            string testbody = File.ReadAllText(_settings.Body.ToString());
            _settings.Request.AddJsonBody(testbody);
            _settings.Response = _settings.RestClient.Execute(_settings.Request);
        }

    }
}
