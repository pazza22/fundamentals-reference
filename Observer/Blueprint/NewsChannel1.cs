using System;

namespace Observer.Blueprint
{
    //To do: extract base class and reuse
    class NewsChannel1 : IObserver<News>
    {
        private IDisposable subscription;

        public virtual void Subscribe(IObservable<News> agency)
        {
            subscription = agency.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            if (subscription != null)
            {
                subscription.Dispose();
            }
            else
            {
                Console.WriteLine("No subscription found");
            }
        }

        public void OnCompleted()
        {
            Console.WriteLine("And thats it for today, here from everyone in news channel 1, have a great day");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("This is news channel 1, we would like to apologize for the interruption in our services");
        }

        public void OnNext(News news)
        {
            Console.WriteLine($"This just in, news channel 1 would like to inform you that {news.Headline}");
        }
    }
}