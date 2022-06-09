using System;
using System.Collections.Generic;

namespace MvcApi.Model
{
    public class Movie
    {
       public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
    }

}
