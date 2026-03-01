using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeMovieLab.Core.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        public int CopiesAvailable { get; set; }
    }
}