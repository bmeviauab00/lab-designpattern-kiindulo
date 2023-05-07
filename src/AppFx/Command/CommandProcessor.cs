using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFx.Command
{
    // 1. Eltárolja a már futtatott command objektumokat, hogy ha később 
    // a parancs visszavonására kerül sor, rendelkezésre álljon a 
    // command objektum
    // 2. A parancsok futtatását és visszavonását rajta keresztül 
    // végezzük(ExecuteCommand és UnExecuteLastCommand műveletek)
    public class CommandProcessor
    {
        Stack<Command> commands = new Stack<Command>();

        // Futtatja a paraméterként parancsot (Executee hívása) majd eltárolja
        public void ExecuteCommand(Command cmd)
        {
            cmd.Execute();
            commands.Push(cmd);
        }

        // Visszavonja az utoljára futtatott parancsot.
        // Ehhez kiveszi a legutolsót a command stack-ről
        // majd meghívja az UnExecute műveletét.
        public void UnExecuteLastCommand()
        {
            // Ha üres, nem csinálunk semmit
            if (!commands.Any())
                return;

            Command lastCommand = commands.Pop();
            lastCommand.UnExecute();
        }

		public void Clear()
        {
            commands.Clear();
        }
		
        public bool HasAny { get { return commands.Any(); } }
    }

}
