using System;
using System.Collections.Generic;

namespace bookStore.Domain.Entities;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string? PublisherName { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
