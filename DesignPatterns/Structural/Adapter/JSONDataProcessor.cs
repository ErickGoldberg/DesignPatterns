using Newtonsoft.Json.Linq;

namespace DesignPatterns.Structural.Adapter
{
    public class JSONDataProcessor : IDataProcessor
    {
        private JObject _jsonData;

        public JSONDataProcessor()
        {
            _jsonData = new JObject();
        }

        public string ReadData()
        {
            return _jsonData.ToString();
        }

        public void SaveData(string data)
        {
            _jsonData = JObject.Parse(data);
        }
    }
}
