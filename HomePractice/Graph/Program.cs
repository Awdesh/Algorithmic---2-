using System;
using System.Collections.Generic;

namespace Graph
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
//			AdjacenyList<int> adj = new AdjacenyList<int> ();
//			adj.AddVertex (10);
//			adj.AddVertex (41);
//			adj.AddVertex (62);
//			adj.AddVertex (83);
//
//			adj.AddEdge (10, 41);
//			adj.AddEdge(10, 62);
//			adj.AddEdge(41, 62);
//			adj.AddEdge(62, 10);
//			adj.AddEdge(62, 83);
//
//			adj.RemoveEdge (10, 62);
//			int degree = adj.VertexDegree (10);

//			BreadthFirstSearch bfs = new BreadthFirstSearch ();
//			Person p = new Person ();
//
//			Person root = p.BuildFriendGraph1 ();
//			bfs.PrintEachLevel(root);

			Person p = new Person ();
			Person root = p.BuildFriendGraph1 ();

			DepthFirstSearch dfs = new DepthFirstSearch ();
			dfs.Traverse (root);

//			BreadthFirstSearch bfs = new BreadthFirstSearch ();
//			bfs.Traverse (root);
		}
	}
}
