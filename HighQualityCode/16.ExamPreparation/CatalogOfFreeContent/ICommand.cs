using System;
using System.Linq;

namespace CatalogOfFreeContent
{
    public interface ICommand
    {
        ContentCommand Type { get; set; }

        string OriginalForm { get; set; }

        string Name { get; set; }

        string[] Parameters { get; set; }

        ContentCommand ParseCommandType(string commandName);

        string ParseName();

        string[] ParseParameters();
    }
}
