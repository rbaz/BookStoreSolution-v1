using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class BookModel
{
    public int BookId { get; set; }

    public string? Title { get; set; }

    public string? Isbn13 { get; set; }

    public int? LanguageId { get; set; }

    public int? NumPages { get; set; }

    public DateTime? PublicationDate { get; set; }

    public int? PublisherId { get; set; }

    public virtual BookLanguageModel? Language { get; set; }

    public virtual ICollection<OrderLineModel> OrderLines { get; } = new List<OrderLineModel>();

    public virtual PublisherModel? Publisher { get; set; }

    public virtual ICollection<AuthorModel> Authors { get; } = new List<AuthorModel>();
}
