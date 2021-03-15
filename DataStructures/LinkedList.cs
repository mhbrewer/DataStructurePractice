using System;

namespace DataStructures {

  public class LinkedList {
    private Node head;
    public int length;

    public LinkedList() {
      length = 0;
    }

    public LinkedList(int headValue) {
      head = new Node(headValue);
      length = 1;
    }

    public int valueAtIndex(int index) {
      if(index > length-1) {
        throw new ArgumentOutOfRangeException();
      }
      Node runner = head;
      for(int i = 0; i < index; i++) {
        runner = runner.next;
      }
      return runner.value;
    }

    public void add(int newValue) {
      if(head == null) {
        head = new Node(newValue);
      }
      else {
        Node runner = head;
        while(runner.next != null) {
          runner = runner.next;
        }
        runner.next = new Node(newValue);
      }
      length++;
    }
  }

  public class Node {
    public int value;
    public Node next;

    public Node(int value) {
      this.value = value;
    }
  }

}