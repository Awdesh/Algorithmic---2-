using System;
using System.Collections.Generic;

namespace Miscellaneous
{
	public class AnagramLength
	{
		public AnagramLength ()
		{
		}

		public int FindLength(string s1, string s2)
		{
			List<int> list = new List<int>();
			int count = 0;
			for(int i = 0; i<s1.Length; i++)
			{
				list.Add(s1[i]);
			}

			for(int j = 0;j<s2.Length;j++)
			{
				if (list.Contains (s2 [j])) {
					list.Remove (s2 [j]);
				} else {
					count++;
				}
			}

			int anagramLength = list.Count + count;
			return anagramLength;
		}

		//java
		// Another Approach.
//		public static void op(String s1,String s2){
//			int n1=s1.length();
//			int n2=s2.length();
//			int[] array1=new int[26];
//			int[] array2=new int[26];
//			for(int i=0;i<n1;i++){
//				char c=s1.charAt(i);
//				array1[c-97]++;
//			}
//			for(int i=0;i<n2;i++){
//				char c=s2.charAt(i);
//				array2[c-97]++;
//			}
//			int sum=0;
//			for(int i=0;i<26;i++){
//				sum+=Math.abs(array1[i]-array2[i]);
//			}
//			System.out.println(sum);
//		}
	}
}

