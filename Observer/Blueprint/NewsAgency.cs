using System;
using System.Collections.Generic;

namespace Observer.Blueprint
{
    class NewsAgency : IObservable<News>
    {
        List<IObserver<News>> observers;

        public NewsAgency()
        {
            observers = new List<IObserver<News>>();
        }

        public IDisposable Subscribe(IObserver<News> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<News>> _observers;
            private IObserver<News> _observer;

            public Unsubscriber(List<IObserver<News>> observers, IObserver<News> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null)
                {
                    _observers.Remove(_observer);
                }
            }
        }

        public void IncomingNews(News news)
        {
            foreach (var observer in observers)
            {
                observer.OnNext(news);
            }
        }

        public void CloseSubscription()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }
        }
    }
}