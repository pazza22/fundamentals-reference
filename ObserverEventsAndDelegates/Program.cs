using ObserverEventsAndDelegates.Blueprint;
using System;

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
}
