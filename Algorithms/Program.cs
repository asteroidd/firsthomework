using System;
using ClassLibrary;

namespace Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[20];
			Key methods = new Key();
			methods.List();
			int caseSwitch = int.Parse(Console.ReadLine());
			
			switch (caseSwitch)
			{
				case 1: //сортировка пузырьком
					Algorithm.Input(array);
					Algorithm.BubleSort(array);
					Algorithm.Output(array);
					break;

				case 2: //быстрая сортировка
					Algorithm.Input(array);
					Algorithm.QuickSort(array,0,array.Length-1);
					Algorithm.Output(array);
					break;

				case 3: //сортировка выбором
					Algorithm.Input(array);
					Algorithm.SelectionSort(array);
					Algorithm.Output(array);
					break;

				case 4: //сортировка вставками
					Algorithm.Input(array);
					Algorithm.InsertionSort(array);
					Algorithm.Output(array);
					break;

				case 5: //линейный поиск
					Algorithm.Input(array);
					Console.WriteLine("введите число:");
					int k = int.Parse(Console.ReadLine());
					Algorithm.LinearSearch(array, k);
					break;

				case 6: //бинарный поиск
					Algorithm.Input2(array);
					Algorithm.Output(array);
					Console.WriteLine();
					Console.WriteLine("введите число:");
					k = int.Parse(Console.ReadLine());
					Algorithm.binSearch(array, k);
					break;

				case 7: // поиск Кнут
					string s1 = Console.ReadLine(); //что искать
					string s2 = Console.ReadLine(); // текст
					Algorithm.FindSubstring(s1, s2);
					break;
			}
		}
	}
}
