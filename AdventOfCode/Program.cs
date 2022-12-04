using AdventOfCode;

namespace AdventOfCOde
{
	public class Driver
	{
		static void Main()
		{
			Day3 day3 = new Day3();
			String[] ruckSackList = SplitFileIntoLines("C:\\Users\\lorna\\OneDrive\\Documents\\Documents\\Coding\\AdventOfCode\\rucksacks.txt");
			Console.WriteLine(day3.SumOfAllRucksackGroups(ruckSackList));
		}

		public static String[] SplitFileIntoLines(string file)
		{
			String fileText = "";
			using (StreamReader sr = new(file))
			{
				fileText = sr.ReadToEnd();
			}
			return fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
		}
	}
}