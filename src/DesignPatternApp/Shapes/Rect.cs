namespace DesignPatternApp;

public class Rect : Shape
{
    public Rect(Rectangle rect, int id = -1)
        : base(rect, id)
    {
    }

    public override void OnDraw(Graphics g, Brush brush)
    {
        g.FillRectangle(brush, EnclosingRectangle);
        g.DrawRectangle(Pens.Green, EnclosingRectangle);
    }

    public override Shape CreateCopy()
    {
        return new Rect(EnclosingRectangle, Id);
    }
}
