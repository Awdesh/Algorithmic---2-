using System;

namespace MSSelection
{
	public class MatrixSearch
	{
		public MatrixSearch ()
		{
		}

		// http://stackoverflow.com/questions/2457792/given-a-2d-array-sorted-in-increasing-order-from-left-to-right-and-top-to-bottom/18158695#18158695

		// O(N) approach. Saddleback
		public bool FindElem(int[,] matrix, int elem)
		{
			int row = 0;
			int col = matrix.GetLength(0) - 1;

			while (row <= matrix.Length - 1 && col >= 0) {
				if(matrix[row,col] == elem)
				   return true;
				else if(matrix[row,col] < elem)
				   row++;
				else
					col--;
			}
			return false;
		}

		// binary Search Approach.

		public bool FindElemBinarySearch(int[,] matrix, int elem, int rows, int cols)
		{
			return RecursiveBinarySearch (matrix, elem, 0, 0, rows, cols);
		}

		public bool RecursiveBinarySearch(int[,] arr, int value, int minX, int minY, int maxX, int maxY)
		{
			if (minX == maxX && minY == maxY && arr [minX, minY] != value)
				return false;
					if (arr[minX,minY] > value) return false;  // Early exits if the value can't be in 
			if (arr[maxX,maxY] < value) return false;  // this subrange at all.

			int nextX = (minX + maxX) / 2;
			int nextY = (minY + maxY) / 2;

			if (arr[nextX,nextY] == value)
			{
					return true;
			}
			else if (arr[nextX,nextY] < value)
			{
				if (RecursiveBinarySearch(arr, value, minX, maxX, nextY + 1, maxY))
					return true;
				return RecursiveBinarySearch (arr, value, nextX + 1, maxX, minY, nextY);
			}
			else
			{
				if (RecursiveBinarySearch(arr, value, minX, nextX - 1, minY, maxY))
					return true;
				return RecursiveBinarySearch(arr, value, nextX, maxX, minY, nextY);
			}
		}
	
	}
}

