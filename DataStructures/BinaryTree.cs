using System;

namespace DataStructures {

  public class BinaryTree {
    TreeNode head;
    public BinaryTree() {
    }
    public BinaryTree(int headInput){
      head = new TreeNode(headInput);
    }
    public int size() {
      if(head == null) {
        return 0;
      }
      return 1;
    }

    public void add(int value) {
      head.rightNode = new TreeNode(value);
    }
  }

  public class TreeNode {
    public int value;
    public TreeNode leftNode;
    public TreeNode rightNode;

    public TreeNode(int value) {
      this.value = value;
    }
  }

}