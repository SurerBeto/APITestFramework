using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;


namespace APITestFramework.Apis.Models
{
    public class TubularAPI
    {
        public Method Type { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
