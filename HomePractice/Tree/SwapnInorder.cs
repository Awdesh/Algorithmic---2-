using System;
using System.Collections.Generic;

namespace Tree
{
	public class SwapnInorder
	{
		public SwapnInorder ()
		{
		}

		public void SwapOperation(TreeNode root, int K)
		{
			if(root ==null)
			{
				return;    
			}

			Queue<TreeNode> q = new Queue<TreeNode>();
			q.Enqueue(root);
			root.setLevel (1);
			TreeNode temp;

			while(q.Count > 0)
			{
				temp = q.Dequeue();
				if(temp == null)
				{
					return;    
				}
				int index = temp.getLevel ();
				// Swap operation.
				if(index == K)
				{
					TreeNode curr;
					curr = temp.getLeft();
					temp.setLeft( temp.getRight());
					temp.setRight( curr);
					InorderTraversal (root);
				}
				if(temp.getLeft() != null)
				{
					temp.getLeft().setLevel( index + 1);
					q.Enqueue(temp.getLeft());   
				}
				if(temp.getLeft() != null)
				{
					temp.getRight().setLevel( index + 1);
					q.Enqueue(temp.getRight());   
				}
			}
		}

		private void InorderTraversal(TreeNode node)
		{
			if(node == null)
			{
				return;
			}
			InorderTraversal(node.getLeft());
			Console.WriteLine(node.getData());
			InorderTraversal(node.getRight());
		}
	}
}

