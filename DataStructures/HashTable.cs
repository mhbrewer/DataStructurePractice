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

    public int remove(int key) {
      int ret = -1;
      if(!doesKeyExist(key)) {
        throw new KeyNotFoundException();
      }
      else {
        HashNode runner = array[key % array.Length];
        if(runner.key == key) {
          ret = runner.value;
          array[key % array.Length] = runner.next;
          size--;
        }
        return ret;
      }
    }
    
    public bool doesKeyExist(int key) {
      HashNode runner = array[key % array.Length];
      while(runner != null) {
        if(runner.key == key) {
          return true;
        }
        runner = runner.next;
      }
      return false;
    }

    public void add(int key, int value) {
      if(doesKeyExist(key)) {
        HashNode runner = array[key % array.Length];
        while(runner != null) {
          if(runner.key == key) {
            runner.value = value;
            return;
          }
          runner = runner.next;
        }
      } else {
        if(array[key % array.Length] == null) {
          array[key % array.Length] = new HashNode(key, value);
        } else {
          HashNode runner = array[key % array.Length];
          while(runner.next != null) {
            runner = runner.next;
          }
          runner.next = new HashNode(key, value);
        }
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