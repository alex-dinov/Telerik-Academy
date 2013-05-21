using System;
using System.Linq;

namespace CalendarSystem
{
    public struct Command
    {
        public string CommandName { get; set; }

        public string[] Parameters { get; set; }

        public static Command Parse(string command)
        {
            int commandSplitterIndex = command.IndexOf(' ');
            if (commandSplitterIndex == -1)
            {
                throw new ArgumentException("Invalid command: " + command);
            }

            string name = command.Substring(0, commandSplitterIndex);
            string argument = command.Substring(commandSplitterIndex + 1);

            var commandArguments = argument.Split('|');
            for (int i = 0; i < commandArguments.Length; i++)
            {
                argument = commandArguments[i];
                commandArguments[i] = argument.Trim();
            }

            Command cmd = new Command { CommandName = name, Parameters = commandArguments };

            return cmd;
        }
    }
}
