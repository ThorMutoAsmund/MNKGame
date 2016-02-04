using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNKGame
{
    public class GameEngine
    {
        private Piece Own { get; set; }

        private int M { get; set; }
        private int N { get; set; }
        private int K { get; set; }

        private Board Board { get; set; }
        private int Total { get { return this.M * this.N; } }

        public GameEngine(int m, int n, int k, Piece own)
        {
            this.M = m;
            this.N = n;
            this.K = k;
            this.Own = own;
        }

        public void Start()
        {
            this.Board = new Board(this.M, this.N);
            this.Board.Show();
        }

    }
}
