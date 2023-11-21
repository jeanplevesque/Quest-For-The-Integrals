using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    class Armée
    {
        public Armée(Équipe équipeJoueur)
        {
            Infantrie = new GroupeMilitaire('i');
            Cavalrie = new GroupeMilitaire('c');
            Archer = new GroupeMilitaire('a');
            Volant = new GroupeMilitaire('v');
            ÉquipeJoueur = équipeJoueur;
        }

        public float Attaquer(ArrayList Groupe)
        {
            float attaque=0;
            foreach (Être i in Groupe)
            {
                attaque += i.Attaquer();
            }
            if (ÉquipeJoueur.Bon)
            {
                attaque *= 1.25f;
            }
            return attaque;
        }
        public void SubirDégâts(GroupeMilitaire GroupeVictime, Attaque AttaqueEnnemie,Équipe ÉquipeEnnemie, int nbTours)
        {
            int nbMorts = 0;
            float dégâts = AttaqueEnnemie.Dégâts;
            float lesDégâts = dégâts;
            while (dégâts != 0&&GroupeVictime.Troupes.Count>0)
            {
                if (dégâts < ((Être)GroupeVictime.Troupes[0]).PointDeVie)
                {
                    ((Être)GroupeVictime.Troupes[0]).PointDeVie -= dégâts;
                    dégâts = 0;   
                }
                else
                {
                    dégâts -= ((Être)GroupeVictime.Troupes[0]).PointDeVie;
                    if (ÉquipeEnnemie.Humain)
                    {
                        ÉquipeEnnemie.Expérience += ((Être)GroupeVictime.Troupes[0]).MaxVie * 1.25f;
                    }
                    else
                    {
                        ÉquipeEnnemie.Expérience += ((Être)GroupeVictime.Troupes[0]).MaxVie;
                    }
                    if (ÉquipeEnnemie.Mauvais)
                    {
                        ÉquipeEnnemie.Or += (int)(((Être)GroupeVictime.Troupes[0]).Prix * 1.25f);
                    }
                    else
                    {
                        ÉquipeEnnemie.Or += ((Être)GroupeVictime.Troupes[0]).Prix;
                    }
                    GroupeVictime.Troupes.Remove((Être)GroupeVictime.Troupes[0]);
                    ++nbMorts;
                    #region Nécromancie
                    if (ÉquipeEnnemie.Nécromancie && Être.Rnd.Next(1, ÉquipeEnnemie.BonusNécromancie+1) == 1)
                    {
                        if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count == 0 && !ÉquipeEnnemie.EstCPU && ÉquipeEnnemie.EstJoueur2)
                        {
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole = 'i';
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos = new Position(9, 27);
                            Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosY].Symbole = ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole;
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
                            Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                            Console.WriteLine("     Vous avez un mort vivant de plus dans votre armée!");
                            System.Threading.Thread.Sleep(50);
                        }
                        else if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count == 0 && !ÉquipeEnnemie.EstCPU && !ÉquipeEnnemie.EstJoueur2)
                        {
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole = 'I';
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos = new Position(9, 8);
                            Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosY].Symbole = ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole;
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
                            Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                            Console.WriteLine("     Vous avez un mort vivant de plus dans votre armée!");
                            System.Threading.Thread.Sleep(50);
                        }
                        else
                        {
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
                            Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                            Console.WriteLine("     Vous avez un mort vivant de plus dans votre armée!");
                            System.Threading.Thread.Sleep(50);
                        }
                        //System.Threading.Thread.Sleep(100);
                    }
                    #endregion
                    if (GroupeVictime.Troupes.Count == 0)
                    {
                        dégâts = 0;
                        Terrain.Grille[GroupeVictime.Pos.PosX, GroupeVictime.Pos.PosY].Symbole = ' ';
                        GroupeVictime.Pos = new Position(2, 2);
                    }
                }                
            }
            Terrain.Afficher(nbTours);
            MoteurDeJeu.AfficherDeuxÉquipes(ÉquipeEnnemie, ÉquipeJoueur);
            Console.ForegroundColor = ÉquipeEnnemie.Couleur;
            Console.WriteLine("     Vous avez infligé {0} pts de dégâts!", lesDégâts);
            Console.WriteLine("     Vous avez tué {0} unités!", nbMorts);

            System.Threading.Thread.Sleep(1500);
            #region Riposte
            if (ÉquipeJoueur.Revanche && ÉquipeJoueur.ÊtreForêt && Être.Rnd.Next(1, 4) == 1 && !AttaqueEnnemie.EstAttaqueDistance && GroupeVictime.Troupes.Count > 0)
            {
                Attaque riposte = new Attaque(ÉquipeJoueur.ArméeJoueur.Attaquer(GroupeVictime.Troupes) * ÉquipeJoueur.BonusRevanche, GroupeVictime,false);
                #region Bonus
                if (((Être)GroupeVictime.Troupes[0]).Type == "Infantrie" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Cavalrie")
                {
                    riposte.Dégâts *= 2;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Cavalrie" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Archer")
                {
                    riposte.Dégâts *= 1.5f;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Archer" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Infantrie")
                {
                    riposte.Dégâts *= 1.5f;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Archer" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Volant")
                {
                    riposte.Dégâts *= 1.25f;
                }
                if (((Être)GroupeVictime.Troupes[0]).Type == "Archer")
                {
                    riposte.Dégâts /= 2;
                }
                #endregion
                ÉquipeEnnemie.ArméeJoueur.SubirDégâts(AttaqueEnnemie.GroupeAttaquant, riposte, ÉquipeJoueur, nbTours,true);
            }
            if (ÉquipeJoueur.Revanche && !ÉquipeJoueur.ÊtreForêt && Être.Rnd.Next() % 2 == 0 && !AttaqueEnnemie.EstAttaqueDistance && GroupeVictime.Troupes.Count > 0)
            {
                Attaque riposte = new Attaque(ÉquipeJoueur.ArméeJoueur.Attaquer(GroupeVictime.Troupes) * ÉquipeJoueur.BonusRevanche, GroupeVictime,false);
                #region Bonus
                if (((Être)GroupeVictime.Troupes[0]).Type == "Infantrie" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Cavalrie")
                {
                    riposte.Dégâts *= 2;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Cavalrie" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Archer")
                {
                    riposte.Dégâts *= 1.5f;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Archer" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Infantrie")
                {
                    riposte.Dégâts *= 1.5f;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Archer" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Volant")
                {
                    riposte.Dégâts *= 1.25f;
                }
                if (((Être)GroupeVictime.Troupes[0]).Type == "Archer")
                {
                    riposte.Dégâts /= 2;
                }
                #endregion
                ÉquipeEnnemie.ArméeJoueur.SubirDégâts(AttaqueEnnemie.GroupeAttaquant, riposte, ÉquipeJoueur, nbTours,true);
            }
            #endregion

        }
        public void SubirDégâts(GroupeMilitaire GroupeVictime, Attaque AttaqueEnnemie, Équipe ÉquipeEnnemie, int nbTours, bool estRiposte)
        {
            int nbMorts = 0;
            float dégâts = AttaqueEnnemie.Dégâts;
            float lesDégâts = dégâts;
            while (dégâts != 0 && GroupeVictime.Troupes.Count > 0)
            {
                if (dégâts < ((Être)GroupeVictime.Troupes[0]).PointDeVie)
                {
                    ((Être)GroupeVictime.Troupes[0]).PointDeVie -= dégâts;
                    dégâts = 0;
                }
                else
                {
                    dégâts -= ((Être)GroupeVictime.Troupes[0]).PointDeVie;
                    if (ÉquipeEnnemie.Humain)
                    {
                        ÉquipeEnnemie.Expérience += ((Être)GroupeVictime.Troupes[0]).MaxVie * 1.25f;
                    }
                    else
                    {
                        ÉquipeEnnemie.Expérience += ((Être)GroupeVictime.Troupes[0]).MaxVie;
                    }
                    if (ÉquipeEnnemie.Mauvais)
                    {
                        ÉquipeEnnemie.Or += (int)(((Être)GroupeVictime.Troupes[0]).Prix * 1.25f);
                    }
                    else
                    {
                        ÉquipeEnnemie.Or += ((Être)GroupeVictime.Troupes[0]).Prix;
                    }
                    GroupeVictime.Troupes.Remove((Être)GroupeVictime.Troupes[0]);
                    ++nbMorts;
                    #region Nécromancie
                    if (ÉquipeEnnemie.Nécromancie && Être.Rnd.Next(1, ÉquipeEnnemie.BonusNécromancie + 1) == 1)
                    {
                        if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count == 0 && !ÉquipeEnnemie.EstCPU && ÉquipeEnnemie.EstJoueur2)
                        {
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole = 'i';
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos = new Position(9, 27);
                            Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosY].Symbole = ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole;
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
                            Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                            Console.WriteLine("     Vous avez un mort vivant de plus dans votre armée!");
                            System.Threading.Thread.Sleep(50);
                        }
                        else if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count == 0 && !ÉquipeEnnemie.EstCPU && !ÉquipeEnnemie.EstJoueur2)
                        {
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole = 'I';
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos = new Position(9, 8);
                            Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosY].Symbole = ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole;
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
                            Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                            Console.WriteLine("     Vous avez un mort vivant de plus dans votre armée!");
                            System.Threading.Thread.Sleep(50);
                        }
                        else
                        {
                            ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
                            Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                            Console.WriteLine("     Vous avez un mort vivant de plus dans votre armée!");
                            System.Threading.Thread.Sleep(50);
                        }
                        //System.Threading.Thread.Sleep(100);
                    }
                    #endregion
                    if (GroupeVictime.Troupes.Count == 0)
                    {
                        dégâts = 0;
                        Terrain.Grille[GroupeVictime.Pos.PosX, GroupeVictime.Pos.PosY].Symbole = ' ';
                        GroupeVictime.Pos = new Position(2, 2);
                    }
                }
            }
            Terrain.Afficher(nbTours);
            MoteurDeJeu.AfficherDeuxÉquipes(ÉquipeEnnemie, ÉquipeJoueur);
            Console.ForegroundColor = ÉquipeEnnemie.Couleur;
            Console.WriteLine("     Vous avez infligé {0} pts de dégâts en ripostant !", lesDégâts);
            Console.WriteLine("     Vous avez tué {0} unités!", nbMorts);
            System.Threading.Thread.Sleep(1500);
            #region Riposte
            if (ÉquipeJoueur.Revanche && ÉquipeJoueur.ÊtreForêt && Être.Rnd.Next(1, 4) == 1 && !AttaqueEnnemie.EstAttaqueDistance && GroupeVictime.Troupes.Count > 0)
            {
                Attaque riposte = new Attaque(ÉquipeJoueur.ArméeJoueur.Attaquer(GroupeVictime.Troupes) * ÉquipeJoueur.BonusRevanche, GroupeVictime, false);
                #region Bonus
                if (((Être)GroupeVictime.Troupes[0]).Type == "Infantrie" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Cavalrie")
                {
                    riposte.Dégâts *= 2;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Cavalrie" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Archer")
                {
                    riposte.Dégâts *= 1.5f;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Archer" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Infantrie")
                {
                    riposte.Dégâts *= 1.5f;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Archer" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Volant")
                {
                    riposte.Dégâts *= 1.25f;
                }
                if (((Être)GroupeVictime.Troupes[0]).Type == "Archer")
                {
                    riposte.Dégâts /= 2;
                }
                #endregion
                ÉquipeEnnemie.ArméeJoueur.SubirDégâts(AttaqueEnnemie.GroupeAttaquant, riposte, ÉquipeJoueur, nbTours, true);
            }
            if (ÉquipeJoueur.Revanche && !ÉquipeJoueur.ÊtreForêt && Être.Rnd.Next() % 2 == 0 && !AttaqueEnnemie.EstAttaqueDistance && GroupeVictime.Troupes.Count > 0)
            {
                Attaque riposte = new Attaque(ÉquipeJoueur.ArméeJoueur.Attaquer(GroupeVictime.Troupes) * ÉquipeJoueur.BonusRevanche, GroupeVictime, false);
                #region Bonus
                if (((Être)GroupeVictime.Troupes[0]).Type == "Infantrie" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Cavalrie")
                {
                    riposte.Dégâts *= 2;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Cavalrie" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Archer")
                {
                    riposte.Dégâts *= 1.5f;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Archer" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Infantrie")
                {
                    riposte.Dégâts *= 1.5f;
                }
                else if (((Être)GroupeVictime.Troupes[0]).Type == "Archer" && ((Être)AttaqueEnnemie.GroupeAttaquant.Troupes[0]).Type == "Volant")
                {
                    riposte.Dégâts *= 1.25f;
                }
                if (((Être)GroupeVictime.Troupes[0]).Type == "Archer")
                {
                    riposte.Dégâts /= 2;
                }
                #endregion
                ÉquipeEnnemie.ArméeJoueur.SubirDégâts(AttaqueEnnemie.GroupeAttaquant, riposte, ÉquipeJoueur, nbTours, true);
            }
            #endregion
        }
        
        #region Propriétés
        public Équipe ÉquipeJoueur
        {
            get { return équipeJoueur_; }
            set { équipeJoueur_ = value; }
        }
        public bool Anéantie
        {
            get { return NbUnités == 0; }
        }
        public float NbUnités
        {
            get { return Infantrie.Troupes.Count + Cavalrie.Troupes.Count + Archer.Troupes.Count + Volant.Troupes.Count; }
        }
        public GroupeMilitaire Infantrie
        {
            get { return infantrie_; }
            set { infantrie_ = value; }
        }
        public GroupeMilitaire Cavalrie
        {
            get { return cavalrie_; }
            set { cavalrie_ = value; }
        }
        public GroupeMilitaire Archer
        {
            get { return archer_; }
            set { archer_ = value; }
        }
        public GroupeMilitaire Volant
        {
            get { return volant_; }
            set { volant_ = value; }
        }
        public Carte Terrain
        {
            get { return terrain_; }
            set { terrain_ = value; }
        }
#endregion 
        GroupeMilitaire infantrie_;
        GroupeMilitaire cavalrie_;
        GroupeMilitaire archer_;
        GroupeMilitaire volant_;
        Équipe équipeJoueur_;
        Carte terrain_;
    }
}
