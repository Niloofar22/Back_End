using System;
using System.Collections.Generic;

namespace MvcApi.Model
{
    public class Actor
    {
      public int ActorId { get; set; }
        public string Fname { get; set; }
        public string Ename { get; set; }
        public string age { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
}
