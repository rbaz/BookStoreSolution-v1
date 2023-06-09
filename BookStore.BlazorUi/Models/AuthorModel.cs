﻿using System;
using System.Collections.Generic;

namespace BookStore.BlazorUi.Models
{

    public partial class AuthorModel
    {
        public int AuthorId { get; set; }

        public string? AuthorName { get; set; }

        public virtual ICollection<BookModel> Books { get; set; }
    }
}