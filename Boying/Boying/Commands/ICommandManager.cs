using System.Collections.Generic;

namespace Boying.Commands
{
    public interface ICommandManager : IDependency
    {
        void Execute(CommandParameters parameters);

        IEnumerable<CommandDescriptor> GetCommandDescriptors();
    }
}