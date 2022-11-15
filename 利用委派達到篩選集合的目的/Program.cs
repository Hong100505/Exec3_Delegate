using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 利用委派達到篩選集合的目的
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int> { 88, 5, 4,17, 65 };
			Func<int, bool> isEven = n => n % 2 == 0;

			List<int> EvenItems = GetEvenItems(items, isEven);
			foreach (var item in EvenItems)
			{
				Console.WriteLine(item);
			}

		}

		static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
		{
			var result = new List<int>();

			foreach (int item in source)
			{

				Console.WriteLine(func(item));
				
				if (func(item) == true)
				{
					result.Add(item);
				}
			}

			return result;
		}
	}
}
