using System;
using System.Collections.Generic;

namespace Miscellaneous
{

	/// <summary>
	/// Leet Code problem.
	/// </summary>
	public class Solution 
	{
		public int MaxPoints(Point[] points) 
		{
			if (points.Length <= 0) {
				return -1;
			}

			Dictionary<int,int> xMap = new Dictionary<int,int>();
			Dictionary<int,int> yMap = new Dictionary<int,int>();

			foreach(Point p in points)
			{
				if(!(xMap.ContainsKey(p.x)))
					xMap.Add(p.x, 1);
				else
					++xMap[p.x];

				if(!(yMap.ContainsKey(p.y)))
					yMap.Add(p.y, 1);
				else
					++yMap[p.y];

			}
			return Convert.ToInt32(Math.Max(xMap.Values.Count, yMap.Values.Count));
		}
	}
}

