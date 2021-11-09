using System;
using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private string file;
        public FileSaver(string file)   
        {
            this.file = file;
        }
        public void Update(AbstractStringSubject sub)
        {
            File.AppendAllText(file, sub.Item);
        } 
    }
}