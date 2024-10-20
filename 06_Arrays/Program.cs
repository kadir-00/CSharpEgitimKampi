using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// *** Temel Dizi Ornekleri 
			//string[] colors = new string[4];
			//colors[0] = "beyaz";
			//colors[1] = "kirmizi";
			//colors[2] = "lacivert";
			//colors[3] = "sari";
			//Console.WriteLine(colors[2]);

			//string[] cities = new string[5];
			//cities[0] = "Stockholm";
			//cities[1] = "Goteborg";
			//cities[2] = "Chicago";
			//cities[3] = "Madrid";
			//cities[4] = "Buenos Aires";
			//Console.WriteLine(cities[1]);

			//*******

			// Dizideki Tum Elemanlari Listeleme
			//string[] colors = { "Sari", "Lacivert", "Beyaz", "Siyah", "Bej", "Turuncu", "Kirmizi" };
			//for (int i = 0; i < colors.Length; i++)
			//{
			//	Console.WriteLine(colors[i]);
			//}


			int[] numbers = { 23, 45, 7, 48, 12, 35, 96, 85, 42, 13, 73 };
			for (int i = 0; i < numbers.Length; i++)
			{ 
			if (numbers[i] % 3==0) 
			{
					Console.WriteLine(numbers[i]);			
			}
			Console.Read();
		}
	}
}
}

