﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Drinkc
    {
        public int Id { get; set; }
        public string Name { get; set;}

        //public ICollection<Drinkc>? Drinkcs { get; set; }
        public ICollection<Menu>? Menus { get; set; }

    }
}
