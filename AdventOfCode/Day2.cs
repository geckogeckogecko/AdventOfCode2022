using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
	public class Day2
	{
		public Day2() { }

		public int IndivScore(String round)
		{
			String opponent = round[..1];
			String me = round[2..];
			int score = 0;
			if (me.Equals("X"))
			{
				switch (opponent)
				{
					case "A":
						score += 3;
						break;
					case "B":
						score += 1;
						break;
					case "C":
						score += 2;
						break;
				}
			}
			else if (me.Equals("Y"))
			{
				score += 3;
				switch (opponent)
				{
					case "A":
						score += 1;
						break;
					case "B":
						score += 2;
						break;
					case "C":;
						score += 3;
						break;
				}
			}
			else if (me.Equals("Z"))
			{
				score += 6;
				switch (opponent)
				{
					case "A":
						score += 2;
						break;
					case "B":
						score += 3;
						break;
					case "C":
						score += 1;
						break;
				}
			}
			return score;
		}

		public int TotalScore(String[] RPSList)
		{
			int score = 0;
			int total = 0;
			for (int i = 0; i < RPSList.Length; i++)
			{
				String currentRound = RPSList[i];
				score = IndivScore(currentRound);
				total += score;
			}
			return total;
		}
	}
}
