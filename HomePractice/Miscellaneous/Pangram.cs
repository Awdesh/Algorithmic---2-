using System;

namespace Miscellaneous
{
	public class Pangram
	{
		public Pangram ()
		{
		}

    public bool IsPangram(string s)
    {
        bool[] booleanFlags = new bool[128];
        for(int i = 0; i<s.Length;i++)
        {
            int j = s[i];
			
            booleanFlags[j] = true;
				if (j < 91)
					booleanFlags [j + 32] = true;
				else
					booleanFlags [j - 32] = true;
        }
        for(int i = 65; i < 91; i++)
        {
            if(!booleanFlags[i])
            {
                return false;    
            }
        }
        return true;    
    	}
	}
}

