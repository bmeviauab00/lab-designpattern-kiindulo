using AppFx.Command;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using DesignPatternApp.Documents;
using DesignPatternApp.Helpers;

namespace DesignPatternApp;

public partial class App : ObservableObject
{
    private MainForm mainForm;
    private GraphicsView graphicsView;
    private InfoPanel infoPanel;

    private readonly CommandProcessor commandProcessor = new CommandProcessor();

    private App()
    {
    }

    public static App Instance { get; } = new App();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CloseDocumentCommand))]
    [NotifyCanExecuteChangedFor(nameof(NewRectCommand))]
    [NotifyCanExecuteChangedFor(nameof(NewEllipseCommand))]
    [NotifyCanExecuteChangedFor(nameof(UndoLastCommand))]
    [NotifyCanExecuteChangedFor(nameof(SelectShapeCommand))]
    [NotifyCanExecuteChangedFor(nameof(SaveAsDocumentCommand))]
    [NotifyCanExecuteChangedFor(nameof(SaveDocumentCommand))]
    [NotifyCanExecuteChangedFor(nameof(ClearDocumentCommand))]
    public DrawingDocument _document;

    public void Initialize(MainForm mainForm, InfoPanel infoPanel)
    {
        this.mainForm = mainForm;
        this.infoPanel = infoPanel;
    }

    public void SetSelectedShape(int shapeIndex)
    {
        if (Document == null)
            return;

        // Figyelmen kívül hagyja a kérést, ha a régi index megegyezik az újjal (nem süt el változás eseményt)
        Document.SelectedShapeIndex = shapeIndex;
    }

    public void RemoveShape(int shapeID)
    {
        if (Document == null)
            return;

        Document.RemoveShape(shapeID);
    }

    public Rect CreateRandomRect()
    {
        return Document.CreateRect(RandomHelper.GetRandomRect());
    }

    public Ellipse CreateRandomEllipse()
    {
        return Document.CreateEllipse(RandomHelper.GetRandomRect());
    }
}
