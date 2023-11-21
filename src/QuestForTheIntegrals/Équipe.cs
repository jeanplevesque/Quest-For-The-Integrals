using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    class Équipe
    {
        public Équipe(string alignement, string race)
        {
            //Chevalier = false;
            //Démoniaque = false;
            //ÊtreForêt = false;
            //Nécromantien = false;
            NbCombats = 0;
            Score = 0;
            ArméeJoueur = new Armée(this);
            Alignement = alignement;
            Race = race;
            PrixRevanche = 800;
            PrixNécromancie = 1500;
            Expérience = 0;
            Or = 500;
            ArcsLongs = false;
            ElfsAméloirés = false;
            Ents = false;
            Nécromancie = false;
            Revanche = false;
            Magogs = false;
            BonusÉglise = 0;
            BonusNécromancie = 6;
            BonusRevanche = 0;
            Église = false;
            
            if (Alignement == "Bon")
            {
                Bon = true; 
            }
            else
            {
                Mauvais = true;
            }
            if (Race == "Humain")
            {
                Humain = true;
            }
            else
            {
                Créature = true;
            }

            if (Humain && Bon)
            {
                Nom = "Chevalier";
                Chevalier = true;
                Infantrie = "Halebardiers";
                Cavalrie = "Champions";
                Archer = "Arbalètriers";
                Volant = "Arcanges";
                PrixÉglise = 1000;
                Couleur = ConsoleColor.Cyan;
                Couleur2 = ConsoleColor.Blue;
            }
            else if (Humain && Mauvais)
            {
                Nom = "Nécromancien";
                Nécromantien = true;
                Infantrie = "Squelettes";
                Cavalrie = "Cavaliers Noirs";
                Archer = "Liches";
                Volant = "Fantômes";
                Couleur = ConsoleColor.DarkYellow;
                Couleur2 = ConsoleColor.Yellow;
            }
            else if (Créature && Mauvais)
            {
                Nom = "Démoniaque";
                Démoniaque = true;
                Infantrie = "Démons";
                Cavalrie = "Manticores";
                Archer = "Gogs";
                Volant = "Effrets";
                Couleur = ConsoleColor.Red;
                Couleur2= ConsoleColor.Magenta;
            }
            else if (Créature && Bon)
            {
                Nom = "Être de la Forêt";
                ÊtreForêt = true;
                Infantrie = "Nains";
                Cavalrie = "Centaures";
                Archer = "Elfs";
                Volant = "Dragons Verts";
                Couleur = ConsoleColor.Green;
                Couleur2 = ConsoleColor.DarkGreen;
            }
        }
        #region Propriétées
        public bool ArcsLongs
        {
            get { return arcsLongs_; }
            set { arcsLongs_ = value; }
        }
        public bool EstCPU
        {
            get { return estCPU_; }
            set { estCPU_ = value; }
        }
        public bool EstJoueur2
        {
            get { return estJoueur2_; }
            set { estJoueur2_ = value; }
        }
        public ConsoleColor Couleur
        {
            get { return couleur_; }
            set { couleur_ = value; }
        }
        public ConsoleColor Couleur2
        {
            get { return couleur2_; }
            set { couleur2_ = value; }
        }
        public Armée ArméeJoueur
        {
            get { return arméeJoueur_; }
            set { arméeJoueur_ = value; }
        }
        public int NbCombats
        {
            get { return nbCombats_; }
            set { nbCombats_ = value; }
        }               
        public float Expérience
        {
            get { return expérience_; }
            set { expérience_ = value; }
        }
        public int Or
        {
            get { return or_; }
            set { or_ = value; }
        }
        public int Score
        {
            get { return score_; }
            set { score_ = value; }
        }
        public float BonusRevanche
        {
            get { return bonusRevanche_; }
            set { bonusRevanche_ = value; }
        }
        public int BonusÉglise
        {
            get { return bonusÉglise_; }
            set { bonusÉglise_ = value; }
        }
        public string Nom
        {
            get { return nom_; }
            set { nom_ = value; }
        }
        public string Alignement
        {
            get { return alignement_; }
            set { alignement_ = value; }
        }
        public string Race
        {
            get { return race_; }
            set { race_ = value; }
        }
        public string Volant
        {
            get { return volant_; }
            set { volant_ = value; }
        }
        public string Archer
        {
            get { return archer_; }
            set { archer_ = value; }
        }
        public string Cavalrie
        {
            get { return cavalrie_; }
            set { cavalrie_ = value; }
        }
        public string Infantrie
        {
            get { return infantrie_; }
            set { infantrie_ = value; }
        }
        public bool Bon
        {
            get { return bon_; }
            set { bon_ = value; }
        }
        public bool Mauvais
        {
            get { return mauvais_; }
            set { mauvais_ = value; }
        }
        public bool Humain
        {
            get { return humain_; }
            set { humain_ = value; }
        }
        public bool Créature
        {
            get { return créature_; }
            set { créature_ = value; }
        }
        public bool Démoniaque
        {
            get { return démoniaque_; }
            private set { démoniaque_ = value; }
        }
        public bool Nécromantien
        {
            get { return nécromantien_; }
            private set { nécromantien_ = value; }
        }
        public bool ÊtreForêt
        {
            get { return êtreForêt_; }
            private set { êtreForêt_ = value; }
        }
        public bool Chevalier
        {
            get { return chevalier_; }
            private set { chevalier_ = value; }
        }
        public bool Revanche
        {
            get { return revanche_; }
            set { revanche_ = value; }
        }
        public bool Église
        {
            get { return église_; }
            set { église_ = value; }
        }
        public bool Ents
        {
            get { return ents_; }
            set { ents_ = value; Infantrie = "Ents"; }
        }
        public bool ElfsAméloirés
        {
            get { return elfsAméliorés_; }
            set { elfsAméliorés_ = value; }
        }
        public bool Nécromancie
        {
           get { return nécromantie_; }
           set { nécromantie_ = value; }
        }
        public bool Magogs
        {
            get { return magogs_; }
            set { magogs_ = value; Archer = "Magogs"; }
        }
        public int PrixRevanche
        {
            get { return prixRevanche_; }
            set { prixRevanche_ = value; }
        }
        public int PrixÉglise
        {
            get { return prixÉglise_; }
            set { prixÉglise_ = value; }
        }
        public int PrixNécromancie
        {
            get { return prixNécromancie_; }
            set { prixNécromancie_ = value; }
        }
        public int BonusNécromancie
        {
           get { return bonusNécromancie_; }
           set { bonusNécromancie_ = value; }
        }
        bool estCPU_;
        bool estJoueur2_;
        string alignement_;
        string race_;
        string nom_;
        string infantrie_;
        string cavalrie_;
        string archer_;
        string volant_;
        bool bon_;
        bool mauvais_;
        bool humain_;
        bool créature_;
        bool chevalier_;
        bool êtreForêt_;
        bool démoniaque_;
        bool nécromantien_;
        bool revanche_;
        bool église_;
        bool ents_;
        bool elfsAméliorés_;
        bool nécromantie_;
        bool magogs_;
        bool arcsLongs_;
        int prixRevanche_;
        int prixÉglise_;
        int prixNécromancie_;
        int or_;
        int score_;
        int nbCombats_;
        int bonusÉglise_;
        int bonusNécromancie_;
        float expérience_;
        float bonusRevanche_;
        Armée arméeJoueur_;
        ConsoleColor couleur_;
        ConsoleColor couleur2_;
        #endregion
    }
}
