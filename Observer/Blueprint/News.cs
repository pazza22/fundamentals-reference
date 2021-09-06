using System;

namespace Observer.Blueprint
{
    class News
    {
        public string Headline { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public string Reporter { get; set; }

        public News()
        {

        }

        public News(string headline)
        {
            Headline = headline;
            Date = DateTime.Now;
        }
    }
}