using System;
using Microsoft.EntityFrameworkCore;

namespace MvcApi.Model
{
    public class MyContext: DbContext
    {
       public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public MyContext(DbContextOptions<MyContext> options) :base(options)
        {

        }
    }

}
