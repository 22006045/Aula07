using System;
using System.Collections.Generic;


namespace Observers
{
    public class ConsolePrinter : IObserver<AbstractStringSubject>
    {
       public void Update(AbstractStringSubject sub)
       {
           Console.WriteLine(sub.Item);
       } 
    }
}