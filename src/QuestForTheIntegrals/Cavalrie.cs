using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    class Cavalrie : Être
    {
        public Cavalrie()
            : base(BaseVie, BaseDégâts, BasePrix,BaseVitesse,"Cavalrie")
        {

        }
        public static int BaseVitesse = 22;
        public const int BASE_VITESSE = 22;
        public static int BaseVie = 65;
        public const int BASE_VIE = 65;
        public static int BaseDégâts = 22;
        public const int BASE_DÉGÂTS = 22;
        public const int BASE_PRIX = 40;
        public static int BasePrix = 40;

    }
}
