using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Quest_For_The_Integrals
{
    class Carte
    {
        Case[,] grille_;
        Stack plusCourtChemin_;
        int largeurCarte_;
        int hauteurCarte_;
        Équipe équipeEnnemie_;
        Équipe équipeJoueur_;

        public Carte(string nomCarte,Équipe ÉquipeJoueur,Équipe ÉquipeEnnemie)
        {
            LÉquipeEnnemie = ÉquipeEnnemie;
            LÉquipeJoueur = ÉquipeJoueur;
            StreamReader longueur=new StreamReader(nomCarte);
            Largeur = longueur.ReadLine().Length;
            longueur.Close();
            Hauteur = 20;
            Grille = new Case[Largeur, Hauteur];
            StreamReader lecteur = new StreamReader(nomCarte);
            int j = 0;
            do
            {
                string chaîne = lecteur.ReadLine();
                for (int i = 0; i < chaîne.Length; ++i)
                {
                    Grille[i, j] = new Case(chaîne[i]);
                }
                ++j;
            }
            while (!lecteur.EndOfStream);

            Grille[9, 5].Symbole = ÉquipeJoueur.ArméeJoueur.Volant.Symbole;
            ÉquipeJoueur.ArméeJoueur.Volant.Pos = new Position(9, 5);
            Grille[9, 8].Symbole = ÉquipeJoueur.ArméeJoueur.Infantrie.Symbole;
            ÉquipeJoueur.ArméeJoueur.Infantrie.Pos = new Position(9, 8);
            Grille[9, 11].Symbole = ÉquipeJoueur.ArméeJoueur.Cavalrie.Symbole;
            ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos = new Position(9, 11);
            Grille[9, 14].Symbole = ÉquipeJoueur.ArméeJoueur.Archer.Symbole;
            ÉquipeJoueur.ArméeJoueur.Archer.Pos = new Position(9, 14);

            Grille[Largeur - 7, 5].Symbole = ÉquipeEnnemie.ArméeJoueur.Volant.Symbole;
            ÉquipeEnnemie.ArméeJoueur.Volant.Pos = new Position(Largeur-7, 5);
            Grille[Largeur - 7, 8].Symbole = ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole;
            ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos = new Position(Largeur - 7, 8);
            Grille[Largeur - 7, 11].Symbole = ÉquipeEnnemie.ArméeJoueur.Cavalrie.Symbole;
            ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos = new Position(Largeur - 7, 11);
            Grille[Largeur - 7, 14].Symbole = ÉquipeEnnemie.ArméeJoueur.Archer.Symbole;
            ÉquipeEnnemie.ArméeJoueur.Archer.Pos = new Position(Largeur - 7, 14);


        }
        public Équipe LÉquipeJoueur
        {
            get { return équipeJoueur_; }
            set { équipeJoueur_ = value; }
        }
        public Équipe LÉquipeEnnemie
        {
            get { return équipeEnnemie_; }
            set { équipeEnnemie_ = value; }
        }
        public int Hauteur
        {
            get { return hauteurCarte_; }
            set { hauteurCarte_ = value; }
        }
        public int Largeur
        {
            get { return largeurCarte_; }
            set { largeurCarte_ = value; }
        }

        public Case[,] Grille
        {
            get { return grille_; }
            private set { grille_ = value; }
        }

        public Stack PlusCourtChemin
        {
            get { return plusCourtChemin_; }
            private set { plusCourtChemin_ = value; }
        }

        public void CalculerPoids(GroupeMilitaire départ,GroupeMilitaire cible)
        {
            Grille[départ.Pos.PosX, départ.Pos.PosY].Poids = 0;
            AppliquerPoids(1, départ.Pos.PosX, départ.Pos.PosY,cible);
        }
        public void CalculerPoids(GroupeMilitaire départ)
        {
            Grille[départ.Pos.PosX, départ.Pos.PosY].Poids = 0;
            AppliquerPoids(1, départ.Pos.PosX, départ.Pos.PosY);
        }

        public void TrouverPlusCourtChemin(GroupeMilitaire cible)
        {
            PlusCourtChemin = new Stack();
            PlusCourtChemin.Push(new Position(cible.Pos.PosX, cible.Pos.PosY));
            FaireChemin(Grille[cible.Pos.PosX, cible.Pos.PosY].Poids, cible.Pos.PosX, cible.Pos.PosY);
        }

        private void AppliquerPoids(int poids, int x, int y,GroupeMilitaire cible)
        {
            if (Grille[x - 1, y].EstAccessible(cible) && Grille[x - 1, y].Poids > poids)
            {
                Grille[x - 1, y].Poids = poids;

                AppliquerPoids(poids + 1, x - 1, y,cible);
            }
            if (Grille[x + 1, y].EstAccessible(cible) && Grille[x + 1, y].Poids > poids)
            {
                Grille[x + 1, y].Poids = poids;

                AppliquerPoids(poids + 1, x + 1, y, cible);
            }
            if (Grille[x, y + 1].EstAccessible(cible) && Grille[x, y + 1].Poids > poids)
            {
                Grille[x, y + 1].Poids = poids;

                AppliquerPoids(poids + 1, x, y + 1, cible);
            }
            if (Grille[x, y - 1].EstAccessible(cible) && Grille[x, y - 1].Poids > poids)
            {
                Grille[x, y - 1].Poids = poids;

                AppliquerPoids(poids + 1, x, y - 1, cible);
            }
        }
        private void AppliquerPoids(int poids, int x, int y)
        {
            if (!Grille[x - 1, y].EstInaccessible && Grille[x - 1, y].Poids > poids)
            {
                Grille[x - 1, y].Poids = poids;

                AppliquerPoids(poids + 1, x - 1, y);
            }
            if (!Grille[x + 1, y].EstInaccessible && Grille[x + 1, y].Poids > poids)
            {
                Grille[x + 1, y].Poids = poids;

                AppliquerPoids(poids + 1, x + 1, y);
            }
            if (!Grille[x, y + 1].EstInaccessible && Grille[x, y + 1].Poids > poids)
            {
                Grille[x, y + 1].Poids = poids;

                AppliquerPoids(poids + 1, x, y + 1);
            }
            if (!Grille[x, y - 1].EstInaccessible && Grille[x, y - 1].Poids > poids)
            {
                Grille[x, y - 1].Poids = poids;

                AppliquerPoids(poids + 1, x, y - 1);
            }
        }
        private void FaireChemin(int poids, int x, int y)
        {
            if (!Grille[x + 1, y].EstInaccessible && Grille[x + 1, y].Poids == poids-1 )
            {
                PlusCourtChemin.Push(new Position(x + 1, y));
                --poids;
                FaireChemin(poids, x + 1, y);
            }
            else if (!Grille[x - 1, y].EstInaccessible && Grille[x - 1, y].Poids == poids - 1)
            {
                PlusCourtChemin.Push(new Position(x - 1, y));
                --poids;
                FaireChemin(poids, x - 1, y);
            }
            else if (!Grille[x, y + 1].EstInaccessible && Grille[x, y + 1].Poids == poids - 1)
            {
                PlusCourtChemin.Push(new Position(x, y + 1));
                --poids;
                FaireChemin(poids, x, y + 1);
            }
            else if (!Grille[x, y - 1].EstInaccessible && Grille[x, y - 1].Poids == poids - 1)
            {
                PlusCourtChemin.Push(new Position(x, y - 1));
                --poids;
                FaireChemin(poids, x, y - 1);
            }

        }
        public void Afficher(int nbTours)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Tour# {0}", nbTours);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int j = 0; j < Hauteur; ++j)
            {
                for (int i = 0; i < Largeur; ++i)
                {
                    //if (Grille[i, j].Poids != int.MaxValue&&(Grille[i, j].Symbole == ' ' ||Grille[i, j].Symbole == 'A' || Grille[i, j].Symbole == 'V' || Grille[i, j].Symbole == 'C' || Grille[i, j].Symbole == 'I'||Grille[i, j].Symbole == 'a' || Grille[i, j].Symbole == 'v' || Grille[i, j].Symbole == 'c' || Grille[i, j].Symbole == 'i'))
                    //{
                    //    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    //}
                    if ((j > 2) && (Grille[i, j].Symbole == 'A' || Grille[i, j].Symbole == 'V' || Grille[i, j].Symbole == 'C' || Grille[i, j].Symbole == 'I'))
                    {
                        Console.ForegroundColor = LÉquipeJoueur.Couleur;
                        Console.Write(Grille[i, j].Symbole);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if ((j > 2) && (Grille[i, j].Symbole == 'a' || Grille[i, j].Symbole == 'v' || Grille[i, j].Symbole == 'c' || Grille[i, j].Symbole == 'i'))
                    {
                        Console.ForegroundColor = LÉquipeEnnemie.Couleur;
                        Console.Write(Grille[i, j].Symbole);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (Grille[i, j].Symbole == '#' && Être.Rnd.Next() % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(Grille[i, j].Symbole);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (Grille[i, j].Symbole == '.')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(Grille[i, j].Symbole);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (Grille[i, j].Symbole == ',')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(Grille[i, j].Symbole);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(Grille[i, j].Symbole);
                    }
                    //Console.BackgroundColor = ConsoleColor.Black;

                }
                Console.WriteLine();
            }
        }
        public void AfficherCarteAvecAura(Équipe ÉquipeJoueur,GroupeMilitaire Groupe, int pasRestant,int nbTours)
        {
            Initialiser();
            CalculerPoids(Groupe);
            for (int j = 0; j < Hauteur; ++j)
            {
                for (int i = 0; i < Largeur; ++i)
                {
                    if (((Être)Groupe.Troupes[0]).Type == "Archer" && MoteurDeJeu.CalculerDistance(Groupe, new Position(i, j)) <= ((Être)Groupe.Troupes[0]).Portée&& !Grille[i, j].EstInaccessible&&Grille[i,j].Poids!=int.MaxValue)
                    {
                        Grille[i, j].Symbole = ',';
                    }
                    if (Grille[i, j].Poids <= pasRestant && !Grille[i, j].EstInaccessible)
                    {
                        Grille[i, j].Symbole = '.';
                    }
                    
                }
            }
            Afficher(nbTours);
            Initialiser();
        }
        public void Initialiser()
        {
            for (int j = 0; j < Hauteur; ++j)
            {
                for (int i = 0; i < Largeur; ++i)
                {
                    Grille[i, j].Poids = int.MaxValue;
                    if (Grille[i, j].Symbole == '.' || Grille[i, j].Symbole == ',')
                    {
                        Grille[i, j].Symbole = ' ';
                    }
                }
            }
        }
    }
}
