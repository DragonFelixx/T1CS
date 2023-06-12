using System;

namespace T1CS
{

	class Program
	{
		static void Main(string[] args)
		{


			Console.Write("Введите размер матрицы: ");
			int n = int.Parse(Console.ReadLine());

			int[,] arr = new int[n, n];

			Console.WriteLine("Введите элементы матрицы: ");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("Элемент [{0}, {1}]: ", i, j);
					arr[i, j] = int.Parse(Console.ReadLine());
				}
			}

			Console.WriteLine("Матрица: ");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(arr[i, j] + " ");
				}
				Console.WriteLine();
			}

			int count = 0;

			for (int i = 0; i < n; i++)
			{
				int difference = arr[i, 1] - arr[i, 0];

				for (int j = 2; j < n; j++)
				{
					if (arr[i, j] - arr[i, j - 1] != difference)
					{
						break;
					}
					else
					{
						count++;
					}
				}
			}

			Console.WriteLine("Количество строк, элементы которых образуют арифметическую прогрессию: " + count);
			Console.ReadLine();
		}
		
	}
}