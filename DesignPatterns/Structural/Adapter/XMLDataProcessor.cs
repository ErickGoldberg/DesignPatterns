using System.Xml.Linq;

namespace DesignPatterns.Structural.Adapter
{
    public class XMLDataProcessor
    {
        private XElement _xmlData;

        public XMLDataProcessor()
        {
            _xmlData = new XElement("Root");
        }

        public string ReadXML()
        {
            return _xmlData.ToString();
        }

        public void SaveXML(string data)
        {
            _xmlData = XElement.Parse(data);
        }
    }
}
