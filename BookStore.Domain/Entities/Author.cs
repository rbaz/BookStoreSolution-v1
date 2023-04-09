using System;
using System.Collections.Generic;

namespace bookStore.Domain.Entities;

public partial class Author
{
    public int AuthorId { get; set; }

    public string? AuthorName { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
