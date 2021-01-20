using System;

namespace Exercises.Core.Common
{
    public class ConsoleDecorator : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}
