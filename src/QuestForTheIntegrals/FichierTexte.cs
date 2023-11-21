using System;
using System.IO;

namespace Quest_For_The_Integrals
{
   class FichierTexte
   {
      public class FichierIntrouvableException : ApplicationException { }
      public class NomFichierInvalideException : ApplicationException { }
      public class ActionInvalideException : ApplicationException { }

      public enum Mode {Lecture, Écriture, Ajout}

      public FichierTexte(string nomFichier)
      {
         NomFichier = nomFichier;
         ModeOuverture = Mode.Lecture;
         OuvrirFichier();
      }

      public FichierTexte(string nomFichier, Mode modeOuverture)
      {
         NomFichier = nomFichier;
         ModeOuverture = modeOuverture;
         OuvrirFichier();
      }

      ~FichierTexte()
      {
         Close();
      }

      private void OuvrirFichier()
      {
         FichierOuvert = false;
         if (ModeOuverture == Mode.Lecture)
         {
            FLecture = new StreamReader(NomFichier);
            FichierOuvert = FLecture != null;
            EOF = FLecture.EndOfStream;
         }
         else
         {
            if (ModeOuverture == Mode.Écriture)
            {
               FÉcriture = new StreamWriter(NomFichier);
               FichierOuvert = FÉcriture != null;
            }
            else
            {
               FÉcriture = new StreamWriter(NomFichier, true);
               FichierOuvert = FÉcriture != null;
            }
         }
      }

      public void Close()
      {
         if (FichierOuvert)
         {
            if (ModeOuverture == Mode.Lecture)
            {
               FLecture.Close();
            }
            else
            {
               FÉcriture.Close();
            }
         }
         FichierOuvert = false;
      }

      public string LireChaîne()
      {
         string Chaîne;

         EOF = FLecture.EndOfStream;
         if (ModeOuverture != Mode.Lecture)
         {
            throw new ActionInvalideException();
         }
         Chaîne = FLecture.ReadLine();
         return Chaîne;
      }

      public int LireEntier()
      {
         string Chaîne;
         int ValChaîne;

         if (ModeOuverture != Mode.Lecture)
         {
            throw new ActionInvalideException();
         }
         if (!EOF)
         {
            Chaîne = LireChaîne();
            ValChaîne = int.Parse(Chaîne);
         }
         else
         {
            ValChaîne = 0;
         }
         return ValChaîne;
      }

      public float LireRéel()
      {
         string Chaîne;
         float ValChaîne;

         if (ModeOuverture != Mode.Lecture)
         {
            throw new ActionInvalideException();
         }
         if (!EOF)
         {
            Chaîne = LireChaîne();
            ValChaîne = float.Parse(Chaîne);
         }
         else
         {
            ValChaîne = 0;
         }
         return ValChaîne;
      }

      public string NomFichier
      {
         get { return nomFichier_; }
         private set
         {
            if (value == null || value.Length == TAILLE_CHAÎNE_VIDE)
            {
               throw new NomFichierInvalideException();
            }
            nomFichier_ = value;
         }
      }

      private Mode ModeOuverture
      {
         get { return modeOuverture_; }
         set { modeOuverture_ = value; }
      }

      public StreamReader FLecture
      {
         get { return fLecture_; }
         private set { fLecture_ = value; }
      }

      public StreamWriter FÉcriture
      {
         get { return fÉcriture_; }
         private set { fÉcriture_ = value; }
      }

      private bool FichierOuvert
      {
         get { return fichierOuvert_; }
         set { fichierOuvert_ = true; }
      }

      public bool EOF
      {
         get { return eof_; }
         private set { eof_ = value; }
      }

      const int TAILLE_CHAÎNE_VIDE = 0;
      string nomFichier_;
      Mode modeOuverture_;
      StreamReader fLecture_;
      StreamWriter fÉcriture_;
      bool fichierOuvert_;
      bool eof_;
   }
}
