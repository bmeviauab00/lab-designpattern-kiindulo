using System.Drawing.Drawing2D;

namespace DesignPatternApp;

public abstract class Shape
{
    // Az első még szabad azonosító (statikus !)
    private static int ShapeCounter;

    // Ha -1-et adunk meg azonosítónak, a konstruktor generál egy új értéket és azt tárolja el.
    // Minden más paraméterérték esetén az új alakzat azonosítója a paraméterben kapott érték lesz.
    public Shape(Rectangle rectangle, int id = -1)
    {
        EnclosingRectangle = rectangle;
        Id = id == -1 ? ShapeCounter++ : id;
    }

    // Annak érdekében, hogy később a Memento minta megvalósítása során az alakzatot 
    // és a másolatait össze tudjuk „találtatni”, az egyes alakzatokhoz egy számazonosítót rendelünk,
    // mely az alakzat és másolatai esetében ugyanazt az értéket veszi fel. 
    public int Id { get; }

    public Rectangle EnclosingRectangle { get; private set; }

    public Point Position => EnclosingRectangle.Location;

    public abstract void OnDraw(Graphics g, Brush brush);

    public abstract Shape CreateCopy();

    public void Draw(Graphics g, bool isSelected)
    {
        // Ha kiválasztott az alakzat, kék szaggatott téglalappal rajzoljuk ki a befoglalóját.
        if (isSelected)
        {
            g.DrawRectangle(
                new Pen(Color.Blue)
                {
                    DashStyle = DashStyle.Dash
                },
                EnclosingRectangle);
        }

        // Kitöltéshez használt szín/ecset meghatározása: a kiválasztottat piros kitöltéssel.
        // A tényleges kirajzolás, alakzat típus függő, így meghívunk egy abtrakt műveletet
        OnDraw(g, isSelected ? Brushes.Red : Brushes.Black);
    }

    public void MoveTo(Point newPos)
    {
        // Az EnclosingRectangle.Location nem állítható, mert egy másolat Locationjét állítanánk (a Rectangle struct!)
        EnclosingRectangle = new Rectangle(newPos, EnclosingRectangle.Size);
    }

    public void Resize(float ratio)
    {
        EnclosingRectangle.Inflate(
            new Size(
                (int)(EnclosingRectangle.Width * ratio - EnclosingRectangle.Width),
                (int)(EnclosingRectangle.Height * ratio - EnclosingRectangle.Height))
            );
    }


    // Lehetne ToString()
    public virtual string GetDescription()
    {
        return $"Enclosing rect: x={EnclosingRectangle.X}, y={EnclosingRectangle.Y}, w={EnclosingRectangle.Width}, h={EnclosingRectangle.Height}";
    }

}
