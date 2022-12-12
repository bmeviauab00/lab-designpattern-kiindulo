using AppFx.DocView;

namespace DesignPatternApp.Documents;

public class DrawingDocument : Document
{
    /// <summary>
    /// Akkor kerül elsütésre, ha a shapes lista, vagy annak valamelyik eleme módosul.
    /// </summary>
    public event EventHandler? ShapesChanged;
    /// <summary>
    /// Akkor kerül elsütésre, ha a egy korábbitól eltérő alakzat került kiválasztásra.
    /// </summary>
    public event EventHandler? SelectionChanged;

    private List<Shape> shapes = new List<Shape>();

    /// <summary>
    /// Visszaadja az alakzatok gyűjteményét.
    /// </summary>
    public IEnumerable<Shape> Shapes => shapes;

    private Shape? selectedShape;

    /// <summary>
    /// Az aktuálisan kiválasztott alakzatot adja vissza (null-t, ha nincs 
    /// alakzat kiválasztva), illetve módosításával új alakzat választható ki.
    /// </summary>
    public Shape? SelectedShape
    {
        get { return selectedShape; }
        set
        {
            // Ha nincs változás, ne süssünk el feleslegesen változás eseményt
            if (selectedShape == value)
                return;

            selectedShape = value;

            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Az aktuálisan kiválasztott alakzat indexét adja vissza (-1-et, ha nincs alakzat kiválasztva),
    /// illetve módosításával új alakzat választható ki.
    /// </summary>
    public int SelectedShapeIndex
    {
        get
        {
            return shapes.IndexOf(selectedShape);
        }
        set
        {
            if (value >= shapes.Count)
                return;

            SelectedShape = value == -1 ? null : shapes[value];
        }
    }

    public Rect CreateRect(Rectangle enclosingRectangle)
    {
        var shape = new Rect(enclosingRectangle);
        shapes.Add(shape);
        ShapesChanged?.Invoke(this, EventArgs.Empty);
        return shape;
    }

    public Ellipse CreateEllipse(Rectangle enclosingRectangle)
    {
        var shape = new Ellipse(enclosingRectangle);
        shapes.Add(shape);
        ShapesChanged?.Invoke(this, EventArgs.Empty);
        return shape;
    }

    public void RemoveShape(int shapeId)
    {
        // Kikeressük a shapeId azonosítójú alakzatot.
        var shapeToRemove = shapes.SingleOrDefault(s => s.Id == shapeId);

        // Ha nem találtuk, nem csinálunk semmit
        if (shapeToRemove == null)
            return;

        // Megnézzük, hogy az utolsó van-e kiválasztva. Ha igen: nem lesz kiválasztott alakzat.
        if (shapeToRemove == selectedShape)
            SelectedShape = null;

        // Távolítsuk el az elemet
        shapes.Remove(shapeToRemove);

        ShapesChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Clear()
    {
        shapes.Clear();
        ShapesChanged?.Invoke(this, EventArgs.Empty);
        SelectedShape = null;
    }
}
