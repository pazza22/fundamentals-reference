using System;

namespace ObserverEventsAndDelegates.Blueprint
{
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
}
