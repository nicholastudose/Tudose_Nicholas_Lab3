﻿namespace Tudose_Nicholas_Lab3.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        public string PublisherName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
