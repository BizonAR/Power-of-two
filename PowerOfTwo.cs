using System;

namespace PowerOfTwo
{
	internal class PowerOfTwo
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int number;

			number = random.Next();

			int finishNumber = 1;
			int exponent = 0;
			int multiplier = 2;

			while (finishNumber <= number)
			{
				finishNumber *= multiplier;
				exponent++;
			}

			Console.WriteLine($"Число: {number}");
			Console.WriteLine($"Минимальная степень {multiplier}, превосходящая число: {multiplier} " +
				$"в степени {exponent} = {finishNumber}");
		}
	}
}
