namespace Book.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=StoreContext")
        {
        }

         public virtual DbSet<Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<global::Book.Models.Magazine> Magazines { get; set; }

    }
}