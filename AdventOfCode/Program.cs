using AdventOfCode;

namespace AdventOfCOde
{
	public class Driver
	{
		static void Main()
		{
			Day2 day2 = new();
			String[] RPSList = day2.ReadRPS();
			int total = day2.TotalScore(RPSList);
			Console.WriteLine(total);
		}
	}
}