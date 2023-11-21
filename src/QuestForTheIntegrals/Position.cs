using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_For_The_Integrals
{
    class Position
    {
        public enum DirectionValide { Est, Nord, Ouest, Sud, NB_DIRECTIONS }
        int x_;
        int y_;
        DirectionValide direction_;

        public Position(int valX, int valY, DirectionValide uneDirection)
        {
            PosX = valX;
            PosY = valY;
            Direction = uneDirection;
        }

        public Position(int valX, int valY)
        {
            PosX = valX;
            PosY = valY;
            Direction = DirectionValide.Est;
        }

        private Position(Position posACopier)
        {
            PosX = posACopier.PosX;
            PosY = posACopier.PosY;
            Direction = posACopier.Direction;
        }

        public Position Clone()
        {
            return new Position(this);
        }

        public int PosX
        {
            get { return x_; }
            set { x_ = value; }
        }

        public int PosY
        {
            get { return y_; }
            set { y_ = value; }
        }

        public DirectionValide Direction
        {
            get { return direction_; }
            set { direction_ = value; }
        }

        public override int GetHashCode()
        {
            return PosX * 1000 + PosY * 10 + (int)Direction;
        }

        public override bool Equals(object Droite)
        {
            return Droite != null && GetType() == Droite.GetType() && this == (Position)Droite;
        }

        public static bool operator ==(Position Gauche, Position Droite)
        {
            return Gauche.PosX == Droite.PosX && Gauche.PosY == Droite.PosY;
        }

        public static bool operator !=(Position Gauche, Position Droite)
        {
            return Gauche.PosX != Droite.PosX || Gauche.PosY != Droite.PosY;
        }
    }
}
