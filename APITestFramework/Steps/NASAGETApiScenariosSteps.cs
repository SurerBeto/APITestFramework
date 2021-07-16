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
    public class NASAGETApiScenariosSteps
    {
        private Settings _settings;
        public NASAGETApiScenariosSteps(Settings settings) => _settings = settings;
        public List<NASAApi> jsonData; 

        [Given(@"The NASA API information is loaded")]
        public void GivenTheNASAAPIInformationIsloaded()
        {
            _settings.Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _settings.File);
            jsonData = JsonConvert.DeserializeObject<List<NASAApi>>(File.ReadAllText(_settings.Path).ToString());
        }

        [When(@"The NASA API '(.*)' gets called")]
        public void WhenTheNASAAPIGetsCalled(string ApiName)
        {
            int index = jsonData.FindIndex(i => i.Name == ApiName);
            string Url = jsonData[index].Url;
            string Key = jsonData[index].Key;
            Method Type = jsonData[index].Type;
            _settings.Request = new RestRequest(Url, Type);
            _settings.Request.AddParameter("api_key", Key);
            _settings.Response = _settings.RestClient.Execute(_settings.Request);
        }

        [Then(@"The status code should be '(.*)'")]
        public void ThenTheStatusCodeShouldBe(string Status)
        {
            Assert.AreEqual(Status, _settings.Response.StatusCode.ToString(),"Status not OK");
        }

        [Then(@"The Body Response is not empty")]
        public void ThenTheBodyResponseisnotempty()
        {
           Assert.NotNull(_settings.Response.Content, "Body is Empty");
        }

    }
}
