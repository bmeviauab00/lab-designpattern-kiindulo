using AppFx.Command;

using CommunityToolkit.Mvvm.Input;

using DesignPatternApp.Commands;
using DesignPatternApp.Documents;

namespace DesignPatternApp;

public partial class App
{
    [RelayCommand]
    public void NewDocument()
    {
        CloseDocument();

        Document = new DrawingDocument();

        graphicsView = new GraphicsView();
        mainForm.SetLeftPanel(graphicsView);
        graphicsView.SetDocumentAndRegisterToDocEvents(Document);
        infoPanel.SetDocumentAndRegisterToDocEvents(Document);
    }

    [RelayCommand]
    public void OpenDocument()
    {
        ShowNotImplemented();
    }

    public bool HasOpenDocument => Document != null;

    [RelayCommand(CanExecute = nameof(HasOpenDocument))]
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
    }

    [RelayCommand(CanExecute = nameof(HasOpenDocument))]
    public void SaveDocument()
    {
        ShowNotImplemented();
    }

    [RelayCommand(CanExecute = nameof(HasOpenDocument))]
    public void SaveAsDocument()
    {
        ShowNotImplemented();
    }

    [RelayCommand(CanExecute = nameof(HasOpenDocument))]
    public void SelectShape()
    {
        ShowNotImplemented();
    }

    [RelayCommand(CanExecute = nameof(HasOpenDocument))]
    public void ClearDocument()
    {
        ExecuteCommand(new ClearCommand());
    }

    public bool HasAnyCommand => commandProcessor.HasAny;

    [RelayCommand(CanExecute = nameof(HasAnyCommand))]
    public void UndoLast()
    {
        UnexecuteLastCommand();
    }

    [RelayCommand(CanExecute = nameof(HasOpenDocument))]
    public void NewRect()
    {
        ExecuteCommand(new NewRectCommand());
    }

    [RelayCommand(CanExecute = nameof(HasOpenDocument))]
    public void NewEllipse()
    {
        ExecuteCommand(new NewEllipseCommand());
    }

    private void ExecuteCommand(Command cmd)
    {
        commandProcessor.ExecuteCommand(cmd);
        UndoLastCommand.NotifyCanExecuteChanged();
    }

    private void UnexecuteLastCommand()
    {
        commandProcessor.UnExecuteLastCommand();
        UndoLastCommand.NotifyCanExecuteChanged();
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
