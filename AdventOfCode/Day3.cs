using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
	public class Day3
	{
		public Day3() { }

		public char FindCommonItem(string firstComp, string secondComp)
		{
			char result = 'a';
			// for each char in firstcomp
			foreach (char c in firstComp)
			{
				// if char in secondComp
				if (secondComp.Contains(c))
				{
					// assign that char to result var
					result = c;
				}
			}
			return result;
		}

		public int PriorityFinder(char c)
		{
			// if lowercase, return int of char - 96
			if ((int)c >= 97)
			{
				return (int)c - 96;
			}
			// else return int of char - 38
			return (int)c - 38;
		}

		public int ProcessRucksack(string rucksack)
		{
			// find length of rucksack
			int length = rucksack.Length;
			// firstComp = rucksack substring 0 - (length/2 - 1)
			string firstComp = rucksack[..(length / 2)];
			// secondComp = rucksack substring (length/2) - (length-1)
			string secondComp = rucksack[(length / 2)..];
			char common = FindCommonItem(firstComp, secondComp);
			int result = PriorityFinder(common);
			return result;
		}

		public int ProcessRucksackGroup(String[] rucksackGroup)
		{
			string firstSack = rucksackGroup[0];
			string secondSack = rucksackGroup[1];
			string thirdSack = rucksackGroup[2];
			char result = 'a';

			foreach(char c in firstSack)
			{
				if ((secondSack.Contains(c)) && thirdSack.Contains(c))
				{
					result = c;
				}
			}
			return PriorityFinder(result);
		}

		public int SumOfAllRucksacks(String[] rucksackList)
		{
			// define total = 0
			int total = 0;
			int currentSum;
			// for each string in ruckSackList
			for (int i = 0; i < rucksackList.Length; i++)
			{
				//	currentSum = ProcessRucksack(string)
				currentSum = ProcessRucksack(rucksackList[i]);
				//	add currentSum to total sum
				total += currentSum;
			}
			return total;
		}

		public int SumOfAllRucksackGroups(String[] rucksackList)
		{
			int total = 0;
			List<String> group = new();
			for (int i = 0; i < rucksackList.Length; i++)
			{
				if (group.Count < 3)
				{
					group.Add(rucksackList[i]);
				}
				else
				{
					total += ProcessRucksackGroup(group.ToArray());
					group = new();
					group.Add(rucksackList[i]);
				}
			}
			total += ProcessRucksackGroup(group.ToArray());
			return total;
		}
	}
}
