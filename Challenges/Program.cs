using System;

namespace Challenges
{
    class Program
    {
		static int highScore = 300;
		static string highscorePlayer = "jsx";

        static void Main(string[] args)
		{

			int b = 5;
			char a = (char)(b + 1);
			Console.WriteLine(Convert.ToString(a));
			Console.ReadKey();
		}
		private static void Challenge1()
		{
			string name;
			Console.WriteLine("Please enter your name and press enter");
			name = Console.ReadLine();
			Console.Clear();
			Console.WriteLine(name.ToUpper());
			Console.WriteLine(name.ToLower());
			Console.WriteLine(name.Substring(0, 5));
			Console.WriteLine(name.Trim());
		}

		private static void Challenge2()
		{
			string userInput;
			int lookupChar;
			Console.WriteLine("Enter a string here: ");
			userInput = Console.ReadLine();
			Console.WriteLine("Enter the character to search: ");
			lookupChar = Console.Read();
			Console.WriteLine(String.Format("The first occurrence of the char {0} in {1} is at index {2}", userInput, (char)lookupChar, userInput.IndexOf((char)lookupChar)));
			Console.Read();
		}

	}
}
