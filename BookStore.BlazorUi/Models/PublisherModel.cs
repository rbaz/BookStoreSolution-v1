using System;
using System.Collections.Generic;

namespace BookStore.BlazorUi.Models
{
    public partial class PublisherModel
    {
        public int PublisherId { get; set; }

        public string? PublisherName { get; set; }

        public virtual ICollection<BookModel>? Books { get; set; }
    }
}