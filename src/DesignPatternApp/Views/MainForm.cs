using AppFx.CommandBinding;
using DesignPatternApp.Commands;

namespace DesignPatternApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        initCommandBindings();
        App.Instance.Initialize(this, infoPanel1);
    }

    // A MainForm-hoz tartozó GUI elemek kötése
    private void initCommandBindings()
    {
        CommandBinding cmdBinding;

        // Létrehoz egy új command binding objektumot CommandName.NewDocument azonosítóval, és eseménykezelőnek
        // az App.Instance.NewDocument műveletet regisztrálja be (vagyis akárhogy is futtatjuk a parancsot, az
        // App.Instance.NewDocument hívódik meg).
        // A következő két sor pedig ráköti az adott menüelemet és toolbar gombot a binding objektumra.
        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.NewDocument, App.Instance.NewDocument);
        ToolStripMenuItem_CommandBindingConnector.Connect(newDocumentToolStripMenuItem, cmdBinding);
        ToolStripButton_CommandBindingConnector.Connect(newDocumentToolStripButton, cmdBinding);

        // Dokumentum megnyitás parancs
        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.OpenDocument, App.Instance.OpenDocument);
        ToolStripMenuItem_CommandBindingConnector.Connect(openDocumentToolStripMenuItem, cmdBinding);
        ToolStripButton_CommandBindingConnector.Connect(openDocumentToolStripButton, cmdBinding);

        // Dokumentum bezárás parancs
        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.CloseDocument, App.Instance.CloseDocument);
        ToolStripMenuItem_CommandBindingConnector.Connect(closeDocumentToolStripMenuItem, cmdBinding);
        ToolStripButton_CommandBindingConnector.Connect(closeDocumentToolStripButton, cmdBinding);

        // Dokumentum mentés parancs
        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.SaveDocument, App.Instance.SaveDocument);
        ToolStripMenuItem_CommandBindingConnector.Connect(saveToolStripMenuItem, cmdBinding);
        ToolStripButton_CommandBindingConnector.Connect(saveToolStripButton, cmdBinding);

        // Dokumentum mentés másként parancs
        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.SaveAsDocument, App.Instance.SaveAsDocument);
        ToolStripMenuItem_CommandBindingConnector.Connect(saveAsToolStripMenuItem, cmdBinding);

        #region Tools

        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.ClearDocument, App.Instance.ClearDocument);
        ToolStripMenuItem_CommandBindingConnector.Connect(clearToolStripMenuItem, cmdBinding);

        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.Undo, App.Instance.UndoLast);
        ToolStripMenuItem_CommandBindingConnector.Connect(undoToolStripMenuItem, cmdBinding);
        ToolStripButton_CommandBindingConnector.Connect(undoStripButton, cmdBinding);

        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.NewRect, App.Instance.NewRect);
        ToolStripMenuItem_CommandBindingConnector.Connect(newRectToolStripMenuItem, cmdBinding);
        ToolStripButton_CommandBindingConnector.Connect(newRectStripButton, cmdBinding);

        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.NewEllipse, App.Instance.NewEllipse);
        ToolStripMenuItem_CommandBindingConnector.Connect(newEllipseToolStripMenuItem, cmdBinding);
        ToolStripButton_CommandBindingConnector.Connect(newEllipseToolStripButton, cmdBinding);

        cmdBinding = CommandBindingManager.Instance.CreateCommandBinding(CommandName.SelectShape, App.Instance.SelectShape);
        ToolStripMenuItem_CommandBindingConnector.Connect(selectToolStripMenuItem, cmdBinding);
        ToolStripButton_CommandBindingConnector.Connect(selectToolStripButton, cmdBinding);

        #endregion
    }

    public void SetLeftPanel(Control c)
    {
        splitContainer1.Panel1.Controls.Clear();
        splitContainer1.Panel1.Controls.Add(c);
        c.Dock = DockStyle.Fill;
    }

    void ClearLeftPanel()
    {
        splitContainer1.Panel1.Controls.Clear();
    }
}
