using AppFx.CommandBinding;

using DesignPatternApp.Commands;
using DesignPatternApp.Documents;
using DesignPatternApp.Helpers;

namespace DesignPatternApp;

public partial class App
{
    private MainForm mainForm;
    private GraphicsView graphicsView;
    private InfoPanel infoPanel;

    private App()
    {
    }

    public static App Instance { get; } = new App();

    public DrawingDocument Document { get; private set; }

    public void Initialize(MainForm mainForm, InfoPanel infoPanel)
    {
        this.mainForm = mainForm;
        this.infoPanel = infoPanel;

        CommandBindingManager.Instance.EnableCommandBinding(CommandName.NewDocument, true);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.OpenDocument, true);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.CloseDocument, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SaveDocument, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SaveAsDocument, false);

        CommandBindingManager.Instance.EnableCommandBinding(CommandName.ClearDocument, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.Undo, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.NewRect, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.NewEllipse, false);
        CommandBindingManager.Instance.EnableCommandBinding(CommandName.SelectShape, false);
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
