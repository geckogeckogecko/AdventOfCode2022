using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
	public class Day5
	{
		CrateStack[] crateStacks;

		public Day5() 
		{
			crateStacks = new CrateStack[9];
			crateStacks[0] = new CrateStack(new List<string> { "[S]", "[M]", "[R]", "[N]", "[W]", "[J]", "[V]", "[T]" });
			crateStacks[1] = new CrateStack(new List<string> { "[B]", "[W]", "[D]", "[J]", "[Q]", "[P]", "[C]", "[V]" });
			crateStacks[2] = new CrateStack(new List<string> { "[B]", "[J]", "[F]", "[H]", "[D]", "[R]", "[P]" });
			crateStacks[3] = new CrateStack(new List<string> { "[F]", "[R]", "[P]", "[B]", "[M]", "[N]", "[D]" });
			crateStacks[4] = new CrateStack(new List<string> { "[H]", "[V]", "[R]", "[P]", "[T]", "[B]" });
			crateStacks[5] = new CrateStack(new List<string> { "[C]", "[B]", "[P]", "[T]" });
			crateStacks[6] = new CrateStack(new List<string> { "[B]", "[J]", "[R]", "[P]", "[L]" });
			crateStacks[7] = new CrateStack(new List<string> { "[N]", "[C]", "[S]", "[L]", "[T]", "[Z]", "[B]", "[W]" });
			crateStacks[8] = new CrateStack(new List<string> { "[L]", "[S]", "[G]" });
		}

		public void ExecuteInstruction(int num, int x, int y)
		{
			string placeholder;
			// define source as crateStacks[x-1]
			CrateStack source = crateStacks[x - 1];
			// define destination as crateStacks[y-1]
			CrateStack destination = crateStacks[y - 1];
			// for loop done num number of times
			for (int i = 1; i <= num; i++)
			{
				// pop from source
				placeholder = source.Pop();
				// push to destination
				destination.Push(placeholder);
			}
   		}

		public void ExecuteInstruction9001(int num, int x, int y)
		{
			List<string> placeholder = new();
			CrateStack source = crateStacks[x - 1];
			CrateStack destination = crateStacks[y - 1];

			for (int i = 1; i <= num; i++)
			{
				placeholder.Add(source.Pop());
			}

			for (int u = (placeholder.Count - 1); u >= 0; u--)
			{
				destination.Push(placeholder[u]);
			}
		}

		public void ProcessInstruction(string instruction)
		{
			// split string by spaces
			string[] splitList = instruction.Split(' ');
			// num = string[1]
			int num = int.Parse(splitList[1]);
			// source = string[3]
			int source = int.Parse(splitList[3]);
			// destination = string[5]
			int destination = int.Parse(splitList[5]);
			// pass num, source, destination into ExecuteInstruction
			ExecuteInstruction9001(num, source, destination);
		}

		public string GoThroughList(string[] list)
		{
			// for item in list
			for (int i = 0; i < list.Length; i++)
			{
				// process instruction
				ProcessInstruction(list[i]);
			}
			// create string from top() of every stack in crateStacks
			string result = "";
			foreach (CrateStack x in crateStacks)
			{
				result += x.Pop();
			}
			// return that
			return result;
		}
	}
}
