using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SWMerchDataRepository.States
{
    public class States
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Country { get; set; }

        public static IEnumerable<States> GetStatesFromXML()
        {
            var xElement = XDocument.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "States.xml").Element("states");
            if (xElement == null) return null;
            var ret = xElement.Elements("state").Select(t => new States
            {
                Name = t.Attribute("name").Value,
                Abbreviation = t.Attribute("abbreviation").Value,
                Country = t.Attribute("country").Value
            }).ToList();

            return ret;
        }
    }
}
