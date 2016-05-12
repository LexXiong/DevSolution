using System.Collections.Generic;

namespace Boying.Commands
{
    public class CommandHandlerDescriptor
    {
        public IEnumerable<CommandDescriptor> Commands { get; set; }
    }
}