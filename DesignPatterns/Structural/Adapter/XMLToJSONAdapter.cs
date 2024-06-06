using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace DesignPatterns.Structural.Adapter
{
    public class XMLToJSONAdapter : IDataProcessor
    {
        private readonly XMLDataProcessor _xmlProcessor;

        public XMLToJSONAdapter(XMLDataProcessor xmlProcessor)
        {
            _xmlProcessor = xmlProcessor;
        }

        public string ReadData()
        {
            string xmlData = _xmlProcessor.ReadXML();
            XElement xmlElement = XElement.Parse(xmlData);
            string jsonData = JsonConvert.SerializeXNode(xmlElement, Formatting.None, true);
            return JObject.Parse(jsonData).ToString();
        }

        public void SaveData(string data)
        {
            JObject jsonData = JObject.Parse(data);
            string xmlData = JsonConvert.DeserializeXNode(jsonData.ToString(), "Root").ToString();
            _xmlProcessor.SaveXML(xmlData);
        }
    }
}
