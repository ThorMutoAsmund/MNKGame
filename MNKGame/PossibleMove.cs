using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNKGame
{
    public class PossibleMove
    {
        public int Location { get; set; }
        public Piece Piece { get; set; }

        public PossibleMove(int location, Piece piece)
        {
            this.Location = location;
            this.Piece = piece;
        }
    }
}
