using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class PublisherModel
{
    public int PublisherId { get; set; }

    public string? PublisherName { get; set; }

    public virtual ICollection<BookModel>? Books { get; set; }
}
