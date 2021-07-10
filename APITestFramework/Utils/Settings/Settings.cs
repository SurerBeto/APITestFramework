using System;
using RestSharp;
using System.Collections.Generic;
using System.Text;

namespace APITestFramework.Utils.Settings
{
    public class Settings
    {
        public Uri BaseUrl { get; set; }
        public IRestResponse Response { get; set; }
        public IRestRequest Request { get; set; }
        public RestClient RestClient { get; set; } = new RestClient();
        public string File { get; set; }
        public string Path { get; set; }
        
    }
}
