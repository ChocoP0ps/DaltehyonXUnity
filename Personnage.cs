using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaltehyonXUnity
{
    class Personnage
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Pdr { get; set; }

        public Personnage(string Name, int Attack, int Defense, int Pdr)
        {
            this.Name = Name;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Pdr = Pdr;
        }
    }
}
