using AdventOfCode;
using System.Text;

namespace AdventOfCOde
{
	public class Driver
	{
		static void Main()
		{
			Day5 day5 = new Day5();
			string[] list = SplitFileIntoLines("C:\\Users\\Lorna\\Documents\\Coding\\AdventOfCode\\crateFile.txt");
			Console.WriteLine(day5.GoThroughList(list));
		}

		public static string[] SplitFileIntoLines(string file)
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