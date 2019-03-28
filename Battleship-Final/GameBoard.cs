using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipFinal
{
	public class GameBoard
	{
		public GameBoard ()
		{
			int row, column;
			string[,] board = new string[11,11]
			{
				{ "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" },
				{ "1", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "2", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "3", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "4", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "5", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "6", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "7", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "9", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
				{ "10", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " }
			};

			row = board.GetLength (0);
			column = board.GetLength (1);

			for (int i = 0; i < row; i++) {
				for (int j = 0; j < column; j++) {
					Console.Write (string.Format ("{0}\t", board [i, j]));
				}
				Console.Write (Environment.NewLine + Environment.NewLine);
			}

			Ship s = new Ship();
			//s.RowPlacement ();
		}

		public static void FinalBoard ()
		{

		}
	}
}

