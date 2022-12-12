namespace AppFx.Command;

/// <summary>
/// Command-ok ősosztálya.
/// </summary>
public abstract class Command
{
    public abstract void Execute();
    public abstract void UnExecute();
}
