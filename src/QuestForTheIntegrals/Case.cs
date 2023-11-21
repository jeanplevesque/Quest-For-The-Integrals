using System;

namespace Quest_For_The_Integrals
{
    class Case
    {
        char symbole_;
        int poids_;

        public Case(char symbole)
        {
            Symbole = symbole;
            Poids = int.MaxValue;
        }

        public char Symbole
        {
            get { return symbole_; }
            set { symbole_ = value; }
        }

        public int Poids
        {
            get { return poids_; }
            set { poids_ = value; }
        }

        public bool EstInaccessible
        {
            get { return Symbole != ' '&&Symbole!=','
               // ||Symbole == 'i' || Symbole == 'c' || Symbole == 'a' || Symbole == 'v'||Symbole == 'I' || Symbole == 'C' || Symbole == 'A' || Symbole == 'V'
                ; }
        }
        public bool EstAccessible(GroupeMilitaire cible)
        {
            return Symbole == ' '||Symbole==cible.Symbole; 
        }
        public bool EstUnGroupeEnnemie(Équipe ÉquipeEnnemie)
        {
            bool hehe=false;
            if (ÉquipeEnnemie.EstCPU || ÉquipeEnnemie.EstJoueur2)
            {
                hehe = (Symbole == 'i' || Symbole == 'c' || Symbole == 'a' || Symbole == 'v');
            }
            else
            {
                hehe = (Symbole == 'I' || Symbole == 'C' || Symbole == 'A' || Symbole == 'V');
            }
            return hehe;

        }
        public GroupeMilitaire LeGroupeMilitaire(Équipe ÉquipeJoueur,Équipe ÉquipeEnnemie)
        {
            GroupeMilitaire leGroupeMilitaire=new GroupeMilitaire(' ');
            if (ÉquipeEnnemie.EstCPU || ÉquipeEnnemie.EstJoueur2)
            {
                if (Symbole == 'i')
                {
                    leGroupeMilitaire = ÉquipeEnnemie.ArméeJoueur.Infantrie;
                }
                else if (Symbole == 'c')
                {
                    leGroupeMilitaire = ÉquipeEnnemie.ArméeJoueur.Cavalrie;
                }
                else if (Symbole == 'a')
                {
                    leGroupeMilitaire = ÉquipeEnnemie.ArméeJoueur.Archer;
                }
                else if (Symbole == 'v')
                {
                    leGroupeMilitaire = ÉquipeEnnemie.ArméeJoueur.Volant;
                }
            }
            else
            {
                if (Symbole == 'I')
                {
                    leGroupeMilitaire = ÉquipeJoueur.ArméeJoueur.Infantrie;
                }
                else if (Symbole == 'C')
                {
                    leGroupeMilitaire = ÉquipeJoueur.ArméeJoueur.Cavalrie;
                }
                else if (Symbole == 'A')
                {
                    leGroupeMilitaire = ÉquipeJoueur.ArméeJoueur.Archer;
                }
                else if (Symbole == 'V')
                {
                    leGroupeMilitaire = ÉquipeJoueur.ArméeJoueur.Volant;
                }
            }
            return leGroupeMilitaire;

        }
    }
}
