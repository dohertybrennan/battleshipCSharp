using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipFinal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int shotCount=0;
			Intro ();
			GetShotCount (out shotCount);
			GameBoard b = new GameBoard ();
			Ship s = new Ship ();

		}

		public static void Intro()
		{
			Console.WriteLine ("Welcome to Brennansoft's Battleship!\nThis game will allow you to pick a difficulty based on number of shots and allow you to fire missles at you enemy.");
			Console.WriteLine ("\nPress any key to continue...");
			Console.ReadKey ();
			Console.Clear ();
		}

		public static void GetShotCount (out int shotCount)
		{
			string userInput;
			bool validInput = false;
			shotCount = 0;


			while (validInput == false) {
				Console.WriteLine ("What difficulty would you like to play with? (Please enter the corrisponding number for your choice):\n1: Easy (50 shots)\n2: Medium (40 shots)\n3: Hard (30 shots)");
				userInput = Console.ReadLine ();
				if (userInput == "1") {
					shotCount = 50;
					validInput = true;
				}
				else if (userInput == "2") {
					shotCount = 40;
					validInput = true;
				}
				else if (userInput == "3") {
					shotCount = 30;
					validInput = true;
				} 
				else {
					Console.WriteLine ("This is not a valid input. Try again!");
				}
			}
		}
	}
}
