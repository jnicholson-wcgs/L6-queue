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

    public void enQueue (string s) {
      // Report error if enqueue to full Q
      if (isFull())
        Console.WriteLine ("enQueue(): queue full");
    }

    public string deQueue () {
      // Dequeue the next string. Return null if Q isEmpty()
      if (isEmpty())
        Console.WriteLine ("deQueue(): queue empty");
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
