using System;

class MainClass {

  class circularQ {
    private int maxSize; // maximum number of items
    private int size; // number of items in queue

    public circularQ (int s) {
      // Implment constructor here
    }
    public bool isFull() {
      // Implment isFull() here
      return true;
    }

    public bool isEmpty() {
      // Implment isEmpty() here
      return true;
    }

    public int enQueue (string s) {
      // Return -1 if queue is already full
      return -1; 
    }

    public string deQueue () {
      // Dequeue the next string. Return null if Q isEmpty()
      return null;
    }
  }
  public static void Main (string[] args) {

    circularQ myQ = new circularQ (5);

    if (!myQ.isFull()) {
      myQ.enQueue ("Hello");
      myQ.enQueue ("World");
    }
      
    string p = myQ.deQueue();
    if (p != null)
      Console.WriteLine ("Dequeued: {0}", p);

    //
    // Do more testing here
    //
  }
}
