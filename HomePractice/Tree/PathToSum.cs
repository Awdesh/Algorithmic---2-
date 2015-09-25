using System;

namespace Tree
{
	public class PathToSum
	{
		public PathToSum ()
		{
		}

		public bool pathToSum(TreeNode n, int sum) {
			if (null != n) {
				sum -= n.getData ();
				bool found = pathToSum(n.getLeft(), sum);

				if (!found) {
					found = pathToSum(n.getRight(), sum);
				}
				if (found) {
					Console.WriteLine(n.getData());
					return found;
				}
			}
			return 0 == sum ? true : false;
		}

		public bool pathSum(TreeNode root, int sum) {
			bool ret;
			if (root == null) {
				ret = sum == 0;
			}

			else {
				int remain = sum - root.getData ();
				ret = pathSum(root.getLeft(),remain) || pathSum(root.getRight(), remain);
			}
			return ret;
		}
	}
}

