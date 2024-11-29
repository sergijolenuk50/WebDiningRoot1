using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Garnish
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public ICollection<Garnish>? Garnishes { get; set; }
        public ICollection<Menu>? Menus { get; set; }

    }
}
