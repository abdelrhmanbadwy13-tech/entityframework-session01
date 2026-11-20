using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01EFCore.Models
{
    internal class Book
    {
        // Ef core By Convation:

        public int Id { get; set; } /// Pk int not null
        public string? Title  { get; set; } // Title  nvarchar(max)
        public string? ISBN { get; set; } // Isbn  nvarchar(max)
        public decimal Price { get; set; }/// Price decimal (18,2)
        public int Pages{ get; set; } // Page int 
        public int Year { get; set; } // Year int

        public bool InStock { get; set; }  // Instock bit
    }
}
