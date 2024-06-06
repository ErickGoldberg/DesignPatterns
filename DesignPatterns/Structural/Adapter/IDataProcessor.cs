namespace DesignPatterns.Structural.Adapter
{
    public interface IDataProcessor
    {
        string ReadData();
        void SaveData(string data);
    }

}
