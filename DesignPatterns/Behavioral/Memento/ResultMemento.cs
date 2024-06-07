namespace DesignPatterns.Behavioral.Memento
{
    public class ResultMemento
    {
        public ResultMemento()
        {
            TextEditor textEditor = new TextEditor("Initial text");
            TextEditorHistory history = new TextEditorHistory();

            // Salvar o estado inicial
            history.SaveMemento(textEditor.CreateMemento());

            // Alterar o texto
            textEditor.SetText("Modified text");

            // Salvar o estado alterado
            history.SaveMemento(textEditor.CreateMemento());

            // Desfazer para o estado inicial
            textEditor.RestoreFromMemento(history.PopMemento());
            Console.WriteLine("Text after undo: " + textEditor.GetText());

            // Refazer para o estado alterado
            textEditor.RestoreFromMemento(history.PopMemento());
            Console.WriteLine("Text after redo: " + textEditor.GetText());
        }
    }
}
