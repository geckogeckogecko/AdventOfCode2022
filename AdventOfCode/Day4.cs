using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
	public class Day4
	{
		public Day4() { }
		public bool CompareRanges(List<string> rangeOne, List<string> rangeTwo) { 
			// get the first numbers of both lists
			int rangeOneFirst = int.Parse(rangeOne[0]);
			int rangeTwoFirst = int.Parse(rangeTwo[0]);
			// get the second numbers of both lists
			int rangeOneLast = int.Parse(rangeOne[1]);
			int rangeTwoLast = int.Parse(rangeTwo[1]);
			// if rangeOneFirst less than or equal to rangeTwoFirst
			if (rangeOneFirst <= rangeTwoFirst)
			{
				// AND rangeOneLast more than or equal to rangeTwoLast
				if (rangeOneLast >= rangeTwoLast)
				{
					// then return true
					return true;
				}
			}
			return false;
		}

		public bool CompareOverlaps(List<string> rangeOne, List<string> rangeTwo)
		{
			// get the first numbers of both lists
			int rangeOneFirst = int.Parse(rangeOne[0]);
			int rangeTwoFirst = int.Parse(rangeTwo[0]);
			// get the second numbers of both lists
			int rangeOneLast = int.Parse(rangeOne[1]);
			int rangeTwoLast = int.Parse(rangeTwo[1]);
			if (rangeTwoFirst <= rangeOneLast && rangeTwoFirst >= rangeOneFirst)
			{
				return true;
			}
			return false;
		}
		public bool ProcessRange(string ranges) {
			// split string by ','
			string[] seperateRanges = ranges.Split(',');
			// then split those strings by '-'
			string[] rangeOne = seperateRanges[0].Split('-');
			string[] rangeTwo = seperateRanges[1].Split('-');
			// turn those arrays into lists and pass them into CompareRanges
			bool twoInOne = CompareOverlaps(rangeOne.ToList(), rangeTwo.ToList());
			// then do that again, switching the order the lists are passed in
			bool oneInTwo = CompareOverlaps(rangeTwo.ToList(), rangeOne.ToList());
			// if either one of those calls returned true, return true
			if (twoInOne || oneInTwo)
			{
				return true;
			}
			// else, return false
			return false;

		}
		public int GoThroughList(String[] list) {
			int total = 0;
			// for each item in the list
			for (int i = 0; i < list.Length; i++)
			{
				// pass item into ProcessRange
				if (ProcessRange(list[i]))
				{
					// if returns true, add to total
					total++;
				}
			}
			return total;
		}
	}
}
