using AppFx.Command;
using AppFx.CommandBinding;

using DesignPatternApp.Commands;
using DesignPatternApp.Documents;

namespace DesignPatternApp;

public partial class App
{
    public void NewDocument()
    {
        CloseDocument();

        Document = new DrawingDocument();

        graphicsView = new GraphicsView();
        mainForm.SetLeftPanel(graphicsView);
        graphicsView.SetDocumentAndRegisterToDocEvents(Document);
        infoPanel.SetDocumentAndRegisterToDocEvents(Document);

        CommandBindingManager.Instance.EnableCommandBinding(CommandName.CloseDocument, true);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SaveDocument, true);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SaveAsDocument, true);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.ClearDocument, true);

        CommandBindingManager.Instance.EnableCommandBinding(CommandName.ClearDocument, true);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.Undo, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.NewRect, true);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.NewEllipse, true);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SelectShape, true);

        //AddTestData();
    }

    public void OpenDocument()
    {
        ShowNotImplemented();
    }

    public void CloseDocument()
    {
        // Nincs dokumentum megnyitva
        if (Document == null)
            return;

        graphicsView.RemoveDocumentAndUnregisterDocEvents();
        graphicsView.Dispose();
        infoPanel.RemoveDocumentAndUnregisterDocEvents();
        Document = null;

        commandProcessor.Clear();

        CommandBindingManager.Instance.EnableCommandBinding(CommandName.CloseDocument, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SaveDocument, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SaveAsDocument, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.ClearDocument, false);

        CommandBindingManager.Instance.EnableCommandBinding(CommandName.ClearDocument, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.Undo, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.NewRect, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.NewEllipse, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SelectShape, false);
    }

    public void SaveDocument()
    {
        ShowNotImplemented();
    }

    public void SaveAsDocument()
    {
        ShowNotImplemented();
    }

    public void SelectShape()
    {
        ShowNotImplemented();
    }

    public void ClearDocument()
    {
        ExecuteCommand(new ClearCommand());
    }

    public void UndoLast()
    {
        UnexecuteLastCommand();
    }

    public void NewRect()
    {
        ExecuteCommand(new NewRectCommand());
    }

    public void NewEllipse()
    {
        ExecuteCommand(new NewEllipseCommand());
    }

    private void ExecuteCommand(Command cmd)
    {
        commandProcessor.ExecuteCommand(cmd);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.Undo, commandProcessor.HasAny);
    }

    private void UnexecuteLastCommand()
    {
        commandProcessor.UnExecuteLastCommand();
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.Undo, commandProcessor.HasAny);
    }


    private void AddTestData()
    {
        Document.CreateRect(new Rectangle(20, 100, 200, 100));
        Document.CreateRect(new Rectangle(150, 70, 300, 50));
        Document.CreateEllipse(new Rectangle(250, 300, 100, 100));

        Document.SelectedShapeIndex = 1;
    }

    private void ShowNotImplemented()
    {
        MessageBox.Show("Not implemented.");
    }
}
