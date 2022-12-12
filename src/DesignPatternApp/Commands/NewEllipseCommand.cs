using AppFx.Command;

namespace DesignPatternApp.Commands;

public class NewEllipseCommand : Command
{
    private int shapeId;

    public override void Execute()
    {
        shapeId = App.Instance.CreateRandomEllipse().Id;
    }

    public override void UnExecute()
    {
        App.Instance.RemoveShape(shapeId);
    }
}
