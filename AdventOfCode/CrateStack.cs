using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
	public class CrateStack
	{
		private List<string> stack;
		private int size;
		public CrateStack(List<string>? list)
		{
			if (list == null)
			{
				stack = new List<string>();
				size = 0;
			}
			else
			{
				stack = list;
				size = list.Count;
			}
		}

		public void Push(string s) 
		{
			size++;
			stack.Add(s);
		}

		public string Pop() 
		{ 
			size--;
			string result = stack[size];
			stack.RemoveAt(size);
			return result;
		}
	}
}
