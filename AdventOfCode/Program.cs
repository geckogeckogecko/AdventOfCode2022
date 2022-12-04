using AdventOfCode;

namespace AdventOfCOde
{
	public class Driver
	{
		static void Main()
		{
			Day4 day4 = new Day4();
			String[] cleaningList = SplitFileIntoLines("C:\\Users\\Lorna\\Documents\\Coding\\AdventOfCode\\cleaningList.txt");
			Console.WriteLine(day4.GoThroughList(cleaningList));
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