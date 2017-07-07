using System;
namespace exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			var value = 'O';
			for (int i = 0; i < 8; i++)
			{
				if (value == 'X')
					value = 'O';
				else
					value = 'X';
				
				for (int j = 0; j < 8; j++)
				{
					Console.Write(value);
					if (value == 'X')
						value = 'O';
					else
						value = 'X';
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}