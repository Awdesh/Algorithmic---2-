using System;

namespace MSSelection
{
	public class LPS
	{
		public LPS ()
		{
		}

//		public class LongestPalindromicSubsequence {
//
//			public int calculate(char []str){
//				int T[][] = new int[str.length+1][str.length+1];
//				for(int i=0; i < str.length; i++){
//					T[1][i] = 1;
//				}
//				for(int c = 2; c <= str.length; c++){
//					for(int i = 1; i <= str.length-c+1; i++){
//						if(str[i-1] == str[i-1 + c-1] && c == 2){
//							T[c][i] = 2;
//						}else if(str[i-1] == str[i+c-2]){
//							T[c][i] = T[c-2][i+1] + 2;
//						}else{
//							T[c][i] = Math.max(T[c-1][i+1], T[c-1][i]);
//						}
//					}
//				}
//				return T[str.length][1];
//			}
	}
}

