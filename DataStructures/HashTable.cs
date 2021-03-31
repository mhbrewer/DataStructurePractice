using System;

namespace DataStructures {

  public class HashTable {
    public int size { get; set; }
    public int[] array;

    public HashTable() {
      array = new int[19];
      size = 0;
    }

    public HashTable(int key, int value) {
      array = new int[19];
      array[key % array.Length] = value;
      size = 1;
    }

    public int getValue(int key) {
      return array[key % array.Length];
    }
  }
}