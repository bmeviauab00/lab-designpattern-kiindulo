namespace DesignPatternApp;

public partial class GraphicsView : ViewBase
{
    public GraphicsView()
    {
        InitializeComponent();
        DoubleBuffered = true;
    }

    protected override void RegisterToDocEvents()
    {
        Document.ShapesChanged += DocumentOnShapesChanged;
        Document.SelectionChanged += DocumentOnShapesChanged;
    }

    protected override void UnRegisterToDocEvents()
    {
        Document.ShapesChanged -= DocumentOnShapesChanged;
        Document.SelectionChanged -= DocumentOnShapesChanged;
    }

    private void DocumentOnShapesChanged(object? sender, EventArgs eventArgs)
    {
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (Document == null)
            return;

        foreach (var s in Document.Shapes)
        {
            s.Draw(e.Graphics, isSelected: s == Document.SelectedShape);
        }
    }
}
