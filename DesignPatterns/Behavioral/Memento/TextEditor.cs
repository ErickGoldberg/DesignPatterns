namespace DesignPatterns.Behavioral.Memento
{
    public class TextEditor
    {
        private string _text;

        public TextEditor(string text)
        {
            _text = text;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }

        public TextEditorMemento CreateMemento()
        {
            return new TextEditorMemento(_text);
        }

        public void RestoreFromMemento(TextEditorMemento memento)
        {
            _text = memento.Text;
        }
    }

}
