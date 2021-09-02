using Factory.Blueprint;
using Factory.Blueprint.ServiceProvider;

namespace Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NotificationServiceProvider notificationServiceProvider = new NotificationServiceProvider();
            ShippingService shippingService = new ShippingService(notificationServiceProvider);
            shippingService.ShipItem(5);
        }
    }
}
