
namespace DesignPatterns.Behavioral.Command
{
    public class Clipboard
    {
        internal void ClearClipboard()
        {
            throw new NotImplementedException();
        }

        internal string GetClipboard()
        {
            throw new NotImplementedException();
        }

        internal void SetClipboard(string text)
        {
            throw new NotImplementedException();
        }
    }

    public class Editor
    {
        internal void DeleteText()
        {
            throw new NotImplementedException();
        }

        internal void InsertText(string text)
        {
            throw new NotImplementedException();
        }
    }
}
