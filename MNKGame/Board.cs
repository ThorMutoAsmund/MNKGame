using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNKGame
{
    public class Board
    {
        private int M { get; set; }
        private int N { get; set; }
        public Piece[] Grid { get; private set; }

        private int Total { get { return this.M * this.N; } }

        public Board(int m, int n)
        {
            this.M = m;
            this.N = n;
            this.Grid = new Piece[this.Total];
            Reset();
        }

        public void Set(int i, Piece piece)
        {
            this.Grid[i] = piece;
        }

        public void Reset()
        {
            Range.Create(this.Total).ForEach(i => Set(i, Piece.None));
        }

        public IEnumerable<PossibleMove> GetPossibleMoves(Piece player)
        {
            return Range.Create(this.Total).Where(i => this.Grid[i] == Piece.None).Select(i => new PossibleMove(i, player));
        }

        public void Show()
        {
            for (int n = 0; n < this.N; ++n)
            {
                Console.Write("|");
                for (int m = 0; m < this.M; ++m)
                {
                    switch (this.Grid[n * this.M + m])
                    {
                        case Piece.None: Console.Write(" "); break;
                        case Piece.Nought: Console.Write("O"); break;
                        case Piece.Cross: Console.Write("X"); break;
                    }
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
