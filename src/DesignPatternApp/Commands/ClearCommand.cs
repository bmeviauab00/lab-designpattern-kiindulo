using AppFx.Command;

using DesignPatternApp.Documents;

namespace DesignPatternApp.Commands;

public class ClearCommand : Command
{
    private DrawingDocument.IMemento memento = null;

    public override void Execute()
    {
        if (App.Instance.Document == null)
            return;

        memento = App.Instance.Document.CreateMemento();
        App.Instance.Document.Clear();
    }

    public override void UnExecute()
    {
        if (App.Instance.Document == null)
            return;

        App.Instance.Document.RestoreFromMemento(memento);
    }
}
