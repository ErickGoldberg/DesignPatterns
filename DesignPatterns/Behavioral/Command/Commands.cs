namespace DesignPatterns.Behavioral.Command
{
    public class CopyCommand : ICommand
    {
        private string _text;
        private Clipboard _clipboard;

        public CopyCommand(string text, Clipboard clipboard)
        {
            _text = text;
            _clipboard = clipboard;
        }

        public void Execute()
        {
            _clipboard.SetClipboard(_text);
            Console.WriteLine($"Copied text: {_text}");
        }

        public void Undo()
        {
            _clipboard.ClearClipboard();
            Console.WriteLine($"Undo copy: {_text}");
        }
    }

    public class PasteCommand : ICommand
    {
        private Clipboard _clipboard;
        private Editor _editor;

        public PasteCommand(Editor editor, Clipboard clipboard)
        {
            _editor = editor;
            _clipboard = clipboard;
        }

        public void Execute()
        {
            string text = _clipboard.GetClipboard();
            _editor.InsertText(text);
            Console.WriteLine($"Pasted text: {text}");
        }

        public void Undo()
        {
            _editor.DeleteText();
            Console.WriteLine("Undo paste");
        }
    }

    // Implementações semelhantes para outros comandos, como CutCommand

}
