using System;
using System.Collections.Generic;

namespace Miscellaneous
{
	class NearByWords
	{
        //public static List<string> getNearByWords(string input)
        //{
        //    // e.g. if we have typed "gi" then we have to calculate all possible string that can be made from gi. Need a method which will do these permutations.
        //    // gi, go, gk, hi, ho, hk, fi, fo, fk. now we can paas each string to isWord to make sure if its valid or not.
        //    // it will tell us that go and hi are valid and reject others.

        //}

        ////Lame implementation of helpers.
        //private static Dictionary<char, char> getNearbyChars(char character) {
        //    Dictionary<char, char> characters = new Dictionary<char, char>();
        //    if (character == 'g') {
        //        if (!characters.ContainsKey ('g')) {
        //            characters.Add ('g', 'g');
        //        } else {
        //            characters['g'] = 'h';
        //            characters['g'] = 'f';
        //        }

        //    } else {
        //        if (!characters.ContainsKey ('i')) {
        //            characters.Add ('i', 'i');
        //        } else {
        //            characters['i'] = 'o';
        //            characters['i'] = 'k';
        //        }
        //    }
        //    return characters;
        //}

        //private static bool isword(String word) {
        //    return word.Equals("go") || word.Equals("hi");
        //}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
<<<<<<< HEAD

			int[] cards = new int[52];
			for (int i = 0; i< 52; i++) {
				cards [i] = i;
			}

			CardShuffle cs = new CardShuffle ();
			//int[] shuffledCards = cs.ShuffleCards (cards);

			//ReverseStringPreserveSpace r = new ReverseStringPreserveSpace ();
			//string op = r.ReverseString ("this is the real test");
			//Console.WriteLine (op);

=======
			int[] arr = new int[]{2,4,10,10,10,10,10,18};
			FindFirstAndLastOccurance f = new FindFirstAndLastOccurance ();
			int[] A = f.Find (arr, 10);
>>>>>>> BinarySearchProblems
//			Pangram p = new Pangram ();
//			bool val = p.IsPangram ("We promptly judged antique ivory buckles for the prize");
//			string s = val?"pangram":"not pangram";
//			PangramIndex pi = new PangramIndex ();
//			int l = pi.FindLength ("cde","abc");
//			Console.WriteLine ("{0}", l);

//			FindCommonLetter common = new FindCommonLetter ();
//			common.FindCommon ("hi","world");
//
//			AllValidPairOfParanthesis pair = new AllValidPairOfParanthesis ();
//			char[] chArr = new char[10];
//			pair.PrintParanthesis (0,3,0,0, chArr);

			//StringDuplicates dups = new StringDuplicates ();
//			dups.FindDuplicates("geeksforgeeks");

			CommonLetters cs1 = new CommonLetters();
			string s = cs1.FindString("geeksforgeeks" , "geeks");

		}
	}
}
