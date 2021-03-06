﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class Book
    {
        public string ID { get; set; }

        [Required(ErrorMessage = "Please enter title")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "5 < length < 10")]
        public string Title { get; set; }

        public ICollection<string> Authors { get; } = new List<string>();
    }

}