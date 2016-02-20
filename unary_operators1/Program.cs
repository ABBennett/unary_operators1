using System;

namespace unary_operators1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int unary = 0;
			int preIncrement;
			int preDecrement;
			int postIncrement;
			int postDecrement;
			int positive;
			int negative;
			sbyte bitNot;
			bool logNot;

			preIncrement = ++unary;
			Console.WriteLine("pre-Increment: {0}", preIncrement);

			preDecrement = --unary;
			Console.WriteLine("pre-Decrement: {0}", preDecrement);
		}
	}
}
