using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Book.Models
{
    public class Magazine
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Editor { get; set; }
        public string Pages { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
    public class MagazineDBContext : DbContext
    {
        public DbSet<Magazine> Magazines { get; set; }
    }
}