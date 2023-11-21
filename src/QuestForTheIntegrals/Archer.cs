using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    class Archer : Être
    {
        public Archer()
            : base(BaseVie, BaseDégâts, BasePrix,BaseVitesse,BasePortée,"Archer")
        {
        }
        public static int BaseVitesse = 5;
        public const int BASE_VITESSE = 5;
        public static int BaseVie = 20;
        public const int BASE_VIE = 20;
        public static int BaseDégâts = 15;
        public const int BASE_DÉGÂTS = 15;
        public const int BASE_PRIX = 27;
        public static int BasePrix = 27;
        public const float BASE_PORTÉE = 12;
        public static float BasePortée = 12;

    }
}
