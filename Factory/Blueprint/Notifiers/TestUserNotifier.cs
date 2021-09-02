using System;

namespace Factory.Blueprint.Notifiers
{
    internal class TestUserNotifier : IUserNotifier
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine("Write text");
        }
    }
}
