namespace DesignPatternApp.Documents;

public partial class DrawingDocument
{
    public interface IMemento
    {
        void GetState(out List<Shape> shapes, out Shape? selectedShape);
    }

    private class Memento : IMemento
    {
        private List<Shape> shapes = new List<Shape>();
        private Shape? selectedShape;

        public Memento(List<Shape> shapes, Shape? selectedShape)
        {
            // Deep copyra van szükségünk!
            foreach (Shape shape in shapes)
            {
                this.shapes.Add(shape.CreateCopy());
            }

            // Be kell állítsuk selectedShape-nek az új Shape listában kell a megfelelő
            // elemre hivatkoznia, nem az eredetiben. Be kell állítsuk.
            this.selectedShape = null;
            for (int i = 0; i < shapes.Count; ++i)
            {
                if (shapes[i] == selectedShape)
                {
                    this.selectedShape = this.shapes[i];
                    break;
                }
            }
        }

        public void GetState(out List<Shape> shapes, out Shape? selectedShape)
        {
            shapes = this.shapes;
            selectedShape = this.selectedShape;
        }
    }
}