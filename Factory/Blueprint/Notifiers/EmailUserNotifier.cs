using System;

namespace Factory.Blueprint.Notifiers
{
    internal class EmailUserNotifier : IUserNotifier
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine("Send mails");
        }
    }
}
