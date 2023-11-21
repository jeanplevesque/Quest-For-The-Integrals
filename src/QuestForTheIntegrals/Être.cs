using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    abstract class Être
    {
        static Être()
        {
            Rnd = new Random();
        }
        public Être(int maxVie, float pointsDégâts, int prix,int vitesse,string type)
        {
            Vitesse = vitesse;
            Prix = prix;
            MaxVie = maxVie;
            PointDeVie = maxVie;
            PointsDégât = pointsDégâts;
            Type = type;
        }
        public Être(int maxVie, float pointsDégâts, int prix, int vitesse,float portée,string type)
        {
            Vitesse = vitesse;
            Prix = prix;
            MaxVie = maxVie;
            PointDeVie = maxVie;
            PointsDégât = pointsDégâts;
            Portée = portée;
            Type = type;
        }
        public float Attaquer()
        {
            return PointsDégât*PointDeVie/MaxVie;
        }
        #region Propriétés
        public string Nom
        {
            get { return nom_; }
            set { nom_ = value; }
        }
        public string Type
        {
            get { return type_; }
            set { type_ = value; }
        }
        public float PointDeVie
        {
            get { return pointsDeVie_; }
            set
            {
                pointsDeVie_ = value;
                //if (value > MaxVie)
                //{
                //    pointsDeVie_ = MaxVie;
                //}
                //else
                //{
                //    pointsDeVie_ = value;
                //}
            }
        }
        public int MaxVie
        {
            get { return maxVie_; }
            set { maxVie_ = value; }
        }
        public float PointsDégât
        {
            get { return pointsDégâts_; }
            set { pointsDégâts_ = value; }
        }
        public float Portée
        {
            get { return portée_; }
            set { portée_ = value; }
        }
        public int Prix
        {
            get { return prix_; }
            set { prix_ = value; }
        }
        public static Random Rnd
        {
            get { return rnd_; }
            set { rnd_ = value; }
        }
        public int Vitesse
        {
            get { return vitesse_; }
            set { vitesse_ = value; }
        }
        string type_;
        float portée_;
        string nom_;
        float pointsDeVie_;
        int maxVie_;
        float pointsDégâts_;
        int prix_;
        int vitesse_;
        static Random rnd_;
        #endregion
        
    }
}
