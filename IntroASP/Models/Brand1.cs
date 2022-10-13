using System;
using System.Collections.Generic;

namespace IntroASP.Models
{
    public partial class Brand1
    {
        public Brand1()
        {
            Beer1s = new HashSet<Beer1>();
        }

        public int BrandId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Beer1> Beer1s { get; set; }
    }
}
