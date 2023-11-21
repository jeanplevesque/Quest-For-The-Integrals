using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Quest_For_The_Integrals
{
    class GroupeMilitaire
    {
        public GroupeMilitaire(char symbole)
        {
            Symbole = symbole;
            Troupes = new ArrayList();
        }
        public Position Pos
        {
            get { return pos_; }
            set { pos_ = value; }
        }

        public char Symbole
        {
            get { return symbole_; }
            set { symbole_ = value; }
        }
        public ArrayList Troupes
        {
            get { return troupes_; }
            set { troupes_ = value; }
        }
        Position pos_;
        char symbole_;
        ArrayList troupes_;

    }
}
