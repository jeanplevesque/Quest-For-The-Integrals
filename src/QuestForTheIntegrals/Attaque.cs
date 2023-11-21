using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    class Attaque
    {
        public Attaque(float dégâts, GroupeMilitaire groupeAttaquant, bool estAttaqueDistance)
        {
            Dégâts = dégâts;
            GroupeAttaquant = groupeAttaquant;
            EstAttaqueDistance = estAttaqueDistance;
        }
        public float Dégâts
        {
            get { return dégâts_; }
            set { dégâts_ = value; }
        }
        public GroupeMilitaire GroupeAttaquant
        {
            get { return groupeAttaquant_; }
            private set { groupeAttaquant_ = value; }
        }
        public bool EstAttaqueDistance
        {
            get { return estAttaqueDistance_; }
            private set { estAttaqueDistance_ = value; }
        }
        bool estAttaqueDistance_;
        GroupeMilitaire groupeAttaquant_;
        float dégâts_;
    }
}
