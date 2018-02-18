using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving._30DaysofCode
{

	class _2DArray
	{
		class Coords
		{
			public int X { get; set; }
			public int Y { get; set; }
		}

		static void Main(String[] args)
		{
			int[][] arr = new int[6][];
			for (int arr_i = 0; arr_i < 6; arr_i++)
			{
				string[] arr_temp = Console.ReadLine().Split(' ');
				arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
			}

			List<Coords> hourglassBounds = new List<Coords>();
			hourglassBounds.Add(new Coords() { X = 0, Y = 0 });
			hourglassBounds.Add(new Coords() { X = 0, Y = 1 });
			hourglassBounds.Add(new Coords() { X = 0, Y = 2 });
			hourglassBounds.Add(new Coords() { X = 1, Y = 1 });
			hourglassBounds.Add(new Coords() { X = 2, Y = 0 });
			hourglassBounds.Add(new Coords() { X = 2, Y = 1 });
			hourglassBounds.Add(new Coords() { X = 2, Y = 2 });
			long sum = 0;
			long largest_sum = 0;

			for (int i = 0; i <= 3; i++)
			{
				for (int j = 0; j <= 3; j++)
				{
					sum = 0;
					foreach (Coords coord in hourglassBounds)
					{
						sum += arr[coord.X + i][coord.Y + j];
					}
					if( i ==0 && j == 0)
					{
						largest_sum = sum;
					}
					else if(largest_sum < sum)
					{
						largest_sum = sum;
					}
				}
			}

			Console.WriteLine(largest_sum);
			Console.Read();
		}
	}
}
