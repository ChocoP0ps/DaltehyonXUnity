using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaltehyonXUnity.Controller
{
    class MainController
    {
        public bool partyFound { get; set; }
        public int idParty { get; set; }
        public List<Personnage> army { get; set; }
        private static MainController instance;

        public static MainController getInstance()
        {
            if(instance != null)
            {
                return instance;
            }
            else
            {
                return instance = new MainController();
            }
        }

        public MainController()
        {
            partyFound = false;
        }
    }
}
