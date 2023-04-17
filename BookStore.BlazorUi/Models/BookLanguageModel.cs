using System;
using System.Collections.Generic;

namespace BookStore.BlazorUi.Models
{
    public partial class BookLanguageModel
    {
        public int LanguageId { get; set; }

        public string? LanguageCode { get; set; }

        public string? LanguageName { get; set; }

        public virtual ICollection<BookModel> Books { get; set; }
    }
}