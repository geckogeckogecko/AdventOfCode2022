using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
	public class Day6
	{
		public int currentMarker { get; set; }
		public char[] packet { get; }
		public string data { get; }

		public Day6(string data)
		{
			List<char> tempList = new();
			currentMarker = 14;
			for (int i = 0; i < 14; i++)
			{
				tempList.Add(data[i]);
			}
			packet = tempList.ToArray();
			this.data = data;
		}

		public bool CheckChar(char ch)
		{
			for (int i = 1; i < 14; i++)
			{
				packet[i - 1] = packet[i];
			}
			packet[13] = ch;
			if (packet.Length != packet.Distinct().Count())
			{
				return false;
			}
			return true;
		}

		public int ProcessData()
		{
			bool reachedEnd = false;
			if (packet.Length == packet.Distinct().Count())
			{
				reachedEnd = true;
			}
			while (!reachedEnd)
			{
				currentMarker++;
				reachedEnd = CheckChar(data[currentMarker - 1]);
			}
			return currentMarker;
		}
	}
}
