using System;

namespace Tree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TreeNode node = new TreeNode ();
			TreeNode n = node.CreateBinaryTree ();

			KthlargestTree largest = new KthlargestTree ();
			TreeNode t = largest.LargestValue (n, 5);
			Console.WriteLine ("kth largest element is-: {0}", t.getData ());
			TreeNode s = largest.SmallestValue (n, 3);
			Console.WriteLine ("kth smallest element is-: {0}", s.getData ());

//			TreeNode node = new TreeNode ();
//			TreeNode n = node.CreateBinaryTree ();
//			int[] paths = new int[20];
//			PrintPaths.printAllPathsToLeaf(n, paths, 0);
			//node.insert (45, n);

//			NumberOfLeaves n1 = new NumberOfLeaves();
//			n1.PrintPaths(new int[10], n, 0);

//			FindNodeValue nv = new FindNodeValue ();
//			bool b = nv.IsValueExists (n, 550);
//			Console.WriteLine ("Found Values anf its -: {0}", b);

			//PreOrderTraversal po = new PreOrderTraversal ();
			//po.NonRecursiveTraversal (n);
			//	po.RecursiveTraversal (n);

//			InOrderTraversal io = new InOrderTraversal ();
//			io.RecursiveTraversal (n);
////			io.NonRecursiveTraversal (n);

//			LCA lca = new LCA ();
//			TreeNode n1 = lca.FindLCAofBT(n, 10, 5);
//			Console.WriteLine ("Value of LCA is-: {0}", n1.getData());

//			NumberOfLeaves leaves = new NumberOfLeaves ();
//			int c = leaves.CountNumberOfLeaves (n);
//			Console.WriteLine ("number of leaves are-: {0}", c);

//			LargestValueInBT val = new LargestValueInBT ();
//			int value = val.FindLargestValueInBinrayTree (n);
//			Console.WriteLine ("Largest value in BSt is-: {0}", value);

//			NumberofNodes n1 = new NumberofNodes();
//			int nn =  n1.CalculateTotalNodes (n);
//			Console.WriteLine (nn);

//			SwapnInorder swap = new SwapnInorder ();
//			swap.SwapOperation (n,3);
		}
	}

		/// <summary>
		/// Creates a Sample Tree. 40 as root.
		/// </summary>
		public class TreeNode
		{
			int data;
			private TreeNode left;
			private TreeNode right;
			private int level;

			public TreeNode(int data)
			{
				this.data = data;
			}

			public TreeNode()
			{

			}

			public TreeNode getLeft()
			{
				return left;
			}

			public TreeNode getRight()
			{
				return right;
			}

			public int getData()
			{
				return data;
			}
			
			public void setLeft(TreeNode left)
			{
				this.left = left;
			}

			public void setRight(TreeNode right)
			{
				this.right = right;
			}

			public void setData(int data)
			{
				this.data = data;
			}

			public int getLevel()
			{
				return level;
			}
			public void setLevel(int value)
			{	
				level = value;
			}

			public TreeNode CreateBinaryTree()
			{
				TreeNode rootNode = new TreeNode(40);
				TreeNode node20 = new TreeNode(20);
				TreeNode node10 = new TreeNode(10);
				TreeNode node30 = new TreeNode(30);
				TreeNode node60 = new TreeNode(60);
				TreeNode node50 = new TreeNode(50);
				TreeNode node70 = new TreeNode(70);
				TreeNode node5 = new TreeNode(5);
				TreeNode node55 = new TreeNode(55);

				rootNode.left = node20;
				rootNode.right = node60;

				node20.left = node10;
				node20.right = node30;

				node60.left = node50;
				node60.right = node70;
				node10.left = node5;
				node50.right = node55;

				return rootNode;
			}

			public void insert(int key, TreeNode root)
			{
				TreeNode newNode = new TreeNode(key);
				if(root == null)
				{
					root = newNode;
					return;
				}
				TreeNode current = root;
				while(true)
				{               
					if(current.getData() < key )
					{
						if(current.getRight() == null)
						{
							current.setRight(newNode);
							return;
						}
						current = current.getRight();
					}
					else
					{
						if (current.getLeft() == null) 
						{
							current.setLeft(newNode);
							return;
						} 
						current = current.getLeft();
					}
			}
		}
	}
}
