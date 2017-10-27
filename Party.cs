using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaltehyonXUnity
{
    public class Party
    {
        public int IdParty { get; set; }
        public string PseudoHost { get; set; }
        public string PseudoPlayerTwo { get; set; }
        public string MotDePasse { get; set; }

        public Party(int IdParty, string PseudoHost, string MotDePasse)
        {
            this.IdParty = IdParty;
            this.PseudoHost = PseudoHost;
            this.MotDePasse = MotDePasse;
        }
    }
}
