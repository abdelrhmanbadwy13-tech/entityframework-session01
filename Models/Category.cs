using Assignment01EFCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01EFCore.Models
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string Name  { get; set; }
        public string Discription { get; set; }
        public bool  IsActiv { get; set; }
    }
}
