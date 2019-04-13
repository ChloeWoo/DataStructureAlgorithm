// C# program for different  
// tree traversals 
using System;  
  
/* Class containing left and  
right child of current 
node and key value*/
class Node 
{ 
    public int key; 
    public Node left, right; 
  
    public Node(int item) 
    { 
        key = item; 
        left = right = null; 
    } 
} 
  
class BinaryTree 
{ 
// Root of Binary Tree 
  Node root; 

  BinaryTree() 
  { 
      root = null; 
  } 

  /* Given a binary tree, print  
     its nodes according to the 
     "bottom-up" postorder traversal. */
  void printPostorder(Node node) 
  { 
      if (node == null) 
          return; 

      // first recur on left subtree 
      printPostorder(node.left); 

      // then recur on right subtree 
      printPostorder(node.right); 

      // now deal with the node 
      Console.Write(node.key + " "); 
  } 

  /* Given a binary tree, print  
     its nodes in inorder*/
  void printInorder(Node node) 
  { 
      if (node == null) 
          return; 

      /* first recur on left child */
      printInorder(node.left); 

      /* then print the data of node */
      Console.Write(node.key + " "); 

      /* now recur on right child */
      printInorder(node.right); 
  } 

  /* Given a binary tree, print 
     its nodes in preorder*/
  void printPreorder(Node node) 
  { 
      if (node == null) 
          return; 

      /* first print data of node */
      Console.Write(node.key + " "); 

      /* then recur on left sutree */
      printPreorder(node.left); 

      /* now recur on right subtree */
      printPreorder(node.right); 
  } 

  // Wrappers over above recursive functions 
  void printPostorder() {printPostorder(root);} 
  void printInorder()  {printInorder(root);} 
  void printPreorder() {printPreorder(root);} 

  // Driver Code 
  static public void Main(String []args) 
  { 
      BinaryTree tree = new BinaryTree(); 
      tree.root = new Node(1); 
      tree.root.left = new Node(2); 
      tree.root.right = new Node(3); 
      tree.root.left.left = new Node(4); 
      tree.root.left.right = new Node(5); 

      Console.WriteLine("Preorder traversal " +  
                         "of binary tree is "); 
      tree.printPreorder(); 

      Console.WriteLine("\nInorder traversal " +   
                          "of binary tree is "); 
      tree.printInorder(); 

      Console.WriteLine("\nPostorder traversal " +  
                            "of binary tree is "); 
      tree.printPostorder(); 
  } 
} 

// Time Complexity: O(n)
// Let us see different corner cases.
// Complexity function T(n) — for all problem where tree traversal is involved — can be defined as:

// T(n) = T(k) + T(n – k – 1) + c

// Where k is the number of nodes on one side of root and n-k-1 on the other side.



 

// Let’s do an analysis of boundary conditions

// Case 1: Skewed tree (One of the subtrees is empty and other subtree is non-empty )

// k is 0 in this case.
// T(n) = T(0) + T(n-1) + c
// T(n) = 2T(0) + T(n-2) + 2c
// T(n) = 3T(0) + T(n-3) + 3c
// T(n) = 4T(0) + T(n-4) + 4c

// …………………………………………
// ………………………………………….
// T(n) = (n-1)T(0) + T(1) + (n-1)c
// T(n) = nT(0) + (n)c

// Value of T(0) will be some constant say d. (traversing a empty tree will take some constants time)

// T(n) = n(c+d)
// T(n) = Θ(n) (Theta of n)

// Case 2: Both left and right subtrees have equal number of nodes.

// T(n) = 2T(|_n/2_|) + c

// This recursive function is in the standard form (T(n) = aT(n/b) + (-)(n) ) for master method http://en.wikipedia.org/wiki/Master_theorem. If we solve it by master method we get (-)(n)

// Auxiliary Space : If we don’t consider size of stack for function calls then O(1) otherwise O(n).
