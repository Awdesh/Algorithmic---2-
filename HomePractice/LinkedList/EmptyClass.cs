//using System;
//
//namespace LinkedList
//{
//	public class EmptyClass
//	{
//		public EmptyClass ()
//		{
//		}
//
//		[code]
//		public static void insert(int key){
//			Node newNode = new Node(key);
//			if(root == null){
//				root = newNode;
//				return;
//			}
//			Node current = root;
//			while(true){               
//				if(current.key < key ){
//					if(current == null){
//						current = newNode;
//						return;
//					}
//					current = current.right;
//				}else {
//					if (current.left == null) {
//						current = newNode;
//						return;
//					} 
//					current = current.left;
//
//				}
//			}
//			[/code]
//	}
//}
//
