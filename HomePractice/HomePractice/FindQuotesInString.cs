using System;
using System.Text;

namespace HomePractice
{
	public class FindQuotesInString
	{
		public FindQuotesInString (string s)
		{
			s = "'315'382'9915'";
			// '    -> find a single quotation mark
			//			(    -> start a matching group
			//			 [^'] -> match any character that is not a single quotation mark
			// *    -> ...zero or more times
			// )    -> end the matching group"
			System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(s, @"'([^""]*)");
			if (match.Success)
			{
				string yourValue = match.Groups[1].Value;
				Console.WriteLine(yourValue);
			}
		}
	}
}

