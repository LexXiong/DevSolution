using Boying.Parameters;

namespace Boying
{
    public interface IBoyingParametersParser
    {
        BoyingParameters Parse(CommandParameters parameters);
    }
}