using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace Quest_For_The_Integrals
{
   class MoteurDeJeu
   {
      public static void Run()
      {
         Intro();
         MenuPrincipal();
      }
      static void JouerMusique(int temps)
      {
         Note n = new Note();
         #region Musique
         n.Do(temps + temps / 2);
         n.Si_(temps / 2);
         n.Do(temps);
         n.Ré(temps);
         n.Mib(temps);
         n.Ré(temps);
         n.Mib(temps);
         n.Fa(temps);
         n.Sol(temps);
         n.Mib(temps);
         n.Sol(temps);
         n.Ré(temps);
         n.Si_(temps);
         n.Do(temps / 2);
         n.Ré(temps / 2);
         n.Mib(temps / 2);
         n.Ré(temps / 2);
         n.Mib(temps / 2);
         n.Fa(temps / 2);
         n.Mib(temps / 2);
         n.Fa(temps / 2);
         n.Sol(temps);
         n.Mib(temps / 2);
         n.Ré(temps / 2);
         n.Mib(temps);
         n.Mib(temps / 2);
         n.Ré(temps / 2);
         n.Do(temps / 2);
         n.Si_(temps / 2);
         n.Do(temps * 5);
         #endregion
      }
      static void JouerMusiqueDidacticiel(int temps)
      {
         #region Musique
         Note n = new Note();

         n.Dox(temps / 2);
         n.Sol_(temps / 4); n.Mi(temps / 4);
         n.Sol_(temps / 4); n.Mi(temps / 4);
         n.Mix(temps / 4); n.Mi(temps / 8); n.Sol_(temps / 8);
         n.Réx(temps / 4); n.Mi(temps / 8); n.Sol_(temps / 8);
         n.Sol_(temps / 4); n.Mi(temps / 4);
         n.Solx(temps / 4); n.Mi(temps / 4);
         n.Sol_(temps / 4); n.Mi(temps / 4);
         n.Lax(temps / 2);
         n.Mi_(temps / 4); n.Do(temps / 4);
         n.Mi_(temps / 4); n.Do(temps / 4);
         n.Mi_(temps / 8); n.Do(temps / 8);
         n.Mix(temps / 8);
         n.Réx(temps / 8);
         n.Dox(temps / 2);
         n.Sol_(temps / 4); n.Do(temps / 4);
         n.Sol_(temps / 4); n.Do(temps / 4);
         n.Sol_(temps / 4); n.Do(temps / 4);

         n.Dox(temps / 2);
         n.Fa_(temps / 4); n.La_(temps / 4);
         n.Fa_(temps / 4); n.La_(temps / 4);
         n.Mix(temps / 4);
         n.Fa_(temps / 8); n.La_(temps / 8);
         n.Réx(temps / 4);
         n.Sol_(temps / 8); n.Si_(temps / 8);
         n.Sol_(temps / 4); n.Si_(temps / 4);
         n.Dox(temps / 4); n.Sol_(temps / 8); n.Si_(temps / 8);
         n.Si(temps / 4); n.Sol_(temps / 8); n.Si_(temps / 8);
         n.Dox(temps / 4);
         n.Do(temps / 4); n.Sol(temps / 4);
         n.Do(temps / 4); n.Sol(temps / 4);
         n.Do(temps / 4); n.Solb(temps / 4);
         n.Do(temps / 4); n.Sol(temps * 2);
         #endregion
      }
      static void Intro()
      {
         Console.ForegroundColor = ConsoleColor.Gray;
         Console.Title = "   Quest For The Integrals";
         Console.WindowHeight = 58;
         Console.WindowWidth = 110;
         StreamReader lecteur = new StreamReader("Settings.txt");
         lecteur.ReadLine();
         if (lecteur.ReadLine() == "O")
         {
             Case[,]Image = new Case[106, 56];
             StreamReader lecteur2 = new StreamReader("Logo.txt");
             int u = 0;
             do
             {
                 string chaîne = lecteur2.ReadLine();
                 for (int i = 0; i < chaîne.Length; ++i)
                 {
                     Image[i, u] = new Case(chaîne[i]);
                 }
                 ++u;
             }
             while (!lecteur2.EndOfStream);
             lecteur2.Close();
             for (int j = 0; j < 55; ++j)
             {
                 for (int i = 0; i < 106; ++i)
                 {

                     if (Image[i, j].Symbole == '.' || Image[i, j].Symbole == ';')
                     {
                         Console.ForegroundColor = ConsoleColor.DarkBlue;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if ( Image[i, j].Symbole == '=')
                     {
                         Console.ForegroundColor = ConsoleColor.Blue;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == '+' )
                     {
                         Console.ForegroundColor = ConsoleColor.Cyan;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'B')
                     {
                         Console.ForegroundColor = ConsoleColor.Red;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'X')
                     {
                         Console.ForegroundColor = ConsoleColor.Yellow;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'Y')
                     {
                         Console.ForegroundColor = ConsoleColor.Green;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'V')
                     {
                         Console.ForegroundColor = ConsoleColor.Magenta;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 't')
                     {
                         Console.ForegroundColor = ConsoleColor.White;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'M')
                     {
                         Console.ForegroundColor = ConsoleColor.DarkYellow;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'R')
                     {
                         Console.ForegroundColor = ConsoleColor.DarkRed;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'I')
                     {
                         Console.ForegroundColor = ConsoleColor.Magenta;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'i')
                     {
                         Console.ForegroundColor = ConsoleColor.Green;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == 'W')
                     {
                         Console.ForegroundColor = ConsoleColor.Yellow;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else if (Image[i, j].Symbole == '#')
                     {
                         Console.ForegroundColor = ConsoleColor.White;
                         Console.Write(Image[i, j].Symbole);
                         Console.ForegroundColor = ConsoleColor.Gray;
                     }
                     else
                     {
                         Console.Write(Image[i, j].Symbole);
                     }
                 }
                 Console.WriteLine();
             }
             Console.Write("                                                   Fait par Jean-Philippe Lévesque");
             //System.Threading.Thread.Sleep(5000);
             JouerMusique(240);
         }
         lecteur.Close();
      }
      static void MenuPrincipal()
      {
         Console.ForegroundColor = ConsoleColor.Gray;
         Console.Clear();
         FichierTexte Image = new FichierTexte("Image.txt");
         while (!Image.EOF)
         {
            Console.WriteLine(Image.LireChaîne());
         }
         char key = 'a';
         while (key != 'o' && key != 's' && key != 'd' && key != 'j' && key != 'm')
         {
            key = Console.ReadKey().KeyChar;
            if (key == '5')
            {
               JouerMusique(240);
               key = 'a';
            }
            if (key == '2')
            {
               JouerMusiqueDidacticiel(480);
               key = 'a';
            }
         }
         if (key == 'd')
         {
            Didactitiel();
         }
         else if (key == 'm')
         {
            NouvellePartieMultijoueur();
         }
         else if (key == 's')
         {
             try
             {
                 ChargerPartie();
             }
             finally
             {
                 Console.WriteLine("        Aucune partie sauvegardée");
                 System.Threading.Thread.Sleep(1200);
                 MenuPrincipal();
             }
         }
         else if (key == 'o')
         {
             OptionsIntro();
             MenuPrincipal();
         }
         else
         {
            NouvellePartieSolo();
         }
      }

      static void ChargerPartie()
      {
          Équipe ÉquipeJoueur= ChargerÉquipe();
          bool VousÊtesMort = false;
          while (!VousÊtesMort)
          {
              Équipe ÉquipeEnnemie = CréerCPU(ÉquipeJoueur);
              ÉquipeEnnemie.EstCPU = true;
              Console.ForegroundColor = ÉquipeJoueur.Couleur;
              MenuJeu(ÉquipeJoueur);
              int xpAvant = (int)ÉquipeJoueur.Expérience;
              Console.WindowWidth = 120;
              CombatContreCPU(ÉquipeJoueur, ÉquipeEnnemie);
              Console.WindowWidth = 107;
              ÉquipeJoueur.Expérience += 300;
              ÉquipeJoueur.Or += 100;
              ÉquipeJoueur.Score += (int)ÉquipeJoueur.Expérience - xpAvant;
              if (ÉquipeJoueur.ArméeJoueur.NbUnités == 0)
              {
                  VousÊtesMort = true;
              }
              ++ÉquipeJoueur.NbCombats;
          }
          GameOver(ÉquipeJoueur);
      }
      static void Didactitiel()
      {
         AfficherMenuDidacticiel();
         Équipe ÉquipeJoueur = ChoixÉquipe();
         Équipe ÉquipeEnnemie = CréerCPU(ÉquipeJoueur);
         ÉquipeEnnemie.EstCPU = true;
         Console.ForegroundColor = ÉquipeJoueur.Couleur;
         AfficherChoix(ÉquipeJoueur);
         AfficherArméeGroupesDidacticiel();
         RemplirArméeDébut(ÉquipeJoueur);
         AfficherMenuJeuDidacticiel();
         MenuJeu(ÉquipeJoueur);
         AfficherDidacticielCombat();
         CombatContreCPU(ÉquipeJoueur, ÉquipeEnnemie);
         if (ÉquipeJoueur.ArméeJoueur.Anéantie)
         {
            GameOver(ÉquipeJoueur);
         }
         else
         {
            Console.ForegroundColor = ÉquipeJoueur.Couleur;
            FinDidacticiel(ÉquipeJoueur);
         }

      }
      static void NouvellePartieMultijoueur()
      {
         Console.ForegroundColor = ConsoleColor.Gray;
         Équipe Joueur1 = CréerJoueurPourMultijoueur(1);
         Console.ForegroundColor = ConsoleColor.Gray;
         Équipe Joueur2 = CréerJoueurPourMultijoueur(2);
         Joueur2.EstJoueur2 = true;
         if (Joueur1.Couleur == Joueur2.Couleur)
         {
            Joueur2.Couleur = Joueur2.Couleur2;
         }
         Console.WindowWidth = 120;
         Combat(Joueur1, Joueur2);
         Console.WindowWidth = 107;
         if (Joueur2.ArméeJoueur.Anéantie)
         {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Joueur1.Couleur;
            Console.WriteLine("     Le vainceur est le Joueur 1 !");
            Console.Read();
         }
         else
         {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Joueur2.Couleur;
            Console.WriteLine("     Le vainceur est le Joueur 2 !");
            Console.Read();
         }
         MenuPrincipal();
      }
      static void NouvellePartieSolo()
      {
         Console.Clear();
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("     Veuillez choisir votre Race et votre Alignement.");
         Console.WriteLine();
         Console.WriteLine();
         Équipe ÉquipeJoueur = ChoixÉquipe();
         Console.ForegroundColor = ÉquipeJoueur.Couleur;
         AfficherChoix(ÉquipeJoueur);
         RemplirArméeDébut(ÉquipeJoueur);
         bool VousÊtesMort = false;
         while (!VousÊtesMort)
         {
            Équipe ÉquipeEnnemie = CréerCPU(ÉquipeJoueur);
            ÉquipeEnnemie.EstCPU = true;
            Console.ForegroundColor = ÉquipeJoueur.Couleur;
            MenuJeu(ÉquipeJoueur);
            int xpAvant = (int)ÉquipeJoueur.Expérience;
            Console.WindowWidth = 120;
            CombatContreCPU(ÉquipeJoueur, ÉquipeEnnemie);
            Console.WindowWidth = 107;
            ÉquipeJoueur.Expérience += 300;
            ÉquipeJoueur.Or+=100;
            ÉquipeJoueur.Score += (int)ÉquipeJoueur.Expérience-xpAvant;
            if (ÉquipeJoueur.ArméeJoueur.NbUnités == 0)
            {
               VousÊtesMort = true;
            }
            ++ÉquipeJoueur.NbCombats;
         }
         GameOver(ÉquipeJoueur);
      }
      static void GameOver(Équipe ÉquipeJoueur)
      {
         Console.Clear();
         FichierTexte Dead = new FichierTexte("GameOver.txt");
         while (!Dead.EOF)
         {
            Console.WriteLine(Dead.LireChaîne());
         }
         System.Threading.Thread.Sleep(3000);
         MenuPrincipal();
      }
      static void FinDidacticiel(Équipe ÉquipeJoueur)
      {
         Console.Clear();
         FichierTexte FinDidacticiel = new FichierTexte("FinDidacticiel.txt");
         while (!FinDidacticiel.EOF)
         {
            Console.WriteLine(FinDidacticiel.LireChaîne());
         }
         AfficherÉquipeJoueur(ÉquipeJoueur);
         JouerMusiqueDidacticiel(480);
         Console.ReadKey();
         MenuPrincipal();
      }

      static Équipe CréerJoueurPourMultijoueur(int noJoueur)
      {
         Console.Clear();
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("                         Joueur {0}", noJoueur);
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("     Veuillez choisir votre Race et votre Alignement.");
         Console.WriteLine();
         Console.WriteLine();
         Équipe ÉquipeJoueur = ChoixÉquipe();
         Console.ForegroundColor = ÉquipeJoueur.Couleur;
         AfficherChoix(ÉquipeJoueur);
         ÉquipeJoueur.Or = 5000;
         ÉquipeJoueur.Expérience = 5000;
         RemplirArméeDébut(ÉquipeJoueur);
         MenuJeu(ÉquipeJoueur);
         return ÉquipeJoueur;
      }
      static Équipe CréerCPU(Équipe ÉquipeJoueur)
      {
         #region Race-Alignement
         string alignement;
         string race;
         if (Être.Rnd.Next() % 2 == 0)
         {
            alignement = "Bon";
         }
         else
         {
            alignement = "Mauvais";
         }
         if (Être.Rnd.Next() % 2 == 0)
         {
            race = "Humain";
         }
         else
         {
            race = "Créature";
         }
         Équipe CPU = new Équipe(alignement, race);
         if (CPU.Couleur == ÉquipeJoueur.Couleur)
         {
            CPU.Couleur = CPU.Couleur2;
         }
         #endregion
         ActiverBonusAjouterUnité(CPU);
         if (ÉquipeJoueur.Score == 0)
         {
             for (int i = 0; i < 5; ++i)
             {
                 CPU.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
                 CPU.ArméeJoueur.Cavalrie.Troupes.Add(new Cavalrie());
             }
         }
         else
         {
             for (int i = 0; i < (int)Math.Sqrt(ÉquipeJoueur.NbCombats* ÉquipeJoueur.Score)/2.5f; ++i)
             {
                 CPU.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
             }
             for (int i = 0; i < (int)Math.Sqrt(ÉquipeJoueur.NbCombats * ÉquipeJoueur.Score) / 4; ++i)
             {
                 CPU.ArméeJoueur.Cavalrie.Troupes.Add(new Cavalrie());
             }
             for (int i = 0; i < (int)Math.Sqrt(ÉquipeJoueur.NbCombats * ÉquipeJoueur.Score) / 3; ++i)
             {
                 CPU.ArméeJoueur.Archer.Troupes.Add(new Archer());
             }
             for (int i = 0; i < (int)Math.Sqrt(ÉquipeJoueur.NbCombats * ÉquipeJoueur.Score) / 20 - 3; ++i)
             {
                 CPU.ArméeJoueur.Volant.Troupes.Add(new Volant());
             }
         }
         if (ÉquipeJoueur.NbCombats >= 3)
         {
             CPU.Revanche = true;
             CPU.BonusRevanche = (float)ÉquipeJoueur.NbCombats/10;
             if (ÉquipeJoueur.NbCombats >= 10)
             {
                 CPU.BonusRevanche = 1;
             }
         }
         DésactiverBonusAjouterUnité();
         return CPU;
      }
      static Équipe ChoixÉquipe()
      {
         bool non = true;
         string alignement = "";
         string race = "";
         do
         {
            while (race != "H" && race != "C")
            {
               Console.Write("     Race:  ");
               race = Console.ReadLine().ToUpper();
               race = Vérifier(race);
            }
            while (alignement != "B" && alignement != "M")
            {
               Console.Write("     Alignement:  ");
               alignement = Console.ReadLine().ToUpper();
               alignement = Vérifier(alignement);
            }
            if (alignement == "B")
            {
               alignement = "Bon";
            }
            else
            {
               alignement = "Mauvais";
            }
            if (race == "H")
            {
               race = "Humain";
            }
            else
            {
               race = "Créature";
            }
            Console.WriteLine();
            Console.WriteLine("     C'est paramètres vous conviennent-ils? ");
            Console.WriteLine();
            Console.WriteLine("     Alignement: {0}", alignement);
            Console.WriteLine("     Race: {0}", race);
            Console.Write("                                 Oui(O)/Non(N)  ");
            string choix = "";
            while (choix != "O" && choix != "N")
            {
               choix = Console.ReadLine().ToUpper();
            }
            if (choix == "O")
            {
               non = false;
            }

         }
         while (non);
         Équipe ÉquipeJoueur = new Équipe(alignement, race);
         ÉquipeJoueur.ArméeJoueur.Infantrie.Symbole = 'I';
         ÉquipeJoueur.ArméeJoueur.Cavalrie.Symbole = 'C';
         ÉquipeJoueur.ArméeJoueur.Archer.Symbole = 'A';
         ÉquipeJoueur.ArméeJoueur.Volant.Symbole = 'V';
         return ÉquipeJoueur;
      }
      static void RemplirArméeDébut(Équipe ÉquipeJoueur)
      {
         Console.Clear();
         AfficherÉquipeJoueur(ÉquipeJoueur);
         Console.Write("     Voulez-vous ajouter des unités?  (Oui(O)/Non(N)");
         string key;
         do
         {
            key = Console.ReadLine().ToUpper();
         }
         while (key != "O" && key != "N");
         if (key == "O")
         {
            AjouterUnités(ÉquipeJoueur);
         }
         else if (key == "N" && ÉquipeJoueur.ArméeJoueur.NbUnités == 0)
         {
            Console.WriteLine();
            Console.WriteLine("     Vous devez absolument avoir au moins une unité dans votre armée pour continuer.");
            Console.WriteLine("     Appuyer sur une touche pour continuer.");
            Console.ReadKey();
            AjouterUnités(ÉquipeJoueur);
         }
         else if (key == "N")
         {
         }

      }
      static void RemplirArmée(Équipe ÉquipeJoueur)
      {
         Console.Clear();
         AfficherÉquipeJoueur(ÉquipeJoueur);
         Console.Write("     Voulez-vous ajouter des unités?  (Oui(O)/Non(N)");
         string key;
         do
         {
            key = Console.ReadLine().ToUpper();
         }
         while (key != "O" && key != "N");
         if (key == "O")
         {
            AjouterUnités(ÉquipeJoueur);
            key = "b";
         }
         else if (key == "N")
         {
            key = "b";
         }
      }
      static void AjouterUnités(Équipe ÉquipeJoueur)
      {
          AfficherÉquipeJoueur(ÉquipeJoueur);
          string key;
          string key2 = "N";
          ActiverBonusAjouterUnité(ÉquipeJoueur);
          #region Procédure
          do
          {
              Console.Clear();
              AfficherÉquipeJoueur(ÉquipeJoueur);
              do
              {
                  Console.WriteLine("     Que souhaitez-vous ajouter? I ou Infantrie {0} pièces d'or", Infantrie.BasePrix);
                  Console.WriteLine("                                 C ou Cavalrie {0} pièces d'or", Cavalrie.BasePrix);
                  Console.WriteLine("                                 A ou Archer {0} pièces d'or", Archer.BasePrix);
                  Console.WriteLine("                                 V ou Volant {0} pièces d'or", Volant.BasePrix);
                  key = Console.ReadLine().ToUpper();
                  key = Vérifier(key);
              }
              while (key != "I" && key != "C" && key != "A" && key != "V");
              if (key == "I")
              {
                  float Nb = LireNombre(ÉquipeJoueur, Infantrie.BasePrix);
                  while (Nb * Infantrie.BasePrix > ÉquipeJoueur.Or)
                  {
                      Console.WriteLine("     Vous ne disposez pas d'assez d'or.");
                      Nb = LireNombre(ÉquipeJoueur, Infantrie.BasePrix);
                  }
                  for (float i = 0; i < Nb; ++i)
                  {
                      ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
                      ÉquipeJoueur.Or -= Infantrie.BasePrix;
                  }
              }
              else if (key == "C")
              {
                  float Nb = LireNombre(ÉquipeJoueur, Cavalrie.BasePrix);
                  while (Nb * Cavalrie.BasePrix > ÉquipeJoueur.Or)
                  {
                      Console.WriteLine("     Vous ne disposez pas d'assez d'or.");
                      Nb = LireNombre(ÉquipeJoueur, Cavalrie.BasePrix);
                  }
                  for (float i = 0; i < Nb; ++i)
                  {
                      ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Add(new Cavalrie());
                      ÉquipeJoueur.Or -= Cavalrie.BasePrix;
                  }
              }
              else if (key == "A")
              {
                  float Nb = LireNombre(ÉquipeJoueur, Archer.BasePrix);
                  while (Nb * Archer.BasePrix > ÉquipeJoueur.Or)
                  {
                      Console.WriteLine("     Vous ne disposez pas d'assez d'or.");
                      Nb = LireNombre(ÉquipeJoueur, Archer.BasePrix);
                  }
                  for (float i = 0; i < Nb; ++i)
                  {
                      ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Add(new Archer());
                      ÉquipeJoueur.Or -= Archer.BasePrix;
                  }
              }
              else if (key == "V")
              {
                  float Nb = LireNombre(ÉquipeJoueur, Volant.BasePrix);
                  while (Nb * Volant.BasePrix > ÉquipeJoueur.Or)
                  {
                      Console.WriteLine("     Vous ne disposez pas d'assez d'or.");
                      Nb = LireNombre(ÉquipeJoueur, Volant.BasePrix);
                  }
                  for (float i = 0; i < Nb; ++i)
                  {
                      ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Add(new Volant());
                      ÉquipeJoueur.Or -= Volant.BasePrix;
                  }
              }
              Console.Clear();
              AfficherÉquipeJoueur(ÉquipeJoueur);
              Console.WriteLine("     Voulez-vous ajoutez d'autres unités?  (O/N)  ");
              do
              {
                  key2 = Console.ReadLine().ToUpper();
              }
              while (key2 != "O" && key2 != "N");
          }
          while (key2 == "O");
          #endregion
          DésactiverBonusAjouterUnité();
      }
      static void MenuJeu(Équipe ÉquipeJoueur)
      {
         string key = "b";
         do
         {
            AfficherMenuJeu();
            AfficherÉquipeJoueur(ÉquipeJoueur);
            Console.WriteLine("     Appuyer sur  S  pour sauvegarder.");
            Console.WriteLine("     Appuyer sur  Q  pour quiter.");
            Console.WriteLine();
            Console.WriteLine("     Appuyer sur  A  pour obtenir des Améliorations.");
            Console.WriteLine("     Appuyer sur  U  pour acheter des Unités.");
            Console.WriteLine("     Appuyer sur  C  pour passer au prochain combat.");

            while (key != "Q" && key != "S" && key != "A" && key != "U" && key != "C" && !key.Contains("OPTION"))
            {
               key = Console.ReadLine().ToUpper();
            }
            if (key == "Q")
            {
                MenuPrincipal();
                key = "b";
            }
            if (key == "A")
            {
               ObtenirAmélioration(ÉquipeJoueur);
               key = "b";
            }
            else if (key == "U")
            {
               RemplirArmée(ÉquipeJoueur);
               key = "b";
            }
            else if (key.Contains("OPTION"))
            {
                Option(ÉquipeJoueur);
                key = "b";
            }
            else if (key=="S")
            {
                Sauvegarder(ÉquipeJoueur);
                Console.WriteLine("     Partie Sauvegardée");
                System.Threading.Thread.Sleep(800);
                key = "b";
            }
         }
         while (key != "C");
      }
      static void Combat(Équipe ÉquipeJoueur, Équipe ÉquipeEnnemie)
      {
          Carte Terrain;
          if (Être.Rnd.Next(1, 3) == 1)
          {
              Terrain = new Carte("Terrain.txt", ÉquipeJoueur, ÉquipeEnnemie);
          }
          else
          {
              Terrain = new Carte("Terrain2.txt", ÉquipeJoueur, ÉquipeEnnemie);
          }
          ÉquipeEnnemie.ArméeJoueur.Terrain = Terrain;
          ÉquipeJoueur.ArméeJoueur.Terrain = Terrain;
         int nbTours = 1;
         do
         {
             #region Vérification
             if (ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count == 0)
             {
                 ÉquipeEnnemie.ArméeJoueur.Archer.Symbole = ' ';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Archer.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Archer.Pos.PosY].Symbole = ' ';
                 ÉquipeEnnemie.ArméeJoueur.Archer.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeEnnemie.ArméeJoueur.Archer.Symbole = 'a';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Archer.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Archer.Pos.PosY].Symbole = 'a';
             }
             //
             if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count == 0)
             {
                 ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole = ' ';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosY].Symbole = ' ';
                 ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole = 'i';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosY].Symbole = 'i';
             }
             //
             if (ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count == 0)
             {
                 ÉquipeEnnemie.ArméeJoueur.Cavalrie.Symbole = ' ';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos.PosY].Symbole = ' ';
                 ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeEnnemie.ArméeJoueur.Cavalrie.Symbole = 'c';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos.PosY].Symbole = 'c';
             }
             //
             if (ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count == 0)
             {
                 ÉquipeEnnemie.ArméeJoueur.Volant.Symbole = ' ';

                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Volant.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Volant.Pos.PosY].Symbole = ' ';
                 ÉquipeEnnemie.ArméeJoueur.Volant.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeEnnemie.ArméeJoueur.Volant.Symbole = 'v';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Volant.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Volant.Pos.PosY].Symbole = 'v';
             }
             //
             if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count == 0)
             {
                 ÉquipeJoueur.ArméeJoueur.Archer.Symbole = ' ';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosY].Symbole = ' ';
                 ÉquipeJoueur.ArméeJoueur.Archer.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeJoueur.ArméeJoueur.Archer.Symbole = 'A';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosY].Symbole = 'A';
             }
             //
             if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count == 0)
             {
                 ÉquipeJoueur.ArméeJoueur.Infantrie.Symbole = ' ';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Infantrie.Pos.PosY].Symbole = ' ';
                 ÉquipeJoueur.ArméeJoueur.Infantrie.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeJoueur.ArméeJoueur.Infantrie.Symbole = 'I';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Infantrie.Pos.PosY].Symbole = 'I';
             }
             //
             if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count == 0)
             {
                 ÉquipeJoueur.ArméeJoueur.Cavalrie.Symbole = ' ';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos.PosY].Symbole = ' ';
                 ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeJoueur.ArméeJoueur.Cavalrie.Symbole = 'C';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos.PosY].Symbole = 'C';
             }
             //
             if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count == 0)
             {
                 ÉquipeJoueur.ArméeJoueur.Volant.Symbole = ' ';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Volant.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Volant.Pos.PosY].Symbole = ' ';
                 ÉquipeJoueur.ArméeJoueur.Volant.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeJoueur.ArméeJoueur.Volant.Symbole = 'V';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Volant.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Volant.Pos.PosY].Symbole = 'V';
             }
             #endregion
             Terrain.Afficher(nbTours);
             //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
             #region Tour Volant
             if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0 && ÉquipeEnnemie.ArméeJoueur.NbUnités > 0)
             {
                 AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités volantes. ");
                 GestionDéplacements(Terrain, ÉquipeJoueur, ÉquipeEnnemie, ÉquipeJoueur.ArméeJoueur.Volant, nbTours);
                 //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
                 //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 //Console.WriteLine();
                 //Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
             }
             #endregion
             #region Tour Volant
             if (ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count > 0 && ÉquipeJoueur.ArméeJoueur.NbUnités > 0)
             {
                 AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                 Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités volantes. ");
                 GestionDéplacements(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Volant, nbTours);
                 //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
                 //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 //Console.WriteLine();
                 //Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
             }
             #endregion
             #region Tour Infantrie
             if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0 && ÉquipeEnnemie.ArméeJoueur.NbUnités > 0)
             {
                 AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités d'infantrie. ");
                 GestionDéplacements(Terrain, ÉquipeJoueur, ÉquipeEnnemie, ÉquipeJoueur.ArméeJoueur.Infantrie, nbTours);
                 //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
                 //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 //Console.WriteLine();
                 //Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
             }
             #endregion
             #region Tour Infantrie
             if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count > 0 && ÉquipeEnnemie.ArméeJoueur.NbUnités > 0)
             {
                 AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                 Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités d'infantrie. ");
                 GestionDéplacements(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeJoueur.ArméeJoueur.Infantrie, nbTours);
                 //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
                 //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 //Console.WriteLine();
                 //Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
             }
             #endregion
             #region Tour Cavalrie
             if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0 && ÉquipeEnnemie.ArméeJoueur.NbUnités > 0)
             {
                 AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités de cavalrie. ");
                 GestionDéplacements(Terrain, ÉquipeJoueur, ÉquipeEnnemie, ÉquipeJoueur.ArméeJoueur.Cavalrie, nbTours);
                 //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
                 //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 //Console.WriteLine();
                 //Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
             }
             #endregion
             #region Tour Cavalrie
             if (ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count > 0 && ÉquipeJoueur.ArméeJoueur.NbUnités > 0)
             {
                 AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                 Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités de cavalrie. ");
                 GestionDéplacements(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Cavalrie, nbTours);
                 //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
                 //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 //Console.WriteLine();
                 //Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
             }
             #endregion
             #region Tour Archer
             if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0 && ÉquipeEnnemie.ArméeJoueur.NbUnités > 0)
             {
                 AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités archers. ");
                 GestionDéplacements(Terrain, ÉquipeJoueur, ÉquipeEnnemie, ÉquipeJoueur.ArméeJoueur.Archer, nbTours);
                 //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
                 //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 //Console.WriteLine();
                 //Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
             }
             #endregion
             #region Tour Archer
             if (ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count > 0 && ÉquipeJoueur.ArméeJoueur.NbUnités > 0)
             {
                 AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 Console.ForegroundColor = ÉquipeEnnemie.Couleur;
                 Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités archers. ");
                 GestionDéplacements(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Archer, nbTours);
                 //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
                 //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                 //Console.WriteLine();
                 //Console.ForegroundColor = ÉquipeJoueur.Couleur;
                 //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
             }
             #endregion

             ++nbTours;
             System.Threading.Thread.Sleep(2000);
             Console.ForegroundColor = ConsoleColor.Gray;
         }
         while (!ÉquipeEnnemie.ArméeJoueur.Anéantie && !ÉquipeJoueur.ArméeJoueur.Anéantie);
         System.Threading.Thread.Sleep(1000);

      }
      static void CombatContreCPU(Équipe ÉquipeJoueur, Équipe ÉquipeEnnemie)
      {
          Carte Terrain;
          if (Être.Rnd.Next(1, 3) == 1)
          {
              Terrain = new Carte("Terrain.txt", ÉquipeJoueur, ÉquipeEnnemie);
          }
          else
          {
              Terrain = new Carte("Terrain2.txt", ÉquipeJoueur, ÉquipeEnnemie);
          } 
         ÉquipeEnnemie.ArméeJoueur.Terrain = Terrain;
         ÉquipeJoueur.ArméeJoueur.Terrain = Terrain;
         int nbTours = 1;
         int tempsEntreActionsCPU = 800;
         do
         {
            #region Vérification
             if (ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count == 0)
             {
                 ÉquipeEnnemie.ArméeJoueur.Archer.Symbole = ' ';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Archer.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Archer.Pos.PosY].Symbole = ' ';
                 ÉquipeEnnemie.ArméeJoueur.Archer.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeEnnemie.ArméeJoueur.Archer.Symbole = 'a';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Archer.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Archer.Pos.PosY].Symbole = 'a';
             }
             //
             if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count == 0)
             {
                 ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole = ' ';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosY].Symbole = ' ';
                 ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeEnnemie.ArméeJoueur.Infantrie.Symbole = 'i';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Infantrie.Pos.PosY].Symbole = 'i';
             }
             //
             if (ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count == 0)
             {
                 ÉquipeEnnemie.ArméeJoueur.Cavalrie.Symbole = ' ';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos.PosY].Symbole = ' ';
                 ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeEnnemie.ArméeJoueur.Cavalrie.Symbole = 'c';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Cavalrie.Pos.PosY].Symbole = 'c';
             }
             //
             if (ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count == 0)
             {
                 ÉquipeEnnemie.ArméeJoueur.Volant.Symbole = ' ';

                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Volant.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Volant.Pos.PosY].Symbole = ' ';
                 ÉquipeEnnemie.ArméeJoueur.Volant.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeEnnemie.ArméeJoueur.Volant.Symbole = 'v';
                 Terrain.Grille[ÉquipeEnnemie.ArméeJoueur.Volant.Pos.PosX, ÉquipeEnnemie.ArméeJoueur.Volant.Pos.PosY].Symbole = 'v';
             }
             //
             if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count == 0)
             {
                 ÉquipeJoueur.ArméeJoueur.Archer.Symbole = ' ';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosY].Symbole = ' ';
                 ÉquipeJoueur.ArméeJoueur.Archer.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeJoueur.ArméeJoueur.Archer.Symbole = 'A';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosY].Symbole = 'A';
             }
             //
             if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count == 0)
             {
                 ÉquipeJoueur.ArméeJoueur.Infantrie.Symbole = ' ';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Infantrie.Pos.PosY].Symbole = ' ';
                 ÉquipeJoueur.ArméeJoueur.Infantrie.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeJoueur.ArméeJoueur.Infantrie.Symbole = 'I';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Infantrie.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Infantrie.Pos.PosY].Symbole = 'I';
             }
             //
             if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count == 0)
             {
                 ÉquipeJoueur.ArméeJoueur.Cavalrie.Symbole = ' ';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos.PosY].Symbole = ' ';
                 ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeJoueur.ArméeJoueur.Cavalrie.Symbole = 'C';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Cavalrie.Pos.PosY].Symbole = 'C';
             }
             //
             if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count == 0)
             {
                 ÉquipeJoueur.ArméeJoueur.Volant.Symbole = ' ';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Volant.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Volant.Pos.PosY].Symbole = ' ';
                 ÉquipeJoueur.ArméeJoueur.Volant.Pos = new Position(4, 3);
             }
             else
             {
                 ÉquipeJoueur.ArméeJoueur.Volant.Symbole = 'V';
                 Terrain.Grille[ÉquipeJoueur.ArméeJoueur.Volant.Pos.PosX, ÉquipeJoueur.ArméeJoueur.Volant.Pos.PosY].Symbole = 'V';
             }
#endregion
            Terrain.Afficher(nbTours);
            //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
            #region Tour Volant
            if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0 && ÉquipeEnnemie.ArméeJoueur.NbUnités > 0)
            {
               AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               Console.ForegroundColor = ÉquipeJoueur.Couleur;
               Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités volantes. ");
               GestionDéplacements(Terrain, ÉquipeJoueur,ÉquipeEnnemie,ÉquipeJoueur.ArméeJoueur.Volant,nbTours);
               //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(ChoisirCible(ÉquipeEnnemie), AttaqueVolants, ÉquipeJoueur);
               //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               //Console.WriteLine();
               //Console.ForegroundColor = ÉquipeJoueur.Couleur;
               //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueVolants.Dégâts);
            }
            #endregion
            #region Tour Volant CPU
            Attaque AttaqueVolantEnnemie = new Attaque(ÉquipeEnnemie.ArméeJoueur.Attaquer(ÉquipeEnnemie.ArméeJoueur.Volant.Troupes), ÉquipeEnnemie.ArméeJoueur.Volant,false);
            if (ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count > 0 && !ÉquipeJoueur.ArméeJoueur.Anéantie)
            {
               if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Volant, nbTours, 'V', ((Être)ÉquipeEnnemie.ArméeJoueur.Volant.Troupes[0]).Vitesse, AttaqueVolantEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Volant, nbTours, 'A', ((Être)ÉquipeEnnemie.ArméeJoueur.Volant.Troupes[0]).Vitesse, AttaqueVolantEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Volant, nbTours, 'I', ((Être)ÉquipeEnnemie.ArméeJoueur.Volant.Troupes[0]).Vitesse, AttaqueVolantEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Volant, nbTours, 'C', ((Être)ÉquipeEnnemie.ArméeJoueur.Volant.Troupes[0]).Vitesse, AttaqueVolantEnnemie);
               }
               System.Threading.Thread.Sleep(tempsEntreActionsCPU);

            }
            #endregion
            #region Tour Infantrie
            if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0 && !ÉquipeEnnemie.ArméeJoueur.Anéantie)
            {
                AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               Console.ForegroundColor = ÉquipeJoueur.Couleur;
               Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités d'infantrie. ");
               GestionDéplacements(Terrain, ÉquipeJoueur, ÉquipeEnnemie, ÉquipeJoueur.ArméeJoueur.Infantrie, nbTours);
               //GroupeMilitaire Choix = ChoisirCible(ÉquipeEnnemie);
               //if (Choix == ÉquipeEnnemie.ArméeJoueur.Cavalrie)
               //{
               //   AttaqueInfantrie.Dégâts *= 2;
               //}
               ////Console.Clear();
               //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Choix.Troupes, AttaqueInfantrie, ÉquipeJoueur);
               
               //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               //Console.WriteLine();
               //Console.ForegroundColor = ÉquipeJoueur.Couleur;
               //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueInfantrie.Dégâts);
            }
            #endregion
            #region Tour Infantrie CPU
            Attaque AttaqueInfantrieEnnemie = new Attaque(ÉquipeEnnemie.ArméeJoueur.Attaquer(ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes), ÉquipeEnnemie.ArméeJoueur.Infantrie,false);
            if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count > 0 && !ÉquipeJoueur.ArméeJoueur.Anéantie)
            {
               if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Infantrie, nbTours, 'C', ((Être)ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes[0]).Vitesse, AttaqueInfantrieEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Infantrie, nbTours, 'I', ((Être)ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes[0]).Vitesse, AttaqueInfantrieEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Infantrie, nbTours, 'A', ((Être)ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes[0]).Vitesse, AttaqueInfantrieEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Infantrie, nbTours, 'V', ((Être)ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes[0]).Vitesse, AttaqueInfantrieEnnemie);
               }
               System.Threading.Thread.Sleep(tempsEntreActionsCPU);

            }
            #endregion
            #region Tour Cavalrie
            //Attaque AttaqueCavalrie = new Attaque(ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes), ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes);
            if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0 && ÉquipeEnnemie.ArméeJoueur.NbUnités > 0)
            {
                AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               Console.ForegroundColor = ÉquipeJoueur.Couleur;
               Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos unités de cavalrie. ");
               GestionDéplacements(Terrain, ÉquipeJoueur, ÉquipeEnnemie, ÉquipeJoueur.ArméeJoueur.Cavalrie, nbTours);
               //GroupeMilitaire Choix = ChoisirCible(ÉquipeEnnemie);
               //if (Choix == ÉquipeEnnemie.ArméeJoueur.Archer)
               //{
               //   AttaqueCavalrie.Dégâts *= 1.5f;
               //}
               ////Console.Clear();
               //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Choix.Troupes, AttaqueCavalrie, ÉquipeJoueur);

               //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               //Console.WriteLine();
               //Console.ForegroundColor = ÉquipeJoueur.Couleur;
               //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueCavalrie.Dégâts);
            }
            #endregion
            #region Tour Cavalrie CPU
            Attaque AttaqueCavalrieEnnemie = new Attaque(ÉquipeEnnemie.ArméeJoueur.Attaquer(ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes), ÉquipeEnnemie.ArméeJoueur.Cavalrie,false);
            if (ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count > 0 && !ÉquipeJoueur.ArméeJoueur.Anéantie)
            {
               if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Cavalrie, nbTours, 'A', ((Être)ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes[0]).Vitesse, AttaqueCavalrieEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Cavalrie, nbTours, 'C', ((Être)ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes[0]).Vitesse, AttaqueCavalrieEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Cavalrie, nbTours, 'I', ((Être)ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes[0]).Vitesse, AttaqueCavalrieEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0)
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Cavalrie, nbTours, 'V', ((Être)ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes[0]).Vitesse, AttaqueCavalrieEnnemie);
               }
               System.Threading.Thread.Sleep(tempsEntreActionsCPU);

            }
            #endregion
            #region Tour Archer
            if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0 && ÉquipeEnnemie.ArméeJoueur.NbUnités > 0)
            {
                AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               Console.ForegroundColor = ÉquipeJoueur.Couleur;
               Console.WriteLine("     Veuillez effectuer une manoeuvre avec vos Archers. ");
               Console.WriteLine("     (Appuyez sur la touche D pour une attaque à distance.) ");
               GestionDéplacements(Terrain, ÉquipeJoueur, ÉquipeEnnemie, ÉquipeJoueur.ArméeJoueur.Archer, nbTours);
               //GroupeMilitaire Choix = ChoisirCible(ÉquipeEnnemie);
               //if (Choix == ÉquipeEnnemie.ArméeJoueur.Infantrie)
               //{
               //   AttaqueArchers.Dégâts *= 1.5f;
               //}
               //else if (Choix == ÉquipeEnnemie.ArméeJoueur.Volant)
               //{
               //   AttaqueArchers.Dégâts *= 1.25f;
               //}
               //Console.Clear();
               //ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Choix, AttaqueArchers, ÉquipeJoueur);

               //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               //Console.WriteLine();
               //Console.ForegroundColor = ÉquipeJoueur.Couleur;
               //Console.WriteLine("     Vous avez infligé {0} points de dégâts!", AttaqueArchers.Dégâts);
            }
            #endregion
            #region Tour Archer CPU
            Attaque AttaqueArcherEnnemie = new Attaque(ÉquipeEnnemie.ArméeJoueur.Attaquer(ÉquipeEnnemie.ArméeJoueur.Archer.Troupes), ÉquipeEnnemie.ArméeJoueur.Archer,true);
            if (ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count > 0 && !ÉquipeJoueur.ArméeJoueur.Anéantie)
            {
               if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0&&((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).Portée>CalculerDistance(ÉquipeEnnemie.ArméeJoueur.Archer,ÉquipeJoueur.ArméeJoueur.Infantrie))
               {
                  //AttaqueArcherEnnemie.Dégâts *= 1.5f;
                  ÉquipeJoueur.ArméeJoueur.SubirDégâts(ÉquipeJoueur.ArméeJoueur.Infantrie, AttaqueArcherEnnemie, ÉquipeEnnemie,nbTours);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0&&((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).Portée>CalculerDistance(ÉquipeEnnemie.ArméeJoueur.Archer,ÉquipeJoueur.ArméeJoueur.Archer))
               {
                   ÉquipeJoueur.ArméeJoueur.SubirDégâts(ÉquipeJoueur.ArméeJoueur.Archer, AttaqueArcherEnnemie, ÉquipeEnnemie, nbTours);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0&&((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).Portée>CalculerDistance(ÉquipeEnnemie.ArméeJoueur.Archer,ÉquipeJoueur.ArméeJoueur.Cavalrie))
               {
                   ÉquipeJoueur.ArméeJoueur.SubirDégâts(ÉquipeJoueur.ArméeJoueur.Cavalrie, AttaqueArcherEnnemie, ÉquipeEnnemie, nbTours);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0&&((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).Portée>CalculerDistance(ÉquipeEnnemie.ArméeJoueur.Archer,ÉquipeJoueur.ArméeJoueur.Volant))
               {
                  //AttaqueArcherEnnemie.Dégâts *= 1.25f;
                  ÉquipeJoueur.ArméeJoueur.SubirDégâts(ÉquipeJoueur.ArméeJoueur.Volant, AttaqueArcherEnnemie, ÉquipeEnnemie, nbTours);
               }
           //---------------
               else if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0 )
               {
                   //AttaqueArcherEnnemie.Dégâts *= 1.5f;
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Archer, nbTours, 'I', ((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).Vitesse, AttaqueArcherEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0 )
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Archer, nbTours, 'A', ((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).Vitesse, AttaqueArcherEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0 )
               {
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Archer, nbTours, 'C', ((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).Vitesse, AttaqueArcherEnnemie);
               }
               else if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0 )
               {
                   //AttaqueArcherEnnemie.Dégâts *= 1.25f;
                   PathfindingAttaque(Terrain, ÉquipeEnnemie, ÉquipeJoueur, ÉquipeEnnemie.ArméeJoueur.Archer, nbTours, 'V', ((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).Vitesse, AttaqueArcherEnnemie);
               }
               //Console.ForegroundColor = ÉquipeEnnemie.Couleur;
               //System.Threading.Thread.Sleep(500);
               //AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
               //Console.WriteLine("     L'ennemie vous a infligé {0} points de dégâts!", AttaqueArcherEnnemie.Dégâts);
               System.Threading.Thread.Sleep(tempsEntreActionsCPU);

            }
            #endregion
            
            //System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;

            ++nbTours;
         }
         while (!ÉquipeEnnemie.ArméeJoueur.Anéantie && !ÉquipeJoueur.ArméeJoueur.Anéantie);
         System.Threading.Thread.Sleep(1500);
      }
      static void ObtenirAmélioration(Équipe ÉquipeJoueur)
      {
         Console.Clear();
         AfficherÉquipeJoueur(ÉquipeJoueur);
         Console.Write("     Voulez-vous ajouter des améliorations?  (Oui(O)/Non(N)");
         string key;
         do
         {
            key = Console.ReadLine().ToUpper();
         }
         while (key != "O" && key != "N");
         if (key == "O")
         {
            AjouterAmélioration(ÉquipeJoueur);
            key = "b";
         }
         else if (key == "N")
         {
            key = "b";
         }

      }
      static void AjouterAmélioration(Équipe ÉquipeJoueur)
      {
         #region Variables et Constantes
         bool aFaitUneMesse= false;
         bool ent = false;
         bool elfUpg = false;
         bool sacrifice = false;
         bool aPrié = false;
         const int PRIX_PRIÈRE = 1000;
         const int PRIX_FORÊT = 1500;
         const int PRIX_ELFS = 1750;
         const int PRIX_MESSE = 1000;
         const int PRIX_MAGOGS=1750;
         const int PRIX_SACRIFICE = 1500;
         const int PRIX_ARC_LONGS = 5000;
         string key = "b";
         string key2 = "O";
         #endregion
         do
         {
            Console.Clear();
            AfficherÉquipeJoueur(ÉquipeJoueur);
            #region Chevalier
            if (ÉquipeJoueur.Chevalier)
            {
               do
               {
                  Console.WriteLine("     Que Voulez-vous améliorer?  R ou Riposte ({0} Pts d'expérience)", ÉquipeJoueur.PrixRevanche);
                  Console.WriteLine("                                 É ou Église   ({0} Pts d'expérience)", ÉquipeJoueur.PrixÉglise);
                  Console.WriteLine("                                 A ou Arcs Longs ({0} Pts d'expérience", PRIX_ARC_LONGS);
                  Console.WriteLine("                                 P ou Prier ({0} Pts d'expérience", PRIX_PRIÈRE);
                  key = Console.ReadLine().ToUpper();
                  Vérifier(key);
               }
               while (key != "R" && key != "É" && key != "P" && key != "A");
               if (key == "A")
               {
                   if (ÉquipeJoueur.ArcsLongs)
                   {
                       Console.WriteLine("       Vous avez déjà cette amélioration.");
                   }
                   else
                   {
                       string choix = "a";
                       do
                       {
                           Console.WriteLine("      Cette amélioration permet à vos archers d'essayer d'atteindre une cible");
                           Console.WriteLine("      n'importe où sur la carte. Plus une cible est loin, moins l'attaque sera puissante.");
                           Console.Write("      Voulez-vous acheter cette amélioration? (O/N) ");
                           choix = Console.ReadLine().ToUpper();
                           choix = Vérifier(choix);
                       }
                       while (choix != "O" && choix != "N");
                       if (choix == "O")
                       {
                           AchatArcsLongs(ÉquipeJoueur, PRIX_ARC_LONGS);
                           Console.Clear();
                           AfficherÉquipeJoueur(ÉquipeJoueur);
                       }
                   }
               }
               if (key == "R")
               {
                  if (ÉquipeJoueur.Expérience < ÉquipeJoueur.PrixRevanche)
                  {
                     Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                  }
                  else if ((int)ÉquipeJoueur.BonusRevanche == 1)
                  {
                      Console.WriteLine("       Cette amélioraton est au maximum");
                  }
                  else
                  {
                      AchatRevanche(ÉquipeJoueur);
                      Console.Clear();
                      AfficherÉquipeJoueur(ÉquipeJoueur);
                  }
               }
               if (key == "É")
               {
                   if (ÉquipeJoueur.BonusÉglise >= 6)
                   {
                       Console.WriteLine("     Cette amélioration est au maximum.");

                       if (ÉquipeJoueur.Expérience < ÉquipeJoueur.PrixÉglise)
                       {
                           Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                       }
                   }
                   else
                       {
                           AchatÉglise(ÉquipeJoueur);
                           Console.Clear();
                           AfficherÉquipeJoueur(ÉquipeJoueur);
                       }
               }
               if (key == "P")
               {
                  if (aPrié)
                  {
                     Console.WriteLine("     Vous avez déjà prié!");
                  }
                  else if (ÉquipeJoueur.Expérience < PRIX_PRIÈRE)
                  {
                     Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                  }
                  else
                  {
                     foreach (Être i in ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes)
                     {
                        i.PointDeVie += 5;
                     }
                     foreach (Être i in ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes)
                     {
                        i.PointDeVie += 10;
                     }
                     foreach (Être i in ÉquipeJoueur.ArméeJoueur.Archer.Troupes)
                     {
                        i.PointDeVie +=  5;
                     }
                     foreach (Être i in ÉquipeJoueur.ArméeJoueur.Volant.Troupes)
                     {
                        i.PointDeVie +=  20;
                     }
                     ÉquipeJoueur.Expérience -= PRIX_PRIÈRE;
                     Console.Clear();
                     AfficherÉquipeJoueur(ÉquipeJoueur);
                     Console.WriteLine();
                     Console.WriteLine("     Chaque unité est maintenant plus résistante!");
                     Console.WriteLine();
                  }
               }

            }
            #endregion
            #region ÊtreForêt
            else if (ÉquipeJoueur.ÊtreForêt)
            {
               do
               {
                  Console.WriteLine("     Que Voulez-vous améliorer?  R ou Riposte ({0} Pts d'expérience)", ÉquipeJoueur.PrixRevanche);
                  Console.WriteLine("                                 A ou Arcs Longs ({0} Pts d'expérience", PRIX_ARC_LONGS);
                  Console.WriteLine("                                 F ou Forêts   ({0} Pts d'expérience et {1} pièces d'or)", PRIX_FORÊT, ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count * Infantrie.BASE_PRIX / 3);
                  Console.WriteLine("                                 E ou Elfs améliorés ({0} Pts d'expérience)", PRIX_ELFS);
                  key = Console.ReadLine().ToUpper();
                  Vérifier(key);
               }
               while (key != "R" && key != "F" && key != "E" && key != "A");
               if (key == "A")
               {
                   if (ÉquipeJoueur.ArcsLongs)
                   {
                       Console.WriteLine("       Vous avez déjà cette amélioration.");
                   }
                   else
                   {
                       string choix = "a";
                       do
                       {
                           Console.WriteLine("      Cette amélioration permet à vos archers d'essayer d'atteindre une cible");
                           Console.WriteLine("      n'importe où sur la carte. Plus une cible est loin, moins l'attaque sera puissante.");
                           Console.Write("      Voulez-vous acheter cette amélioration? (O/N) ");
                           choix = Console.ReadLine().ToUpper();
                           choix = Vérifier(choix);
                       }
                       while (choix != "O" && choix != "N");
                       if (choix == "O")
                       {
                           AchatArcsLongs(ÉquipeJoueur, PRIX_ARC_LONGS);
                           Console.Clear();
                           AfficherÉquipeJoueur(ÉquipeJoueur);
                       }
                   }
               }
               if (key == "R")
               {
                  if (ÉquipeJoueur.Expérience < ÉquipeJoueur.PrixRevanche)
                  {
                     Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                  }
                  else if ((int)ÉquipeJoueur.BonusRevanche == 1)
                  {
                      Console.WriteLine("       Cette amélioraton est au maximum");
                  }
                  else
                  {
                     AchatRevanche(ÉquipeJoueur);
                     Console.Clear();
                     AfficherÉquipeJoueur(ÉquipeJoueur);
                  }
               }
               if (key == "F")
               {
                  if (ent||ÉquipeJoueur.Ents)
                  {
                     Console.WriteLine("     Vous avez déjà cette amélioration.");
                  }
                  else if (ÉquipeJoueur.Expérience < PRIX_FORÊT || ÉquipeJoueur.Or < ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count * Infantrie.BASE_PRIX / 3)
                  {
                     Console.WriteLine("     Vous n'avez pas assez d'expérience ou d'or.");
                  }
                  else
                  {
                     Console.WriteLine("     Êtes-vous certain de vouloir jeter un sort sur tous vos");
                     Console.WriteLine("     nains pour les transformer en Ents pour le reste du jeu?  (Oui/Non)");
                     do
                     {
                        key = Console.ReadLine().ToUpper();
                     }
                     while (key != "O" && key != "N");
                     if (key == "O")
                     {
                        ent = true;
                        ÉquipeJoueur.Or -= ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count * Infantrie.BASE_PRIX / 3;
                        ÉquipeJoueur.Expérience -= PRIX_FORÊT;
                        TransformerNains(ÉquipeJoueur);
                        key = "b";
                     }
                     else
                     {
                        key = "b";
                     }
                     Console.Clear();
                     AfficherÉquipeJoueur(ÉquipeJoueur);
                  }
               }
               if (key == "E" || key == "I")
               {
                  if (elfUpg||ÉquipeJoueur.ElfsAméloirés)
                  {
                     Console.WriteLine("     Vous avez déjà cette amélioration.");
                  }
                  else if (ÉquipeJoueur.Expérience < PRIX_ELFS)
                  {
                     Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                  }
                  else
                  {
                     ÉquipeJoueur.Expérience -= PRIX_ELFS;
                     elfUpg = true;
                     ÉquipeJoueur.ElfsAméloirés = true;
                     foreach (Être i in ÉquipeJoueur.ArméeJoueur.Archer.Troupes)
                     {
                         i.MaxVie = Archer.BASE_VIE + 5;
                         i.PointDeVie = i.MaxVie;
                         i.PointsDégât = Archer.BASE_DÉGÂTS + 3;
                     }
                     Console.Clear();
                     AfficherÉquipeJoueur(ÉquipeJoueur);
                     Console.WriteLine("     Chaque Elf est maintenant plus puissant!");
                  }
               }
            }
            #endregion
            #region Nécromantien
            else if (ÉquipeJoueur.Nécromantien)
            {
               do
               {
                  Console.WriteLine("     Que Voulez-vous améliorer?  R ou Riposte ({0} Pts d'expérience)", ÉquipeJoueur.PrixRevanche);
                  Console.WriteLine("                                 N ou Nécromancie   ({0} Pts d'expérience)", ÉquipeJoueur.PrixNécromancie);
                  Console.WriteLine("                                 S ou Sceptre amélioré ({0} Pts d'expérience", PRIX_ARC_LONGS);
                  Console.WriteLine("                                 M ou Messe des morts ({0} Pts d'expérience", PRIX_MESSE);
                  key = Console.ReadLine().ToUpper();
                  Vérifier(key);
               }
               while (key != "R" && key != "N" && key != "M" && key != "S");
               if (key == "S")
               {
                   if (ÉquipeJoueur.ArcsLongs)
                   {
                       Console.WriteLine("       Vous avez déjà cette amélioration.");
                   }
                   else
                   {
                       string choix = "a";
                       do
                       {
                           Console.WriteLine("      Cette amélioration permet à vos archers d'essayer d'atteindre une cible");
                           Console.WriteLine("      n'importe où sur la carte. Plus une cible est loin, moins l'attaque sera puissante.");
                           Console.Write("      Voulez-vous acheter cette amélioration? (O/N) ");
                           choix = Console.ReadLine().ToUpper();
                           choix = Vérifier(choix);
                       }
                       while (choix != "O" && choix != "N");
                       if (choix == "O")
                       {
                           AchatArcsLongs(ÉquipeJoueur, PRIX_ARC_LONGS);
                           Console.Clear();
                           AfficherÉquipeJoueur(ÉquipeJoueur);
                       }
                   }
               }
               if (key == "R")
               {
                  if (ÉquipeJoueur.Expérience < ÉquipeJoueur.PrixRevanche)
                  {
                     Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                  }
                  else if ((int)ÉquipeJoueur.BonusRevanche == 1)
                  {
                      Console.WriteLine("       Cette amélioraton est au maximum");
                  }
                  else
                  {
                     AchatRevanche(ÉquipeJoueur);
                     Console.Clear();
                     AfficherÉquipeJoueur(ÉquipeJoueur);
                  }
               }
               if (key == "N")
               {
                   if (ÉquipeJoueur.BonusNécromancie == 3 && ÉquipeJoueur.Nécromancie)
                   {
                       Console.WriteLine("     Cette amélioration est au maximum.");
                   }
                   else if (ÉquipeJoueur.Expérience < ÉquipeJoueur.PrixNécromancie)
                   {
                       Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                   }
                   else
                   {
                       AchatNécromancie(ÉquipeJoueur);
                       Console.Clear();
                       AfficherÉquipeJoueur(ÉquipeJoueur);
                   }
               }
               if (key == "M")
               {
                   if (aFaitUneMesse)
                   {
                       Console.WriteLine("     Vous avez déjà fait une messe!");
                   }
                   else if (ÉquipeJoueur.Expérience < PRIX_MESSE)
                   {
                       Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                   }
                   else
                   {
                       foreach (Être i in ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes)
                       {
                           i.PointsDégât += 5;
                       }
                       foreach (Être i in ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes)
                       {
                           i.PointsDégât += 5;
                       }
                       foreach (Être i in ÉquipeJoueur.ArméeJoueur.Archer.Troupes)
                       {
                           i.PointsDégât += 5;
                       }
                       foreach (Être i in ÉquipeJoueur.ArméeJoueur.Volant.Troupes)
                       {
                           i.PointsDégât += 10;
                       }
                       aFaitUneMesse = true;
                       ÉquipeJoueur.Expérience -= PRIX_MESSE;
                       Console.Clear();
                       AfficherÉquipeJoueur(ÉquipeJoueur);
                       Console.WriteLine();
                       Console.WriteLine("     Chaque unité est maintenant plus puissante!");
                       Console.WriteLine();
                   }
               }
            }
            #endregion
            #region Démoniaque
            else if (ÉquipeJoueur.Démoniaque)
            {
                do
                {
                    Console.WriteLine("     Que Voulez-vous améliorer?  R ou Riposte ({0} Pts d'expérience)", ÉquipeJoueur.PrixRevanche);
                    Console.WriteLine("                                 B ou Boules de feu ({0} Pts d'expérience", PRIX_ARC_LONGS);
                    Console.WriteLine("                                 M ou Magog   ({0} Pts d'expérience et {1} pièces d'or)", PRIX_MAGOGS, ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count * Infantrie.BASE_PRIX / 3);
                    Console.WriteLine("                                 S ou Sacrifice ({0} Pts d'expérience", PRIX_SACRIFICE);
                    key = Console.ReadLine().ToUpper();
                    Vérifier(key);
                }
                while (key != "R" && key != "M" && key != "S" && key != "B");
                if (key == "B")
                {
                    if (ÉquipeJoueur.ArcsLongs)
                    {
                        Console.WriteLine("       Vous avez déjà cette amélioration.");
                    }
                    else
                    {
                        string choix = "a";
                        do
                        {
                            Console.WriteLine("      Cette amélioration permet à vos archers d'essayer d'atteindre une cible");
                            Console.WriteLine("      n'importe où sur la carte. Plus une cible est loin, moins l'attaque sera puissante.");
                            Console.Write("      Voulez-vous acheter cette amélioration? (O/N) ");
                            choix = Console.ReadLine().ToUpper();
                            choix = Vérifier(choix);
                        }
                        while (choix != "O" && choix != "N");
                        if (choix == "O")
                        {
                            AchatArcsLongs(ÉquipeJoueur, PRIX_ARC_LONGS);
                            Console.Clear();
                            AfficherÉquipeJoueur(ÉquipeJoueur);
                        }
                    }
                }
                if (key == "R")
                {
                    if (ÉquipeJoueur.Expérience < ÉquipeJoueur.PrixRevanche)
                    {
                        Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                    }
                    else if ((int)ÉquipeJoueur.BonusRevanche == 1)
                    {
                        Console.WriteLine("       Cette amélioraton est au maximum");
                    }
                    else
                    {
                        AchatRevanche(ÉquipeJoueur);
                        Console.Clear();
                        AfficherÉquipeJoueur(ÉquipeJoueur);
                    }
                }
                if (key == "M")
                {
                    if (ÉquipeJoueur.Magogs)
                    {
                        Console.WriteLine("     Vous avez déjà cette amélioration.");
                    }
                    else if (ÉquipeJoueur.Expérience < PRIX_MAGOGS || ÉquipeJoueur.Or < ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count * Infantrie.BASE_PRIX / 3)
                    {
                        Console.WriteLine("     Vous n'avez pas assez d'expérience ou d'or.");
                    }
                    else
                    {
                        Console.WriteLine("     Êtes-vous certain de vouloir améliorer vos Gogs pour");
                        Console.WriteLine("     des Magogs pour le reste du jeu?  (Oui/Non)");
                        do
                        {
                            key = Console.ReadLine().ToUpper();
                            Vérifier(key);
                        }
                        while (key != "O" && key != "N");
                        if (key == "O")
                        {
                            ÉquipeJoueur.Magogs = true;
                            ÉquipeJoueur.Archer = "Magogs";
                            ÉquipeJoueur.Or -= ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count * Infantrie.BASE_PRIX / 3;
                            ÉquipeJoueur.Expérience -= PRIX_MAGOGS;
                            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Archer.Troupes)
                            {
                                i.PointDeVie = i.MaxVie + 15;
                                i.PointsDégât += 2;
                            }
                            key = "b";
                        }
                        else
                        {
                            key = "b";
                        }
                        Console.Clear();
                        AfficherÉquipeJoueur(ÉquipeJoueur);
                    }
                }
                if (key == "S")
                {
                    if (sacrifice)
                    {
                        Console.WriteLine("     Vous avez déjà fait un sacrifice.");
                    }
                    else if (ÉquipeJoueur.Expérience < PRIX_SACRIFICE)
                    {
                        Console.WriteLine("     Vous n'avez pas assez d'expérience.");
                    }
                    else
                    {
                        foreach (Être i in ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes)
                        {
                            i.PointDeVie +=  5;
                        }
                        foreach (Être i in ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes)
                        {
                            i.PointDeVie += 5;
                        }
                        foreach (Être i in ÉquipeJoueur.ArméeJoueur.Archer.Troupes)
                        {
                            i.PointDeVie += 3;
                        }
                        foreach (Être i in ÉquipeJoueur.ArméeJoueur.Volant.Troupes)
                        {
                            i.PointDeVie += 20;
                        }
                        ÉquipeJoueur.Expérience -= PRIX_SACRIFICE;
                        Console.Clear();
                        AfficherÉquipeJoueur(ÉquipeJoueur);
                        Console.WriteLine();
                        Console.WriteLine("     Chaque unité est maintenant plus résistante!");
                        Console.WriteLine();
                        sacrifice = true;
                    }
                }
            }
            #endregion
            Console.WriteLine();
            Console.WriteLine("     Voulez-vous ajoutez d'autres améliorations?  (O/N)  ");
            do
            {
               key2 = Console.ReadLine().ToUpper();
            }
            while (key2 != "O" && key2 != "N");
         }
         while (key2 != "N");
      }

      static void AchatNécromancie(Équipe ÉquipeJoueur)
      {
          if (ÉquipeJoueur.Nécromancie)
          {
              ÉquipeJoueur.Expérience -= ÉquipeJoueur.PrixNécromancie;
              --ÉquipeJoueur.BonusNécromancie;
          }
          else
          {
              ÉquipeJoueur.Nécromancie = true;
              ÉquipeJoueur.BonusNécromancie = 6;
              ÉquipeJoueur.Expérience -= ÉquipeJoueur.PrixNécromancie;
              
          }
          ÉquipeJoueur.PrixNécromancie += 1000;
      }
      static void TransformerNains(Équipe ÉquipeJoueur)
      {
         ÉquipeJoueur.Infantrie = "Ents";
         ÉquipeJoueur.Ents = true;
         foreach (Être i in ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes)
         {
            i.PointDeVie = 70;
            i.PointsDégât = 20;
         }
         Console.WriteLine("        Vous avez maintenant des Ents!");
         System.Threading.Thread.Sleep(400);
      }
      static void AchatÉglise(Équipe ÉquipeJoueur)
      {
         const int PRIX_ÉGLISE = 1500;
         if (ÉquipeJoueur.Église)
         {
            ÉquipeJoueur.Expérience -= PRIX_ÉGLISE + 500 * ÉquipeJoueur.BonusÉglise;
            ÉquipeJoueur.BonusÉglise += 1;
            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes)
            {
                i.MaxVie = Infantrie.BASE_VIE + ÉquipeJoueur.BonusÉglise;
                i.PointDeVie = i.MaxVie;
            }
            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes)
            {
                i.MaxVie = Cavalrie.BASE_VIE + ÉquipeJoueur.BonusÉglise * 2;
                i.PointDeVie = i.MaxVie;
            }
            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Archer.Troupes)
            {
                i.MaxVie = Archer.BASE_VIE + ÉquipeJoueur.BonusÉglise;
                i.PointDeVie = i.MaxVie;
            }
            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Volant.Troupes)
            {
                i.MaxVie = Volant.BASE_VIE + ÉquipeJoueur.BonusÉglise * 4;
                i.PointDeVie = i.MaxVie;
            }
            ÉquipeJoueur.PrixÉglise = PRIX_ÉGLISE + 500 * ÉquipeJoueur.BonusÉglise;
         }
         else
         {
            ÉquipeJoueur.Expérience -= PRIX_ÉGLISE;
            ÉquipeJoueur.Église = true;
            ÉquipeJoueur.BonusÉglise = 2;
            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes)
            {
                i.MaxVie = Infantrie.BASE_VIE + ÉquipeJoueur.BonusÉglise;
                i.PointDeVie = i.MaxVie;
            }
            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes)
            {
                i.MaxVie = Cavalrie.BASE_VIE + ÉquipeJoueur.BonusÉglise * 2;
                i.PointDeVie = i.MaxVie;
            }
            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Archer.Troupes)
            {
                i.MaxVie = Archer.BASE_VIE + ÉquipeJoueur.BonusÉglise;
                i.PointDeVie = i.MaxVie;
            }
            foreach (Être i in ÉquipeJoueur.ArméeJoueur.Volant.Troupes)
            {
                i.MaxVie = Volant.BASE_VIE + ÉquipeJoueur.BonusÉglise * 4;
                i.PointDeVie = i.MaxVie;
            }
            ÉquipeJoueur.PrixÉglise = PRIX_ÉGLISE + 500 * ÉquipeJoueur.BonusÉglise;
         }
      }
      static void AchatRevanche(Équipe ÉquipeJoueur)
      {
         const int PRIX_REVANCHE = 800;
         if (ÉquipeJoueur.Revanche)
         {
            ÉquipeJoueur.Expérience -= PRIX_REVANCHE + 1100 * ÉquipeJoueur.BonusRevanche;
            ÉquipeJoueur.BonusRevanche += 0.1f;
            ÉquipeJoueur.PrixRevanche = PRIX_REVANCHE + (int)(1100 * ÉquipeJoueur.BonusRevanche);
         }
         else
         {
            ÉquipeJoueur.Expérience -= PRIX_REVANCHE;
            ÉquipeJoueur.Revanche = true;
            ÉquipeJoueur.BonusRevanche = 0.2f;
            ÉquipeJoueur.PrixRevanche = PRIX_REVANCHE + (int)(1100 * ÉquipeJoueur.BonusRevanche);

         }
      }
      static void AchatArcsLongs(Équipe ÉquipeJoueur,int PrixArcsLongs)
      {
          
          if (ÉquipeJoueur.Expérience < PrixArcsLongs)
          {
              Console.WriteLine("     Vous n'avez pas assez d'expérience.");
          }
          else
          {
              ÉquipeJoueur.Expérience -= PrixArcsLongs;
              ÉquipeJoueur.ArcsLongs = true;
          }
      }

      static void GestionDéplacements(Carte Terrain, Équipe ÉquipeJoueur,Équipe ÉquipeEnnemie,GroupeMilitaire Groupe,int nbTours)
      {
          int pasRestants=((Être) Groupe.Troupes[0]).Vitesse;
          Terrain.AfficherCarteAvecAura(ÉquipeJoueur, Groupe, pasRestants,nbTours);
          AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
          #region message
          string message="";
          Console.ForegroundColor = ÉquipeJoueur.Couleur;
          if (((Être)Groupe.Troupes[0]).Type == "Volant")
          {
              message="     Veuillez effectuer une manoeuvre avec vos unités volantes. ";
          }
          else if (((Être)Groupe.Troupes[0]).Type == "Infantrie")
          {
              message="     Veuillez effectuer une manoeuvre avec vos unités d'infantrie. ";
          }
          else if (((Être)Groupe.Troupes[0]).Type == "Cavalrie")
          {
              message="     Veuillez effectuer une manoeuvre avec vos unités de cavalrie. ";
          }
          else if (((Être)Groupe.Troupes[0]).Type == "Archer")
          {
              message="     Veuillez effectuer une manoeuvre avec vos unités archers. ";
          }
          Console.WriteLine(message);
          #endregion
          Attaque AttaqueGroupe = new Attaque(ÉquipeJoueur.ArméeJoueur.Attaquer(Groupe.Troupes),Groupe,((Être)Groupe.Troupes[0]).Type=="Archer");
          do
          {
              ConsoleKey action = Console.ReadKey().Key;
              if ((char)action == 'I' || (char)action == 'C' || (char)action == 'A' || (char)action == 'V' || (char)action == 'D')
              {
                  #region Groupe Vide ?
                  if ((char)action == 'V' && ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count == 0)
                  {
                      Console.ForegroundColor = ÉquipeJoueur.Couleur;
                      Console.WriteLine("      Ce groupe est vide.");
                  }
                  else if ((char)action == 'I' && ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count == 0)
                  {
                      Console.ForegroundColor = ÉquipeJoueur.Couleur;
                      Console.WriteLine("      Ce groupe est vide.");
                  }
                  else if ((char)action == 'C' && ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count == 0)
                  {
                      Console.ForegroundColor = ÉquipeJoueur.Couleur;
                      Console.WriteLine("      Ce groupe est vide.");
                  }
                  else if ((char)action == 'A' && ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count == 0)
                  {
                      Console.ForegroundColor = ÉquipeJoueur.Couleur;
                      Console.WriteLine("      Ce groupe est vide.");
                  }
                  else
                  {
                  #endregion
                      if ((char)action == 'I' || (char)action == 'C' || (char)action == 'A' || (char)action == 'V')
                      {
                          PathfindingAttaque(Terrain, ÉquipeJoueur, ÉquipeEnnemie, Groupe, nbTours, (char)action, pasRestants, AttaqueGroupe);
                          pasRestants = 0;
                      }
                      #region Archers
                      else if (Groupe == ÉquipeJoueur.ArméeJoueur.Archer && (char)action == 'D')
                      {
                          Console.ForegroundColor = ÉquipeJoueur.Couleur;
                          Console.WriteLine("     Quel groupe ennemie doit être attaqué a distance par vos archers?");
                          GroupeMilitaire Choix = ChoisirCible(ÉquipeEnnemie);
                          float distanceX = Math.Abs(ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosX - Choix.Pos.PosX);
                          float distanceY = Math.Abs(ÉquipeJoueur.ArméeJoueur.Archer.Pos.PosY - Choix.Pos.PosY);
                          float distanceTot = (float)Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
                          if (ÉquipeJoueur.ArcsLongs)
                          {
                              if (distanceTot > ((Être)ÉquipeJoueur.ArméeJoueur.Archer.Troupes[0]).Portée)
                              {
                                  AttaqueGroupe.Dégâts *= ((Être)ÉquipeJoueur.ArméeJoueur.Archer.Troupes[0]).Portée / (distanceTot * 1.5f);
                                  ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Choix, AttaqueGroupe, ÉquipeJoueur, nbTours);
                              }
                              else
                              {
                                  AppliquerBonus(AttaqueGroupe, Groupe, Choix, ÉquipeJoueur, ÉquipeEnnemie);
                                  ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Choix, AttaqueGroupe, ÉquipeJoueur, nbTours);
                              }
                              pasRestants = 0;
                          }
                          else
                          {
                              if (distanceTot > ((Être)ÉquipeJoueur.ArméeJoueur.Archer.Troupes[0]).Portée)
                              {
                                  Console.WriteLine();
                                  Console.WriteLine("      Ce groupe est trop loin.");
                                  System.Threading.Thread.Sleep(500);
                                  Console.WriteLine(message);
                                  //GestionDéplacements(Terrain, ÉquipeJoueur, ÉquipeEnnemie, ÉquipeJoueur.ArméeJoueur.Archer, nbTours);
                                  //pasRestants = 0;
                              }
                              else
                              {
                                  AppliquerBonus(AttaqueGroupe, Groupe, Choix, ÉquipeJoueur, ÉquipeEnnemie);
                                  ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Choix, AttaqueGroupe, ÉquipeJoueur, nbTours);
                                  pasRestants = 0;
                              }
                          }
                          if (Choix.Troupes.Count == 0)
                          {
                              Terrain.Grille[Choix.Pos.PosX, Choix.Pos.PosY].Symbole = ' ';
                          }
                          
                          Console.WriteLine();
                      }
                      #endregion
                  }

              }
              #region Contrôle par flèches
              else if (action == ConsoleKey.UpArrow)
              {
                  if (Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].EstUnGroupeEnnemie(ÉquipeEnnemie) && Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Troupes.Count > 0)
                  {
                      AttaqueGroupe = AppliquerBonus(AttaqueGroupe, Groupe, Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie), ÉquipeJoueur, ÉquipeEnnemie);
                      ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie), AttaqueGroupe, ÉquipeJoueur, nbTours);
                      if (Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Troupes.Count == 0)
                      {
                          Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Symbole = ' ';
                          Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].Symbole = ' ';
                      }
                      pasRestants = 0;
                   }
                  else if (!Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].EstInaccessible)
                  {
                      Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY].Symbole = ' ';
                      Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY - 1].Symbole = Groupe.Symbole;
                      --Groupe.Pos.PosY;
                      --pasRestants;
                      Terrain.AfficherCarteAvecAura(ÉquipeJoueur, Groupe, pasRestants, nbTours);
                      Console.WriteLine("    Pas restants: {0}", pasRestants);
                      AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                  }
              }
              else if (action == ConsoleKey.DownArrow)
              {
                  if (Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].EstUnGroupeEnnemie(ÉquipeEnnemie) && Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Troupes.Count > 0)
                  {
                      AttaqueGroupe = AppliquerBonus(AttaqueGroupe, Groupe, Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie), ÉquipeJoueur, ÉquipeEnnemie);
                      ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie), AttaqueGroupe, ÉquipeJoueur, nbTours);
                      if (Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Troupes.Count == 0)
                      {
                          Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Symbole = ' ';
                          Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].Symbole = ' ';
                      }
                      pasRestants = 0;
                  }
                  else if (!Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].EstInaccessible)
                  {
                      Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY].Symbole = ' ';
                      Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY + 1].Symbole = Groupe.Symbole;
                      ++Groupe.Pos.PosY;
                      --pasRestants;
                      Terrain.AfficherCarteAvecAura(ÉquipeJoueur, Groupe, pasRestants, nbTours);
                      Console.WriteLine("    Pas restants: {0}", pasRestants);
                      AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                  }
              }
              else if (action == ConsoleKey.RightArrow)
              {
                  if (Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].EstUnGroupeEnnemie(ÉquipeEnnemie) && Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Troupes.Count > 0)
                  {
                      AttaqueGroupe = AppliquerBonus(AttaqueGroupe, Groupe, Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie), ÉquipeJoueur, ÉquipeEnnemie);
                      ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie), AttaqueGroupe, ÉquipeJoueur, nbTours);
                      if (Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Troupes.Count == 0)
                      {
                          Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Symbole = ' ';
                          Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].Symbole = ' ';
                      }
                      pasRestants = 0;
                  }
                  else if (!Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].EstInaccessible)
                  {
                      Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY].Symbole = ' ';
                      Terrain.Grille[Groupe.Pos.PosX + 1, Groupe.Pos.PosY].Symbole = Groupe.Symbole;
                      ++Groupe.Pos.PosX;
                      --pasRestants;
                      Terrain.AfficherCarteAvecAura(ÉquipeJoueur, Groupe, pasRestants, nbTours);
                      Console.WriteLine("    Pas restants: {0}", pasRestants);
                      AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                  }
              }
              else if (action == ConsoleKey.LeftArrow)
              {
                  if (Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].EstUnGroupeEnnemie(ÉquipeEnnemie) && Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Troupes.Count > 0)
                  {
                      AttaqueGroupe = AppliquerBonus(AttaqueGroupe, Groupe, Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie), ÉquipeJoueur, ÉquipeJoueur);
                      ÉquipeEnnemie.ArméeJoueur.SubirDégâts(Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie), AttaqueGroupe, ÉquipeEnnemie, nbTours);
                      if (Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Troupes.Count == 0)
                      {
                          Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].LeGroupeMilitaire(ÉquipeJoueur, ÉquipeEnnemie).Symbole = ' ';
                          Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].Symbole = ' ';
                      }
                      pasRestants = 0;
                  }
                  else if (!Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].EstInaccessible)
                  {
                      Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY].Symbole = ' ';
                      Terrain.Grille[Groupe.Pos.PosX - 1, Groupe.Pos.PosY].Symbole = Groupe.Symbole;
                      --Groupe.Pos.PosX;
                      --pasRestants;
                      Terrain.AfficherCarteAvecAura(ÉquipeJoueur, Groupe, pasRestants, nbTours);
                      Console.WriteLine("    Pas restants: {0}", pasRestants);
                      AfficherDeuxÉquipes(ÉquipeJoueur, ÉquipeEnnemie);
                  }
              }
              #endregion
              else if ((char)action == ' ')
              {
                  pasRestants = 0;
              }
          }
          while (pasRestants > 0);
          
      }
      static void PathfindingAttaque(Carte Terrain, Équipe ÉquipeJoueur, Équipe ÉquipeEnnemie, GroupeMilitaire Groupe, int nbTours,char cible,int pasRestants,Attaque AttaqueGroupe)
      {
         #region Conditions
         GroupeMilitaire GroupeCiblé = new GroupeMilitaire(' ');
         if (cible == 'V')
         {
            GroupeCiblé = ÉquipeEnnemie.ArméeJoueur.Volant;
         }
         if (cible == 'I')
         {
            GroupeCiblé = ÉquipeEnnemie.ArméeJoueur.Infantrie;
         }
         if (cible == 'C')
         {
            GroupeCiblé = ÉquipeEnnemie.ArméeJoueur.Cavalrie;
         }
         if (cible == 'A')
         {
            GroupeCiblé = ÉquipeEnnemie.ArméeJoueur.Archer;
         }
         #endregion
         Terrain.Initialiser();
         Terrain.CalculerPoids(Groupe,GroupeCiblé);
         Terrain.TrouverPlusCourtChemin(GroupeCiblé);
         ArrayList listePositions = new ArrayList();
         listePositions.Add(Groupe.Pos);
         if (((Être)Groupe.Troupes[0]).Type == "Archer")
         {
             AttaqueGroupe.Dégâts /= 2;
         }
         while (Terrain.PlusCourtChemin.Count > 0)
         {
             listePositions.Add((Position)Terrain.PlusCourtChemin.Pop());
         }
         for (int i=0;i<listePositions.Count;++i)
         {
             if (pasRestants > 0)
             {
                 if (((Position)listePositions[i + 1]) == GroupeCiblé.Pos)
                 {
                     Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY].Symbole = ' ';
                     Groupe.Pos = (Position)listePositions[i];
                     Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY].Symbole = Groupe.Symbole;
                     --pasRestants;
                     Terrain.AfficherCarteAvecAura(ÉquipeJoueur, Groupe, pasRestants, nbTours);
                     Console.WriteLine("    Pas restants: {0}", pasRestants);
                     System.Threading.Thread.Sleep(100);
                     AppliquerBonus(AttaqueGroupe, Groupe, GroupeCiblé, ÉquipeJoueur, ÉquipeEnnemie);
                     ÉquipeEnnemie.ArméeJoueur.SubirDégâts(GroupeCiblé, AttaqueGroupe, ÉquipeJoueur, nbTours);
                     if (GroupeCiblé.Troupes.Count == 0)
                     {
                         Terrain.Grille[GroupeCiblé.Pos.PosX, GroupeCiblé.Pos.PosY].Symbole = ' ';
                         GroupeCiblé.Pos = new Position(2, 2);
                     }
                     pasRestants = 0;
                     
                     System.Threading.Thread.Sleep(700);
                 }
                 else
                 {
                     Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY].Symbole = ' ';
                     Groupe.Pos = (Position)listePositions[i];
                     Terrain.Grille[Groupe.Pos.PosX, Groupe.Pos.PosY].Symbole = Groupe.Symbole;
                     --pasRestants;
                     Terrain.AfficherCarteAvecAura(ÉquipeJoueur, Groupe, pasRestants, nbTours);
                     Console.WriteLine("    Pas restants: {0}", pasRestants);
                     System.Threading.Thread.Sleep(150);
                 }
             }
             else
             {
                 listePositions.Clear();
             }
         }
      }
      static public Attaque AppliquerBonus(Attaque AttaqueGroupe, GroupeMilitaire Groupe, GroupeMilitaire GroupeVictime,Équipe ÉquipeJoueur,Équipe ÉquipeEnnemie)
      {
          if (Groupe == ÉquipeJoueur.ArméeJoueur.Infantrie && GroupeVictime == ÉquipeEnnemie.ArméeJoueur.Cavalrie)
          {
              AttaqueGroupe.Dégâts *= 1.70f;
          }
          else if (Groupe == ÉquipeJoueur.ArméeJoueur.Cavalrie && GroupeVictime == ÉquipeEnnemie.ArméeJoueur.Archer)
          {
              AttaqueGroupe.Dégâts *= 1.5f;
          }
          else if (Groupe == ÉquipeJoueur.ArméeJoueur.Archer && GroupeVictime == ÉquipeEnnemie.ArméeJoueur.Infantrie)
          {
              AttaqueGroupe.Dégâts *= 1.5f;
          }
          else if (Groupe == ÉquipeJoueur.ArméeJoueur.Archer && GroupeVictime == ÉquipeEnnemie.ArméeJoueur.Volant)
          {
              AttaqueGroupe.Dégâts *= 1.25f;
          }
          return AttaqueGroupe;
      }
      static GroupeMilitaire ChoisirCible(Équipe ÉquipeEnnemie)
      {
          GroupeMilitaire choix = new GroupeMilitaire(' ');
          string key = "b";
          do
          {
              key = Console.ReadLine().ToUpper();
              key = Vérifier(key);
          }
          while (key != "I" && key != "C" && key != "A" && key != "V");
          do
          {


              if (key == "I" && ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count == 0)
              {
                  do
                  {
                      Console.WriteLine("       Ce groupe d'ennemis est vide. ");
                      Console.Write("       Choisissez un autre groupe. ");
                      key = Console.ReadLine().ToUpper();
                      key = Vérifier(key);
                  }
                  while (key != "C" && key != "A" && key != "V");
              }
              if (key == "I" && ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count > 0)
              {
                  choix = ÉquipeEnnemie.ArméeJoueur.Infantrie;
              }

              if (key == "C" && ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count == 0)
              {
                  do
                  {
                      Console.WriteLine("       Ce groupe d'ennemis est vide. ");
                      Console.Write("       Choisissez un autre groupe. ");
                      key = Console.ReadLine().ToUpper();
                      key = Vérifier(key);
                  }
                  while (key != "I" && key != "A" && key != "V");
              }
              if (key == "C" && ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count > 0)
              {
                  choix = ÉquipeEnnemie.ArméeJoueur.Cavalrie;
              }

              if (key == "A" && ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count == 0)
              {
                  do
                  {
                      Console.WriteLine("       Ce groupe d'ennemis est vide. ");
                      Console.Write("       Choisissez un autre groupe. ");
                      key = Console.ReadLine().ToUpper();
                      key = Vérifier(key);
                  }
                  while (key != "I" && key != "C" && key != "V");
              }
              if (key == "A" && ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count > 0)
              {
                  choix = ÉquipeEnnemie.ArméeJoueur.Archer;
              }

              if (key == "V" && ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count == 0)
              {
                  do
                  {
                      Console.WriteLine("       Ce groupe d'ennemis est vide. ");
                      Console.Write("       Choisissez un autre groupe. ");
                      key = Console.ReadLine().ToUpper();
                      key = Vérifier(key);
                  }
                  while (key != "I" && key != "C" && key != "A");
              }
              if (key == "V" && ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count > 0)
              {
                  choix = ÉquipeEnnemie.ArméeJoueur.Volant;
              }
          }
          while (choix.Troupes.Count == 0);
          return choix;

      }
      static string Vérifier(string key)
      {
         if (key.Contains("ARC") || key.Contains("ARB") || key.Contains("ELF") || key.Contains("LICH") || key.Contains("GOG")) { key = "A"; }
         else if (key.Contains("INF") || key.Contains("NAI") || key.Contains("HAL") || key.Contains("SQU") || key.Contains("DÉM") || key.Contains("ENT")) { key = "I"; }
         else if (key.Contains("CAV") || key.Contains("LICO") || key.Contains("CHAMP") || key.Contains("MANT")) { key = "C"; }
         if (key.Contains("VOL") || key.Contains("ANG") || key.Contains("FAN") || key.Contains("DRAG") || key.Contains("EFF")) { key = "V"; }
         else if (key.Contains("MAX")) { key = "+"; }
         else if (key.Contains("NON")) { key = "N"; }
         else if (key.Contains("OUI")) { key = "O"; }
         else if (key.Contains("REV")) { key = "R"; }
         else if (key.Contains("ÉGL")) { key = "É"; }
         else if (key.Contains("HUM")) { key = "H"; }
         else if (key.Contains("CRÉ")) { key = "C"; }
         else if (key.Contains("MAUV")) { key = "M"; }
         else if (key.Contains("BON")) { key = "B"; }
         return key;
      }
      static int LireNombre(Équipe ÉquipeJoueur, int prix)
      {
         string lecture = "b";
         int Nb = 0;
         bool relire = true;
         do
         {
            Console.Write("     Combien en voulez-vous?  ");
            try
            {
               lecture = Console.ReadLine().ToUpper();
               Vérifier(lecture);
               if (lecture == "MAX")
               {
                  Nb = ÉquipeJoueur.Or / prix;
               }
               else
               {
                  Nb = int.Parse(lecture);
               }
               relire = false;
            }
            catch
            { }
            finally
            { }
         }
         while (relire);
         return Nb;
      }
      static void Option(Équipe ÉquipeJoueur)
      {
          Console.Clear();
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine("       Quelle couleur voulez-vous avoir?");
          string choix;
          choix = Console.ReadLine().ToUpper();
          if (choix.Contains("PALE") || choix.Contains("CLAIR"))
          {
              if (choix.Contains("RO"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Magenta;
              }
              else if (choix.Contains("BLE"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Cyan;
              }
              else if (choix.Contains("VER"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Green;
              }
              else if (choix.Contains("JAU"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Yellow;
              }
              else if (choix.Contains("BLE"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Blue;
              }
          }
          else if(choix.Contains("FONC")) 
          {
              if (choix.Contains("ROU"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.DarkRed;
              }
              else if (choix.Contains("BLE"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.DarkBlue;
              }
              else if (choix.Contains("CYAN"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.DarkCyan;
              }
              else if (choix.Contains("VER"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.DarkGreen;
              }
              else if (choix.Contains("JAU"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.DarkYellow;
              }
              else if (choix.Contains("BLA"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Gray;
              }
          }
          else
          {
              if (choix.Contains("MAU"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.DarkMagenta;
              }
              else if (choix.Contains("ROU"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Red;
              }
              else if (choix.Contains("BLE"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Blue;
              }
              else if (choix.Contains("CYAN"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Cyan;
              }
              else if (choix.Contains("VER"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.DarkGreen;
              }
              else if (choix.Contains("JAU"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Yellow;
              }
              else if (choix.Contains("BLA"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.White;
              }
              else if (choix.Contains("GRI"))
              {
                  ÉquipeJoueur.Couleur = ConsoleColor.Gray;
              }
          }
          Console.ForegroundColor = ÉquipeJoueur.Couleur;
                      
      }
      static void OptionsIntro()
      {
          Console.Clear();
          StreamReader lecteur = new StreamReader("Settings.txt");
          string baty = lecteur.ReadLine();
          string intro = lecteur.ReadLine();
          lecteur.Close();

          do
          {
              Console.WriteLine();
              Console.WriteLine();
              Console.Write("   Afficher Baty's programs: (Pésentement: {0} )", baty);
              baty = Console.ReadLine().ToUpper();
              baty = Vérifier(baty);
          }
          while (baty != "O" && baty != "N");
          do
          {
              Console.WriteLine();
              Console.WriteLine();
              Console.Write("   Jouer Introduction: (Pésentement: {0} )", intro);
              intro = Console.ReadLine().ToUpper();
              intro = Vérifier(intro);
          }
          while (intro != "O" && intro != "N");

          StreamWriter writer = new StreamWriter("Settings.txt");
          writer.WriteLine(baty);
          writer.WriteLine(intro);
          writer.Close();
          
      }
      static void Sauvegarder(Équipe ÉquipeJoueur)
      {
          
          StreamWriter sauveur = new StreamWriter("Sauvegarde.txt");
          sauveur.WriteLine(ÉquipeJoueur.Alignement);
          sauveur.WriteLine(ÉquipeJoueur.Race);
          sauveur.WriteLine(ÉquipeJoueur.BonusÉglise);
          sauveur.WriteLine(ÉquipeJoueur.BonusNécromancie);
          sauveur.WriteLine(ÉquipeJoueur.BonusRevanche);
          sauveur.WriteLine(ÉquipeJoueur.Église);
          sauveur.WriteLine(ÉquipeJoueur.ArcsLongs);
          sauveur.WriteLine(ÉquipeJoueur.ElfsAméloirés);
          sauveur.WriteLine(ÉquipeJoueur.Ents);
          sauveur.WriteLine(ÉquipeJoueur.Expérience);
          sauveur.WriteLine(ÉquipeJoueur.Magogs);
          sauveur.WriteLine(ÉquipeJoueur.Nécromancie);
          sauveur.WriteLine(ÉquipeJoueur.Or);
          sauveur.WriteLine(ÉquipeJoueur.PrixÉglise);
          sauveur.WriteLine(ÉquipeJoueur.PrixNécromancie);
          sauveur.WriteLine(ÉquipeJoueur.PrixRevanche);
          sauveur.WriteLine(ÉquipeJoueur.Revanche);
          sauveur.WriteLine(ÉquipeJoueur.Score);
          sauveur.WriteLine(ÉquipeJoueur.NbCombats);
          sauveur.WriteLine(ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count);
          sauveur.WriteLine(ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count);
          sauveur.WriteLine(ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count);
          sauveur.WriteLine(ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count);
          sauveur.Close();
      }
      static Équipe ChargerÉquipe()
      {
          StreamReader lecteur = new StreamReader("Sauvegarde.txt");
          Équipe ÉquipeJoueur = new Équipe(lecteur.ReadLine(), lecteur.ReadLine());
          ÉquipeJoueur.BonusÉglise = int.Parse(lecteur.ReadLine());
          ÉquipeJoueur.BonusNécromancie = int.Parse(lecteur.ReadLine());
          ÉquipeJoueur.BonusRevanche = float.Parse(lecteur.ReadLine());
          if (lecteur.ReadLine() == "True") { ÉquipeJoueur.Église = true; }
          if (lecteur.ReadLine() == "True") { ÉquipeJoueur.ArcsLongs = true; }
          if (lecteur.ReadLine() == "True") { ÉquipeJoueur.ElfsAméloirés = true; }
          if (lecteur.ReadLine() == "True") { ÉquipeJoueur.Ents = true; }
          ÉquipeJoueur.Expérience = float.Parse(lecteur.ReadLine());
          if (lecteur.ReadLine() == "True") { ÉquipeJoueur.Magogs = true; }
          if (lecteur.ReadLine() == "True") { ÉquipeJoueur.Nécromancie = true; }
          ÉquipeJoueur.Or = int.Parse(lecteur.ReadLine());
          ÉquipeJoueur.PrixÉglise = int.Parse(lecteur.ReadLine());
          ÉquipeJoueur.PrixNécromancie = int.Parse(lecteur.ReadLine());
          ÉquipeJoueur.PrixRevanche = int.Parse(lecteur.ReadLine());
          if (lecteur.ReadLine() == "True") { ÉquipeJoueur.Revanche = true; }
          ÉquipeJoueur.Score = int.Parse(lecteur.ReadLine());
          ÉquipeJoueur.NbCombats = int.Parse(lecteur.ReadLine());
          #region Armée

          ActiverBonusAjouterUnité(ÉquipeJoueur);
          int nbVolants = int.Parse(lecteur.ReadLine());
          int nbInfantrie = int.Parse(lecteur.ReadLine());
          int nbCavalrie = int.Parse(lecteur.ReadLine());
          int nbArcher = int.Parse(lecteur.ReadLine());
          for (int i = 0; i < nbVolants; ++i)
          {
              ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Add(new Volant());
          }
          for (int i = 0; i < nbInfantrie; ++i)
          {
              ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Add(new Infantrie());
          }
          for (int i = 0; i < nbCavalrie; ++i)
          {
              ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Add(new Cavalrie());
          }
          for (int i = 0; i < nbArcher; ++i)
          {
              ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Add(new Archer());
          }
          DésactiverBonusAjouterUnité();
          #endregion
          lecteur.Close();
          return ÉquipeJoueur;

      }
      static float CalculerDistance(GroupeMilitaire archers, GroupeMilitaire cible)
      {
          int distanceX = Math.Abs(archers.Pos.PosX - cible.Pos.PosX);
          int distanceY = Math.Abs(archers.Pos.PosY - cible.Pos.PosY);
          return (float)Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
      }
      public static float CalculerDistance(GroupeMilitaire archers, Position Pos)
      {
          int distanceX = Math.Abs(archers.Pos.PosX - Pos.PosX);
          int distanceY = Math.Abs(archers.Pos.PosY - Pos.PosY);
          return (float)Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
      }
      
      static void ActiverBonusAjouterUnité(Équipe ÉquipeJoueur)
      {
          if (ÉquipeJoueur.Créature)
          {
              Infantrie.BasePrix = (int)(Infantrie.BasePrix * 0.85f);
              Cavalrie.BasePrix = (int)(Cavalrie.BasePrix * 0.85f);
              Archer.BasePrix = (int)(Archer.BasePrix * 0.85f);
              Volant.BasePrix = (int)(Volant.BasePrix * 0.85f);
          }
          if (ÉquipeJoueur.Église)
          {
              Infantrie.BaseVie += ÉquipeJoueur.BonusÉglise;
              Cavalrie.BaseVie += ÉquipeJoueur.BonusÉglise * 2;
              Archer.BaseVie += ÉquipeJoueur.BonusÉglise;
              Volant.BaseVie += ÉquipeJoueur.BonusÉglise * 4;
              Volant.BaseDégâts += 50;
          }
          if (ÉquipeJoueur.ÊtreForêt)
          {
              Cavalrie.BaseVie -= 5;
          }
          if (ÉquipeJoueur.Ents)
          {
              Infantrie.BaseVitesse -= 5;
              Infantrie.BasePrix *= 3;
              Infantrie.BaseVie = 70;
              Infantrie.BaseDégâts = 20;
          }
          if (ÉquipeJoueur.ElfsAméloirés)
          {
              Archer.BaseVie += 5;
              Archer.BaseDégâts += 3;
              Archer.BasePortée += 3;
          }
          if (ÉquipeJoueur.Magogs)
          {
              Archer.BaseVie += 15;
              Archer.BaseDégâts += 2;
              Archer.BasePortée -= 4;
          }
          if (ÉquipeJoueur.Nécromantien)
          {
              Infantrie.BaseVie -= 12;
              Infantrie.BaseDégâts -= 3;
              Archer.BaseDégâts += 3;
              Cavalrie.BasePrix -= 10;
              Cavalrie.BaseVitesse += 5;
              Cavalrie.BaseDégâts += 3;
          }
      }
      static void DésactiverBonusAjouterUnité()
      {
          Infantrie.BasePrix = Infantrie.BASE_PRIX;
          Cavalrie.BasePrix = Cavalrie.BASE_PRIX;
          Archer.BasePrix = Archer.BASE_PRIX;
          Volant.BasePrix = Volant.BASE_PRIX;
          Infantrie.BaseVie = Infantrie.BASE_VIE;
          Cavalrie.BaseVie = Cavalrie.BASE_VIE;
          Archer.BaseVie = Archer.BASE_VIE;
          Volant.BaseVie = Volant.BASE_VIE;
          Infantrie.BaseDégâts = Infantrie.BASE_DÉGÂTS;
          Cavalrie.BaseDégâts = Cavalrie.BASE_DÉGÂTS;
          Archer.BaseDégâts = Archer.BASE_DÉGÂTS;
          Volant.BaseDégâts = Volant.BASE_DÉGÂTS;
          Infantrie.BaseVitesse = Infantrie.BASE_VITESSE;
          Cavalrie.BaseVitesse = Cavalrie.BASE_VITESSE;
          Archer.BaseVitesse = Archer.BASE_VITESSE;
          Volant.BaseVitesse = Volant.BASE_VITESSE;
          Archer.BasePortée = Archer.BASE_PORTÉE;
      }

      static void AfficherChoix(Équipe ÉquipeJoueur)
      {
         Console.Clear();
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("         Vous êtes un  " + ÉquipeJoueur.Nom);
         Console.WriteLine();
         Console.WriteLine();
         FichierTexte Ditact = new FichierTexte(""+(string)ÉquipeJoueur.Nom + ".txt");
         while (!Ditact.EOF)
         {
            Console.WriteLine(Ditact.LireChaîne());
            Beeper.Beep(37, 20);
         }
         Console.WriteLine();
         Console.WriteLine("     Appuyer sur une touche pour continuer.");
         Console.ReadKey();
      }
      static void AfficherMenuDidacticiel()
      {
         Console.Clear();
         FichierTexte Ditact = new FichierTexte("MenuDidacticiel.txt");
         while (!Ditact.EOF)
         {
            Console.WriteLine(Ditact.LireChaîne());
         }
      }
      static void AfficherArméeGroupesDidacticiel()
      {
         Console.Clear();
         FichierTexte Image = new FichierTexte("Groupes et Armée Didacticiel.txt");
         while (!Image.EOF)
         {
            Console.WriteLine(Image.LireChaîne());
         }
         Console.WriteLine("   Appuyer sur une touche pour continuer.");
         Console.Read();
      }
      static void AfficherÉquipeJoueur(Équipe ÉquipeJoueur)
      {
          Console.WriteLine("   Vous êtes un {0}.", ÉquipeJoueur.Nom);
         Console.WriteLine();
         Console.WriteLine("     Score: {0}", ÉquipeJoueur.Score);
         Console.WriteLine();
         Console.WriteLine("     Expérience: {0}", ÉquipeJoueur.Expérience);
         Console.WriteLine();
         Console.WriteLine("     Vous disposer de {0} pièces d'or.", ÉquipeJoueur.Or);
         Console.WriteLine();
         Console.WriteLine();

         if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0)
         {
             Console.WriteLine("     {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count, (int)ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes), ÉquipeJoueur.Infantrie, (int)((Être)ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes[0]).PointDeVie,((Être)ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes[0]).MaxVie);
         }
         else
         {
             Console.WriteLine("     {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count, 0, ÉquipeJoueur.Infantrie, 0,0);

         }
         if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0)
         {
             Console.WriteLine("     {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count, (int)ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes), ÉquipeJoueur.Cavalrie, (int)((Être)ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes[0]).PointDeVie,((Être)ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes[0]).MaxVie);
         }
         else
         {
             Console.WriteLine("     {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count, 0, ÉquipeJoueur.Cavalrie, 0,0);

         }
         if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0)
         {
             Console.WriteLine("     {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count, (int)ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Archer.Troupes), ÉquipeJoueur.Archer, (int)((Être)ÉquipeJoueur.ArméeJoueur.Archer.Troupes[0]).PointDeVie,((Être)ÉquipeJoueur.ArméeJoueur.Archer.Troupes[0]).MaxVie);
         }
         else
         {
             Console.WriteLine("     {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count, 0, ÉquipeJoueur.Archer, 0,0);

         }
         if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0)
         {
             Console.WriteLine("     {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count, (int)ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Volant.Troupes), ÉquipeJoueur.Volant, (int)((Être)ÉquipeJoueur.ArméeJoueur.Volant.Troupes[0]).PointDeVie,((Être)ÉquipeJoueur.ArméeJoueur.Volant.Troupes[0]).MaxVie);
         }
         else
         {
             Console.WriteLine("     {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count, 0, ÉquipeJoueur.Volant, 0,0);

         } 
         Console.WriteLine();
         Console.WriteLine();
         if (ÉquipeJoueur.Revanche)
         {
             Console.WriteLine("    Bonus Riposte: {0}% de la force", ÉquipeJoueur.BonusRevanche*100);
         }
         
         if (ÉquipeJoueur.Nécromancie)
         {
             Console.WriteLine("    Bonus Nécromancie: 1 chance sur {0} d'appliquer le sort", ÉquipeJoueur.BonusNécromancie);
         }
         if (ÉquipeJoueur.Église)
         {
             Console.WriteLine("    Bonus Église: {0} pts de vie de plus", ÉquipeJoueur.BonusÉglise);
         }
         Console.WriteLine();
         Console.WriteLine("     Vous avez fait {0} combats.",ÉquipeJoueur.NbCombats);
         Console.WriteLine();
         Console.WriteLine();

      }
      static void AfficherMenuJeuDidacticiel()
      {
         Console.Clear();
         FichierTexte Image = new FichierTexte("MenuDeJeuDidacticiel.txt");
         while (!Image.EOF)
         {
            Console.WriteLine(Image.LireChaîne());
         }
         Console.WriteLine("   Appuyer sur une touche pour continuer.");
         Console.Read();
      }
      static void AfficherMenuJeu()
      {
         Console.Clear();
         FichierTexte Image = new FichierTexte("MenuDeJeu.txt");
         while (!Image.EOF)
         {
            Console.WriteLine(Image.LireChaîne());
         }
      }
      static public void AfficherDeuxÉquipes(Équipe ÉquipeJoueur, Équipe ÉquipeEnnemie)
      {
          if (ÉquipeJoueur.EstCPU||ÉquipeJoueur.EstJoueur2)
          {
              Équipe Tempo = new Équipe("Neutre", "Immigrant");
              Tempo = ÉquipeEnnemie;
              ÉquipeEnnemie = ÉquipeJoueur;
              ÉquipeJoueur = Tempo;
          }
          

          Console.WriteLine();
          Console.ForegroundColor = ÉquipeJoueur.Couleur;
          Console.Write("             Vous                                                   ");
          Console.ForegroundColor = ÉquipeEnnemie.Couleur;
          Console.WriteLine("L'ennemi");
          #region Infantrie
          Console.ForegroundColor = ÉquipeJoueur.Couleur;
          if (ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count > 0)
          {
              Console.Write("   {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count, (int)ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes), ÉquipeJoueur.Infantrie, (int)((Être)ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes[0]).PointDeVie,((Être)ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes[0]).MaxVie);
          }
          else
          {
              Console.Write("   {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Infantrie.Troupes.Count, 0, ÉquipeJoueur.Infantrie, 0, 0);

          }
          Console.ForegroundColor = ÉquipeEnnemie.Couleur;
          if (ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count > 0)
          {
              Console.WriteLine("           {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count, (int)ÉquipeEnnemie.ArméeJoueur.Attaquer(ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes), ÉquipeEnnemie.Infantrie, (int)((Être)ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes[0]).PointDeVie, ((Être)ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes[0]).MaxVie);
          }
          else
          {
              Console.WriteLine("           {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeEnnemie.ArméeJoueur.Infantrie.Troupes.Count, 0, ÉquipeEnnemie.Infantrie, 0, 0);
          }
          #endregion
          #region Cavalrie
          Console.ForegroundColor = ÉquipeJoueur.Couleur;
          if (ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count > 0)
          {
              Console.Write("       {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count, (int)ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes), ÉquipeJoueur.Cavalrie, (int)((Être)ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes[0]).PointDeVie,((Être)ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes[0]).MaxVie);
          }
          else
          {
              Console.Write("       {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Cavalrie.Troupes.Count, 0, ÉquipeJoueur.Cavalrie, 0, 0);

          }
          Console.ForegroundColor = ÉquipeEnnemie.Couleur;
          if (ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count > 0)
          {
              Console.WriteLine("           {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count, (int)ÉquipeEnnemie.ArméeJoueur.Attaquer(ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes), ÉquipeEnnemie.Cavalrie, (int)((Être)ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes[0]).PointDeVie, ((Être)ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes[0]).MaxVie);
          }
          else
          {
              Console.WriteLine("           {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeEnnemie.ArméeJoueur.Cavalrie.Troupes.Count, 0, ÉquipeEnnemie.Cavalrie, 0, 0);
          }
          #endregion
          #region Archer
          Console.ForegroundColor = ÉquipeJoueur.Couleur;
          if (ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count > 0)
          {
              Console.Write("   {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count, (int)ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Archer.Troupes), ÉquipeJoueur.Archer, (int)((Être)ÉquipeJoueur.ArméeJoueur.Archer.Troupes[0]).PointDeVie,((Être)ÉquipeJoueur.ArméeJoueur.Archer.Troupes[0]).MaxVie);
          }
          else
          {
              Console.Write("   {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Archer.Troupes.Count, 0, ÉquipeJoueur.Archer, 0, 0);

          }
          Console.ForegroundColor = ÉquipeEnnemie.Couleur;
          if (ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count > 0)
          {
              Console.WriteLine("           {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count, (int)ÉquipeEnnemie.ArméeJoueur.Attaquer(ÉquipeEnnemie.ArméeJoueur.Archer.Troupes), ÉquipeEnnemie.Archer, (int)((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).PointDeVie, ((Être)ÉquipeEnnemie.ArméeJoueur.Archer.Troupes[0]).MaxVie);
          }
          else
          {
              Console.WriteLine("           {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeEnnemie.ArméeJoueur.Archer.Troupes.Count, 0, ÉquipeEnnemie.Archer, 0, 0);
          }
          #endregion
          #region Volant
          Console.ForegroundColor = ÉquipeJoueur.Couleur;
          if (ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count > 0)
          {
              Console.Write("   {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count, (int)ÉquipeJoueur.ArméeJoueur.Attaquer(ÉquipeJoueur.ArméeJoueur.Volant.Troupes), ÉquipeJoueur.Volant, (int)((Être)ÉquipeJoueur.ArméeJoueur.Volant.Troupes[0]).PointDeVie,((Être)ÉquipeJoueur.ArméeJoueur.Volant.Troupes[0]).MaxVie);
          }
          else
          {
              Console.Write("   {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeJoueur.ArméeJoueur.Volant.Troupes.Count, 0, ÉquipeJoueur.Volant, 0, 0);

          }
          Console.ForegroundColor = ÉquipeEnnemie.Couleur;
          if (ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count > 0)
          {
              Console.WriteLine("           {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count, (int)ÉquipeEnnemie.ArméeJoueur.Attaquer(ÉquipeEnnemie.ArméeJoueur.Volant.Troupes), ÉquipeEnnemie.Volant, (int)((Être)ÉquipeEnnemie.ArméeJoueur.Volant.Troupes[0]).PointDeVie, ((Être)ÉquipeEnnemie.ArméeJoueur.Volant.Troupes[0]).MaxVie);
          }
          else
          {
              Console.WriteLine("           {0} {2} Pts de vie: {3}/{4} - Attaque: {1}", ÉquipeEnnemie.ArméeJoueur.Volant.Troupes.Count, 0, ÉquipeEnnemie.Volant, 0, 0);
          }
          #endregion

          Console.WriteLine();

      }
      static void AfficherDidacticielCombat()
      {
         Console.Clear();
         FichierTexte Image = new FichierTexte("DidacticielCombat.txt");
         while (!Image.EOF)
         {
            Console.WriteLine(Image.LireChaîne());
         }
         Console.WriteLine("     Appuyer sur une touche lorsque vous serez prêt.");
         Console.ReadKey();
      }
      
   }
}
