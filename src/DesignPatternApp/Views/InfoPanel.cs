namespace DesignPatternApp;

public partial class InfoPanel : ViewBase
{
    public InfoPanel()
    {
        InitializeComponent();
    }

    private bool ignoreIndexChanged;

    protected override void RegisterToDocEvents()
    {
        Document.ShapesChanged += Document_ShapesChanged;
        Document.SelectionChanged += Document_SelectionChanged;
    }

    protected override void UnRegisterToDocEvents()
    {
        Document.ShapesChanged -= Document_ShapesChanged;
        Document.SelectionChanged -= Document_SelectionChanged;
        ClearItems();
    }

    private void Document_ShapesChanged(object? sender, EventArgs e)
    {
        try
        {
            ignoreIndexChanged = true;

            listBox.Items.Clear();

            if (Document == null)
                return;

            foreach (var s in Document.Shapes)
            {
                listBox.Items.Add(s.GetDescription());
            }

            listBox.SelectedIndex = Document.SelectedShapeIndex;
        }
        finally
        {
            ignoreIndexChanged = false;
        }
    }

    private void Document_SelectionChanged(object? sender, EventArgs e)
    {
        if (Document == null)
            return;

        try
        {
            ignoreIndexChanged = true;
            listBox.SelectedIndex = Document.SelectedShapeIndex;
        }
        finally
        {
            ignoreIndexChanged = false;
        }
    }

    private void listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ignoreIndexChanged)
            return;

        App.Instance.SetSelectedShape(listBox.SelectedIndex);
    }

    private void ClearItems()
    {
        try
        {
            ignoreIndexChanged = true;
            listBox.Items.Clear();
        }
        finally
        {
            ignoreIndexChanged = false;
        }
    }
}
