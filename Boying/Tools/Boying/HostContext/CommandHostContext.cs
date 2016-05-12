using System.IO;
using Boying.Host;

namespace Boying.HostContext
{
    public class CommandHostContext
    {
        public CommandReturnCodes StartSessionResult { get; set; }

        public CommandReturnCodes RetryResult { get; set; }

        public BoyingParameters Arguments { get; set; }

        public DirectoryInfo BoyingDirectory { get; set; }

        public bool DisplayUsageHelp { get; set; }

        public CommandHost CommandHost { get; set; }

        public Logger Logger { get; set; }
    }
}