namespace DesignPatternApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        App.Instance.Initialize(this, infoPanel1);

        newDocumentToolStripMenuItem.Command = App.Instance.NewDocumentCommand;
        newDocumentToolStripButton.Command = App.Instance.NewDocumentCommand;

        closeDocumentToolStripMenuItem.Command = App.Instance.CloseDocumentCommand;
        closeDocumentToolStripButton.Command = App.Instance.CloseDocumentCommand;

        saveToolStripMenuItem.Command = App.Instance.SaveDocumentCommand;
        saveToolStripButton.Command = App.Instance.SaveDocumentCommand;

        saveAsToolStripMenuItem.Command = App.Instance.SaveAsDocumentCommand;

        newRectStripButton.Command = App.Instance.NewRectCommand;
        newRectToolStripMenuItem.Command = App.Instance.NewRectCommand;

        newEllipseToolStripButton.Command = App.Instance.NewEllipseCommand;
        newEllipseToolStripMenuItem.Command = App.Instance.NewEllipseCommand;

        clearToolStripMenuItem.Command = App.Instance.ClearDocumentCommand;

        undoStripButton.Command = App.Instance.UndoLastCommand;
        undoToolStripMenuItem.Command = App.Instance.UndoLastCommand;

        selectToolStripButton.Command = App.Instance.SelectShapeCommand;
        selectToolStripMenuItem.Command = App.Instance.SelectShapeCommand;
    }

    public void SetLeftPanel(Control c)
    {
        splitContainer1.Panel1.Controls.Clear();
        splitContainer1.Panel1.Controls.Add(c);
        c.Dock = DockStyle.Fill;
    }

    public void ClearLeftPanel()
    {
        splitContainer1.Panel1.Controls.Clear();
    }
}
