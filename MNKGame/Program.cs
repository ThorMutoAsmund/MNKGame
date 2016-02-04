using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNKGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to play noughts (O) or crosses (X) or quit (Q) ?");
            ConsoleKeyInfo c;
            do
            {
                c = Console.ReadKey();
            }
            while (c.KeyChar != 'q' && c.KeyChar != 'Q' &&
            c.KeyChar != 'x' && c.KeyChar != 'X' &&
            c.KeyChar != 'o' && c.KeyChar != 'O');

            if (c.KeyChar != 'q' && c.KeyChar != 'Q')
            {
                Console.WriteLine();

                GameEngine engine = new GameEngine(3, 3, 3, c.KeyChar == 'x' || c.KeyChar == 'X' ? Piece.Nought : Piece.Cross);
                engine.Start();
                Console.ReadKey();
            }
        }
    }
}
