using System;

namespace Tree
{
	public class PrintPaths
	{
		public PrintPaths ()
		{
		}

		// Prints all paths to leaf  
		public static void printAllPathsToLeaf(TreeNode node, int[] path, int index) {  
			if ( node == null )  
				return;  

			// storing data in array  
			path[index] = node.getData();  
			index++;  

			if(node.getLeft() == null && node.getRight() == null) {  
				// leaf node is reached  
				printArray(path,index);  
				return;  
			}  

			printAllPathsToLeaf(node.getLeft(), path, index);  
			printAllPathsToLeaf(node.getRight(), path, index);  
		}

		/* Utility that prints out an array on a line */
		public static void printArray(int[] ints, int index)
		{
			int i;
			for (i=0; i<index; i++) {
				Console.WriteLine("{0}", ints[i]);
			}
		}
	}
}

