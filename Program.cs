using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleDeckProblem
{
	class Program
	{
		static void Main(string[] args)
		{
			Shuffle(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,16,17,18,19,20,21 });
		}

		static void Shuffle(int[] arr)
		{
			
			for (int i = arr.Length - 1; i > 0; i--)
			{
				Random random = new Random();
				int randomNumber = random.Next(0,i);
				Swap(arr, i, randomNumber); 
			}
		}

		static void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

	}
}
