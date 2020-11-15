using System;
using CommandLine;

namespace zadanie3
{
    class Program
    {
        static int Main(string[] args)
        {
            int exitCode = 0;
            Parser.Default.ParseArguments<Arguments>(args)
                .WithParsed(arguments =>
                {
                    try
                    {
                        var result = Rest.GiveTheRest(arguments.Rest);
                        Console.WriteLine(Rest.FormatResult(result));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        exitCode = 1;
                    }
                });
            return exitCode;
        }
    }
}
