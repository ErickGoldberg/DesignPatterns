namespace DesignPatterns.Behavioral.Memento
{
    public class TextEditorMemento
    {
        public string Text { get; }

        public TextEditorMemento(string text)
        {
            Text = text;
        }
    }

}
