using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
	public class Day1
	{
		public Day1() { }
		public String[] ReadElfFile()
		{
			String elfText = "";
			using (StreamReader sr = new StreamReader("C:\\Users\\Lorna\\Documents\\Coding\\AdventOfCode\\elfFile.txt"))
			{
				elfText = sr.ReadToEnd();
			}
			String[] elfList = elfText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			return elfList;
		}

		public int ProcessElfList(String[] elfList)
		{
			Boolean reachedNull = false;
			String currentString = "";
			int[] highestThree = { 0, 0, 0 };
			int currentSum = 0;
			int highestSum = 0;
			for (int i = 0; i < elfList.Length; i++)
			{
				currentString = elfList[i];
				if (currentString == "")
				{
					reachedNull = true;
				}
				else
				{
					reachedNull = false;
				}
				if (reachedNull == false)
				{
					currentSum += Int32.Parse(currentString);
				}
				if (reachedNull)
				{
					if (currentSum > highestThree[0])
					{
						highestThree[2] = highestThree[1];
						highestThree[1] = highestThree[0];
						highestThree[0] = currentSum;
					}
					else if (currentSum > highestThree[1])
					{
						highestThree[2] = highestThree[1];
						highestThree[1] = currentSum;
					}
					else if (currentSum > highestThree[2])
					{
						highestThree[2] = currentSum;
					}
					currentSum = 0;
				}
			}
			int totalSum = 0;
			for (int u = 0; u < 3; u++)
			{
				totalSum = totalSum + highestThree[u];
			}
			return totalSum;
		}
	}

}
