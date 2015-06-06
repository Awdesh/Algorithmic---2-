using System;
using System.Collections.Generic;

namespace MSSelection
{
	public class Hierarchy
	{
		public Hierarchy ()
		{
		}

		public Dictionary<string, int> CreateHierarchy(Dictionary<string,string> map)
		{
			Dictionary<string,int> result = new Dictionary<string, int> ();

			foreach (KeyValuePair<string,string> pair in map) {
				result[pair.Key] = 0;
			}

			foreach (KeyValuePair<string,string> pair in map) {
				string emp = pair.Key;
				string mgr = pair.Value;

				if (emp.Equals (mgr)) {
					continue;
				}

				int count1 = 0;
				if (result.ContainsKey (emp)) {
					count1 = result [emp];
				}

				// mgr is value which will be the key of result, so basically if key already exists we just increase the count.
				int count2 = 0;
				if (result.ContainsKey (mgr)) {
					count2++;
				}

				int count = count1 + count2;
				if(!result.ContainsKey(mgr))
				{
					result.Add (mgr, count);
				}
				else{
					result[mgr] += count;
				}
			}

			return result;
		}
	}
}

