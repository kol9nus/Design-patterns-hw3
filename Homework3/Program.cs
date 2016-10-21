using System;
using Homework3.StateFluentBuilder;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter = new LetterBuilder()
                .AddRecipient("Niko")
                .AddLetterBody("Hello, Niko")
                .Build();
            Console.WriteLine(letter);
            Console.WriteLine();
            var letter2 = new LetterBuilder()
                .AddRecipient("Niko")
                .AddLetterBody("Hello, Niko")
                .AddCopyRecipient("Niko2")
                .AddTopic("Hello")
                .AddCopyRecipient("Niko3")
                .Build();
            Console.WriteLine(letter2);
            Console.ReadLine();
        }
    }
}
