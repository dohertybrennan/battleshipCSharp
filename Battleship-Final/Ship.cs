using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleshipFinal
{
	public class Ship
	{
		

		public Ship ()
		{
			//int shotsFired = 0;
			int carrier, battleship, cruiserA, cruiserB, destroyer;
			int yCarrierMin, yBattleshipMin, yCruiserAMin, yCruiserBMin, yDestroyerMin;
			ShipPlacement (out carrier, out battleship, out cruiserA, out cruiserB, out destroyer);
			RowPlacement (out yCarrierMin, out yBattleshipMin, out yCruiserAMin, out yCruiserBMin, out yDestroyerMin);


		}

		static Random rnd = new Random ((int)DateTime.Now.Ticks);

		public static void ShipPlacement (out int carrier, out int battleship, out int cruiserA, out int cruiserB, out int destroyer)
		{
			List<int> xPlacement = new List<int>();


			xPlacement.Add (1);
			xPlacement.Add (2);
			xPlacement.Add (3);
			xPlacement.Add (4);
			xPlacement.Add (5);
			xPlacement.Add (6);
			xPlacement.Add (7);
			xPlacement.Add (8);
			xPlacement.Add (9);
			xPlacement.Add (10);

			carrier = rnd.Next (xPlacement.Count);
			xPlacement.RemoveAt (carrier);

			battleship = rnd.Next (xPlacement.Count);
			xPlacement.RemoveAt (battleship);

			cruiserA = rnd.Next (xPlacement.Count);
			xPlacement.RemoveAt (cruiserA);

			cruiserB = rnd.Next (xPlacement.Count);
			xPlacement.RemoveAt (cruiserB);

			destroyer = rnd.Next (xPlacement.Count);
			xPlacement.RemoveAt (destroyer);

//			return carrier;
//			return battleship;
//			return cruiserA;
//			return cruiserB;
//			return destroyer;
		}

		public static void RowPlacement (out int yCarrierMin, out int yBattleshipMin, out int yCruiserAMin, out int yCruiserBMin, out int yDestroyerMin)
		{
			int[] yPlacementValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			yCarrierMin = yPlacementValues [rnd.Next (0,5)];
			yBattleshipMin = yPlacementValues [rnd.Next (0,6)];
			yCruiserAMin = yPlacementValues [rnd.Next (0,7)];
			yCruiserBMin = yPlacementValues [rnd.Next (0,7)];
			yDestroyerMin = yPlacementValues [rnd.Next (0,8)];

//			return yCarrierMin;
//			return yBattleshipMin;
//			return yCruiserAMin;
//			return yCruiserBMin;
//			return yDestroyerMin;
		}

		public static void FinalShipPlacement (ref int carrier, ref int battleship, ref int cruiserA, ref int cruiserB, ref int destroyer, ref int yCarrierMin, ref int yBattleshipMin, ref int yCruiserAMin, ref int yCruiserBMin, ref int yDestroyerMin)
		{
			int[,] ShipBoard = new int[11,11];

			int yCarrierMax = yCarrierMin + 5;
			int yBattleshipMax = yBattleshipMin + 4;
			int yCruiserAMax = yCruiserAMin + 3;
			int yCruiserBMax = yCruiserBMin + 3;
			int yDestroyerMax = yDestroyerMin + 2;

//			for (int i = yCarrierMin; i < yCarrierMax; i++) {
//				ShipBoard [carrier, i];
//			}
		}
	}
}

