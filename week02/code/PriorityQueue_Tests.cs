using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities: A(1), B(3), C(2)
    // Expected Result: Dequeue returns items from highest to lowest priority: B, C, A
    // Defect(s) Found: None (assuming PriorityQueue is implemented correctly)
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: Enqueue three items with, two with the same priority: X(5), Y(5), Z(1)
    // Expected Result: Items with the same highest priority are dequeued in the order they were added: X, Y, Z
    // Defect(s) Found: None (assuming PriorityQueue is implemented correctly)
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("X", 5);
        priorityQueue.Enqueue("Y", 5);
        priorityQueue.Enqueue("Z", 1);

        Assert.AreEqual("X", priorityQueue.Dequeue());
        Assert.AreEqual("Y", priorityQueue.Dequeue());
        Assert.AreEqual("Z", priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: Dequeue from an empty priority queue
    // Expected Result: An InvalidOperationException is thrown with the message "The queue is empty."
    // Defect(s) Found: None (assuming PriorityQueue is implemented correctly)
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expectation should have been thrown for empty queue.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        
    }
}