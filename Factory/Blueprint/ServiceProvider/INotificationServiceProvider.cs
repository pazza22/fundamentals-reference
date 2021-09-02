using Factory.Blueprint.Notifiers;

namespace Factory.Blueprint.ServiceProvider
{
    internal interface INotificationServiceProvider
    {
        IUserNotifier GetUserNotifier(Environment environment);
    }
}
