namespace AppFx.Command;

/// <summary>
/// 1. Eltárolja a már futtatott command objektumokat,
///     hogy ha később a parancs visszavonására kerül sor,
///     rendelkezésre álljon a command objektum
/// 2. A parancsok futtatását és visszavonását rajta keresztül végezzük
///     (ExecuteCommand és UnExecuteLastCommand műveletek)
/// </summary>
public class CommandProcessor
{
    private Stack<Command> commands = new Stack<Command>();

    /// <summary>
    /// Futtatja a paraméterként parancsot (Executee hívása) majd eltárolja
    /// </summary>
    public void ExecuteCommand(Command cmd)
    {
        cmd.Execute();
        commands.Push(cmd);
    }

    /// <summary>
    /// Visszavonja az utoljára futtatott parancsot.
    /// Ehhez kiveszi a legutolsót a command stack-ről majd meghívja az UnExecute műveletét.
    /// </summary>
    public void UnExecuteLastCommand()
    {
        // Ha üres, nem csinálunk semmit
        if (!commands.Any())
            return;

        var lastCommand = commands.Pop();
        lastCommand.UnExecute();
    }

    public void Clear()
    {
        commands.Clear();
    }

    public bool HasAny => commands.Any();
}
