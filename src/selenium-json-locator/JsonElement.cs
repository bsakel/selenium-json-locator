using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace selenium_json_locator
{
    public class JsonElement
    {
        public string Locator { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public How How { get; set; }

    }
}
