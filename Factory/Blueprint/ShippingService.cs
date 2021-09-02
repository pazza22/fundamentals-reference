using Factory.Blueprint.ServiceProvider;

namespace Factory.Blueprint
{
    internal class ShippingService
    {
        private readonly INotificationServiceProvider _serviceProvider;
        public ShippingService(INotificationServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ShipItem(int id)
        {
            _serviceProvider.GetUserNotifier(Environment.PROD).NotifyUser(id);
        }
    }
}
