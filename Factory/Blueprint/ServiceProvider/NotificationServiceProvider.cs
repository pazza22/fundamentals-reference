using Factory.Blueprint.Notifiers;

namespace Factory.Blueprint.ServiceProvider
{
    internal class NotificationServiceProvider : INotificationServiceProvider
    {
        public IUserNotifier GetUserNotifier(Environment environment)
        {
            switch (environment)
            {
                case Environment.DEV:
                case Environment.STAGE:
                    return new TestUserNotifier();
                default: return new EmailUserNotifier();
            }
        }
    }
}
