using System;

namespace Observer.Blueprint
{
    class NewsChannel2 : IObserver<News>
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
            Console.WriteLine("Adios from news channel 2");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("We just lost our feed, apologies from news channel 2");
        }

        public void OnNext(News news)
        {
            Console.WriteLine($"Get the latest from news channel 2. Reports are emerging that {news.Headline}");
        }
    }
}