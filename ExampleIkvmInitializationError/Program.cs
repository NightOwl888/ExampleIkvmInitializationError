using opennlp.tools.sentdetect;
using System;

namespace ExampleIkvmNetFrameworkError
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System.IO.Stream stream = typeof(Program).Assembly.GetManifestResourceStream("ExampleIkvmNetFrameworkError.en-test-sent.bin");
            var sw = new ikvm.io.InputStreamWrapper(stream);
            new SentenceModel(sw);

            Console.WriteLine("Hello, World!");
        }
    }
}