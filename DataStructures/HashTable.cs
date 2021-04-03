using System;
using System.Collections.Generic;

namespace DataStructures {

  public class HashTable {
    private int size { get; set; }
    internal HashNode[] array;

    public HashTable() {
      array = new HashNode[19];
      size = 0;
    }

    public HashTable(int key, int value) {
      array = new HashNode[19];
      array[key % array.Length] = new HashNode(key, value);
      size = 1;
    }

    public void add(int key, int value) {
      if(array[key % array.Length] == null) {
        array[key % array.Length] = new HashNode(key, value);
        size++;
      } else {
        HashNode runner = array[key % array.Length];
        if(runner.key == key) {
            runner.value = value;
            return;
          }
        while(runner.next != null) {
          if(runner.key == key) {
            runner.value = value;
            return;
          }
          runner = runner.next;
        }
        runner.next = new HashNode(key, value);
        size++;
      }
      if(size >= array.Length/2) {
        reform();
      }
    }

    public int getSize() {
      return size;
    }

    public int getValue(int key) {
      HashNode runner = array[key % array.Length];
      while(runner != null) {
        if(runner.key == key) {
          return runner.value;
        }
        runner = runner.next;
      }
      throw new KeyNotFoundException();
    }

    private void reform() {
      HashNode[] oldArray = array;
      array = new HashNode[array.Length * 3];
      HashNode runner;
      foreach(HashNode node in oldArray) {
        runner = node;
        while(runner != null) {
          add(runner.key, runner.value);
          runner = runner.next;
        }
      }
    }



    internal class HashNode {
      internal int key;
      internal int value;
      internal HashNode next;

      internal HashNode(int key, int value) {
        this.key = key;
        this.value = value;
      }
    }
  }
}