using Observer.Blueprint;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsAgency agency = new NewsAgency();
            NewsChannel1 channel1 = new NewsChannel1();
            NewsChannel2 channel2 = new NewsChannel2();
            int choice = -1;

            do
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("1.Report new news for news agency");
                Console.WriteLine("2.News Channel 1 subscribes");
                Console.WriteLine("3.News Channel 2 subscribes");
                Console.WriteLine("4.News Channel 1 unsubscribes");
                Console.WriteLine("5.News Channel 2 unsubscribes");
                Console.WriteLine("0.Quit");
                Console.WriteLine("Enter Choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    choice = -1;
                }

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Enter News: ");
                        var news = Console.ReadLine();
                        agency.IncomingNews(new News(news));
                        break;
                    case 2:
                        channel1.Subscribe(agency);
                        Console.WriteLine("Channel1 has subscribed.");
                        break;
                    case 3:
                        channel2.Subscribe(agency);
                        Console.WriteLine("Channel2 has subscribed.");
                        break;
                    case 4:
                        channel1.Unsubscribe();
                        Console.WriteLine("Channel1 has unsubscribed.");
                        break;
                    case 5:
                        channel2.Unsubscribe();
                        Console.WriteLine("Channel2 has unsubscribed.");
                        break;
                    default:
                        Console.WriteLine("Not a valid menu item");
                        break;
                }

            } while (choice != 0);
            Console.WriteLine("Ending Services:");
            agency.CloseSubscription();
        }
    }
}