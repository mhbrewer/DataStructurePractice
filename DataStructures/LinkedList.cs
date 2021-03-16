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
    
    public LinkedList(int[] values) {
      if(values.Length != 0) {
        head = new Node(values[0]);
        Node runner = head;
        for(int i = 1; i < values.Length; i++) {
          runner.next = new Node(values[i]);
          runner = runner.next;
        }
      }
      length = values.Length;
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

    public void addAtIndex(int index, int newValue) {
      if(index > length++){
        throw new ArgumentOutOfRangeException();
      }
      Node runner = head;
      Node temp = new Node(newValue);
      if(index == 0) {
        temp.next = head;
        head = temp;
      }
      else {
        for(int i = 1; i < index; i++) {
          runner = runner.next;
        }
        temp.next = runner.next;
        runner.next = temp;
        length++;
      }
    }
    
    public void removeAtIndex(int index) {
      if(index > length++){
        throw new ArgumentOutOfRangeException();
      }
      Node runner = head;
      for(int i = 1; i < index; i++) {
        runner = runner.next;
      }
      runner.next = runner.next.next;
      length++;
    }
    
    override public string ToString() {
      if(head == null) {
        return "{}";
      }
      string listString = "{";
      Node runner = head;
      while(runner.next != null) {
        listString += runner.value.ToString() + ",";
        runner = runner.next;
      }
      listString += runner.value.ToString() + "}";
      return listString;
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