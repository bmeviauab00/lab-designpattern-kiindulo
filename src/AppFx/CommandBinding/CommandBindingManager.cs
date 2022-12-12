namespace AppFx.CommandBinding;

public class CommandBindingManager
{
    public static CommandBindingManager Instance { get; } = new CommandBindingManager();

    // Command binding-ok az állapot állításhoz
    private readonly Dictionary<string, CommandBinding> commandBindingTable = new Dictionary<string, CommandBinding>();

    /// <summary>
    /// Létrehoz egy új command binding-ot és beregisztrálja az adott néven.
    /// A név alapján lehet majd kikeresni és tiltani/engedélyezni.
    /// A parancs futtatásakor az action paraméterben megadott eseménykezelő hívódik.
    /// </summary>
    public CommandBinding CreateCommandBinding(string commandName, Action action)
    {
        var cmdBinding = new CommandBinding(action);
        RegisterCommandBinding(commandName, cmdBinding);
        return cmdBinding;
    }

    public CommandBinding CreateCommandBinding_WithUIConnections(string commandName, Action action, ToolStripItem items)
    {
        var cmdBinding = new CommandBinding(action);
        RegisterCommandBinding(commandName, cmdBinding);
        return cmdBinding;
    }

    public void EnableCommandBinding(string commandName, bool enable)
    {
        if (commandBindingTable.TryGetValue(commandName, out var cmdBinding))
        {
            cmdBinding.IsEnabled = enable;
        }
    }

    public void SelectCommandBinding(string commandName, bool selected)
    {
        if (commandBindingTable.TryGetValue(commandName, out var cmdBinding))
        {
            cmdBinding.IsSelected = selected;
        }
    }


    private void RegisterCommandBinding(string commandName, CommandBinding cmdBinding)
    {
        commandBindingTable.Add(commandName, cmdBinding);
    }
}
