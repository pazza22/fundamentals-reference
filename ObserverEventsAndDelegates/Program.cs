using System;
using System.IO;

namespace ObserverEventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter List (Ctrl C to Quit: ");
            var reader = new ListReader();
            var writer = new FileWriter();
            reader.ListUpdated += (listItem) => Console.WriteLine($"You entered: {listItem}");
            reader.ListUpdated += writer.WriteToFile;
            reader.ReadList();
        }
    }

    public class ListReader
    {
        public delegate void NewListItem(string listItem);
        public event NewListItem ListUpdated;

        public void ReadList()
        {
            while (true)
            {
                var listItem = Console.ReadLine();
                ListUpdated?.Invoke(listItem);
            }
        }
    }

    public class FileWriter
    {
        public string filename = $"{DateTime.Now.ToFileTime()}.txt";

        public void WriteToFile(string line) =>
            File.AppendAllText(filename, line + Environment.NewLine);
    }
}
