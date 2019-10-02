using System;
using System.Collections;
using System.Diagnostics;

namespace SplitAndSort
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string stringPattern = "@gmail.com";
			ArrayList finalList = new ArrayList(30);
			Console.WriteLine("Enter the number of inputs");
			int numberOfData = Convert.ToInt32(Console.ReadLine());
			string[] stringarr = new string[30];
			for (int i = 0; i < numberOfData; i++)
			{
				stringarr[i] = Console.ReadLine();
			}

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			for (int l = 0; l < numberOfData; l++)
			{
				ExecutionClass.WithoutRegex(stringarr[l], stringPattern, finalList);
			}
			finalList.Sort();
			stopWatch.Stop();
			Console.WriteLine("\n\n\nOUTPUT");
			foreach (var output in finalList)
			{
				Console.WriteLine(output);
			}
			Console.WriteLine("Time elapsed (ms) for Without Regex: {0}", stopWatch.Elapsed.TotalMilliseconds);
			Console.ReadLine();
		}

		
	}
}