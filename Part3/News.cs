using System;

namespace Part3
{
    public class News
    {
        public News()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime PubDate { get; set; }
        public string Description { get; set; }
    }
}
