using System;
using System.IO;

namespace ObserverEventsAndDelegates.Blueprint
{
    public class FileWriter
    {
        public string filename = $"{DateTime.Now.ToFileTime()}.txt";

        public void WriteToFile(string line) =>
            File.AppendAllText(filename, line + Environment.NewLine);
    }
}
