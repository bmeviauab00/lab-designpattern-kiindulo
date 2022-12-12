using AppFx.Command;

namespace DesignPatternApp.Commands;

public class NewRectCommand : Command
{
    private int shapeId;

    public override void Execute()
    {
        shapeId = App.Instance.CreateRandomRect().Id;
    }

    public override void UnExecute()
    {
        App.Instance.RemoveShape(shapeId);
    }
}
