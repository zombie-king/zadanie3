using System;
using CommandLine;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Arguments>(args)
                .WithParsed(arguments =>
                {
                    var result = Rest.GiveTheRest(arguments.Rest);
                    Console.WriteLine(Rest.FormatResult(result));
                });
        }
    }
}
