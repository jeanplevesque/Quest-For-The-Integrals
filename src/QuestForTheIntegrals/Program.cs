using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace Quest_For_The_Integrals
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Baty's Programs presents";
                StreamReader lecteur = new StreamReader("Settings.txt");
                if (lecteur.ReadLine() == "O")
                {
                    BatysPrograms();
                }
                lecteur.Close();
                MoteurDeJeu.Run();
            }
            catch (Exception UneException)
            {
                Console.WriteLine(UneException.Message);
                System.Threading.Thread.Sleep(5000);
            }
            finally
            {
                MoteurDeJeu.Run();
            }
        }
        static void BatysPrograms()
        {
           for (int i = 0; i < 6; ++i)
           {
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine();
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.Write("         /");
              Console.ForegroundColor = ConsoleColor.DarkGray;
              Console.Write(" Baty's Programs present ");
              Console.ForegroundColor = ConsoleColor.Green;
              Console.Write( "\\");
              //Beeper.Beep(50, 25);
              //Beeper.Beep(100, 25);
              Beeper.Beep(100, 50);
              
              Console.Clear();
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine();
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write("         -");
              Console.ForegroundColor = ConsoleColor.Gray;
              Console.Write(" Baty's Programs present ");
              Console.ForegroundColor = ConsoleColor.Cyan;
              Console.Write("-");
              //Beeper.Beep(200, 25);
              //Beeper.Beep(400, 25);
              Beeper.Beep(400, 50);

              Console.Clear();
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine();
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.Write("         \\");
              Console.ForegroundColor = ConsoleColor.White;
              Console.Write(" Baty's Programs present ");
              Console.ForegroundColor = ConsoleColor.Magenta;
              Console.Write("/");
              //Beeper.Beep(400, 25);
              //Beeper.Beep(200, 25);
              Beeper.Beep(200, 50);

              Console.Clear();
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine();
              Console.ForegroundColor = ConsoleColor.Cyan;
              Console.Write("         |");
              Console.ForegroundColor = ConsoleColor.Gray;
              Console.Write(" Baty's Programs present ");
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.Write("|");
              //Beeper.Beep(100, 25);
              //Beeper.Beep(50, 25);
              Beeper.Beep(50, 50);
              Console.Clear();


           }
           System.Threading.Thread.Sleep(300);
        }
    }
}
