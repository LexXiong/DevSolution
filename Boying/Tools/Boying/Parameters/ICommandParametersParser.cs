using System.Collections.Generic;

namespace Boying.Parameters
{
    public interface ICommandParametersParser
    {
        CommandParameters Parse(IEnumerable<string> args);
    }
}