using System;
using System.Collections.Generic;

namespace IntroASP.Models
{
    public partial class Beer1
    {
        public int BeerId { get; set; }
        public string Name { get; set; } = null!;
        public int BrandId { get; set; }

        public virtual Brand1 Brand { get; set; } = null!;
    }
}
