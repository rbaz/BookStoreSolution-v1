﻿using System;
using System.Collections.Generic;

namespace BookStore.Infrastrcuture.TempModels;

public partial class BookLanguage
{
    public int LanguageId { get; set; }

    public string? LanguageCode { get; set; }

    public string? LanguageName { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
