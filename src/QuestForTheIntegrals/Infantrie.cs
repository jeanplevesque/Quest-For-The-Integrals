using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    class Infantrie : Être
    {
        public Infantrie()
            : base(BaseVie, BaseDégâts, BasePrix,BaseVitesse,"Infantrie")
        {

        }
        public static int BaseVitesse = 12;
        public const int BASE_VITESSE = 12;
        public static int BaseVie = 35;
        public const int BASE_VIE = 35;
        public static int BaseDégâts = 10;
        public const int BASE_DÉGÂTS = 10;
        public static int BasePrix = 20;
        public const int BASE_PRIX = 20;

        
    }
}
