using System;
using System.Collections.Generic;

namespace Graph
{
	public class AdjacenyList<T>
	{
		//private List<List<T>> vertexList = new List<List<T>>();
		private Dictionary<T, List<T>> vertexDict = new Dictionary<T, List<T>>();

		public AdjacenyList ()
		{
		}

		public Dictionary<T, List<T>> getVertexDict()
		{
			return vertexDict;
		}


		public AdjacenyList(T key)
		{
			AddVertex (key);
		}

		public List<T> AddVertex(T key)
		{
			List<T> vertex = new List<T> ();
			vertex.Add (key);
			//vertexList.Add (vertex);
			vertexDict.Add (key, vertex);

			return vertex;
		}

		/// <summary>
		/// Adds the edge.
		/// </summary>
		/// <param name="startKey">Start key.</param>
		/// <param name="endKey">End key.</param>
		public void AddEdge(T startKey, T endKey)
		{      
			List<T> startVertex = vertexDict.ContainsKey(startKey) ? vertexDict[startKey] : null;
			List<T> endVertex = vertexDict.ContainsKey(endKey) ? vertexDict[endKey] : null;

			if (startVertex == null)
				throw new ArgumentException("Cannot create edge from a non-existent start vertex.");

			if (endVertex == null)
				endVertex = AddVertex(endKey);

			if(!startVertex.Contains(endKey))
				startVertex.Add(endKey);
			if(!endVertex.Contains(startKey))
				endVertex.Add(startKey);
		}

		public void RemoveVertex(T key)
		{
			List<T> vertex = vertexDict[key];

			//First remove the edges / adjacency entries
			int vertexNumAdjacent = vertex.Count;
			for (int i = 0; i < vertexNumAdjacent; i++)
			{  
				T neighbourVertexKey = vertex[i];
				RemoveEdge(key, neighbourVertexKey);
			}

			//Lastly remove the vertex / adj. list
			//vertexList.Remove(vertex);
			vertexDict.Remove(key);
		}

		public void RemoveEdge(T startKey, T endKey)
		{
			((List<T>)vertexDict[startKey]).Remove(endKey);
			((List<T>)vertexDict[endKey]).Remove(startKey);
		}

		public bool Contains(T key)
		{
			return vertexDict.ContainsKey(key);
		}

		public int VertexDegree(T key)
		{
			return vertexDict[key].Count;
		}
	}
}

