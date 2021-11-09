using System;


namespace Observers
{
    public class KeyReader : AbstractStringSubject
    {
        public void ReadKeys()
        {
            ConsoleKey key;

            while((key = Console.ReadKey(true).Key) != ConsoleKey.Escape)
            {
                Item = key.ToString();
            }
        }
    }
}