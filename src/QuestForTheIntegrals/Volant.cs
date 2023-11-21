using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    class Volant:Être
    {
        public Volant()
            : base(BaseVie, BaseDégâts, BasePrix,BaseVitesse,"Volant")
        {
           
        }
        public static int BaseVitesse = 100;
        public const int BASE_VITESSE = 100;
        public static int BaseVie = 200;
        public const int BASE_VIE = 200;
        public static int BaseDégâts = 70;
        public const int BASE_DÉGÂTS = 70;
        public const int BASE_PRIX = 300;
        public static int BasePrix = 300;
    }
}
