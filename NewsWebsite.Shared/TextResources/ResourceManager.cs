using Microsoft.Extensions.Configuration;
using system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NewsWebsite.Shared.TextResources
{
    public class ResourceManager
    {
        private static IConfiguration _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public static string GetString(string key)
        {
            if (_configuration == null)
            {
                return null;
            }
            string resxFilePath = TextResourceTools.GetResourcePath(_configuration);

            if (resxFilePath.HasNoValue())
            {
                resxFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextResources.resx");
            }
            XDocument doc = XDocument.Load(resxFilePath);

            foreach (var data in doc.Descendants("data"))
            {
                if (data.Attribute("name").Value == key)
                {
                    return data.Element("value").Value;
                }
            }
            return null;
        }
    }
}
