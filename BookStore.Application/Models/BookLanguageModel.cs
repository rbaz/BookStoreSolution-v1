using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class BookLanguageModel
{
    public int LanguageId { get; set; }

    public string? LanguageCode { get; set; }

    public string? LanguageName { get; set; }

    public virtual ICollection<BookModel> Books { get; } = new List<BookModel>();
}
