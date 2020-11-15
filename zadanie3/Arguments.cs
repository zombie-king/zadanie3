using CommandLine;

namespace zadanie3
{
    class Arguments
    {
        [Option('r', longName: "rest", Required = true, HelpText = "Reszta do wydania")]
        public uint Rest { get; set; }
    }
}
