using AdventOfCode;

namespace AdventOfCOde
{
	public class Driver
	{
		static void Main()
		{
			Day1 dayOne = new Day1();
			String[] elfList = dayOne.ReadElfFile();
			int highestSum = dayOne.ProcessElfList(elfList);
			Console.WriteLine(highestSum);
		}
	}
}