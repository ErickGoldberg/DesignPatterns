namespace DesignPatterns.Behavioral.Memento
{
    public class TextEditorHistory
    {
        private Stack<TextEditorMemento> _mementos = new Stack<TextEditorMemento>();

        public void SaveMemento(TextEditorMemento memento)
        {
            _mementos.Push(memento);
        }

        public TextEditorMemento PopMemento()
        {
            return _mementos.Pop();
        }
    }
}
