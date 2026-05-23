using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue of people where their priority will be defined by their age. 
    // Ex: Carol (age 24), Joseph (age 16), Betty (age 64)
    // Expected Result: Betty (the eldest person)
    // Defect(s) Found: The Dequeue function loop was not iterating to the last value in the list 
    // because the condition was missing an = symbol.
    public void TestPriorityQueue_ElderlyFirst()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Carol",24); // Carol (age 24)
        priorityQueue.Enqueue("Joseph",16); // Joseph (age 16)
        priorityQueue.Enqueue("Betty",64); // Betty (age 64)

        string expectedResult = "Betty";

        string result = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult, result);

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Create a list of students where their priority is defined by their percentage in the course. 
    // Three students will have the same percentage.
    // Ex: John (83), Karl (90), Carmen (92), Chris (80), Bill (92), Liz (85), Alfred (92), June (75)
    // Expected Result: Carmen (the first high percentage)
    // Defect(s) Found: The "if" condition inside the Dequeue function's loop had an = symbol 
    // that caused it to return the last highest value.
    public void TestPriorityQueue_FirstHighPercentageFirst()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("John",83); // John (83%)
        priorityQueue.Enqueue("Karl",90); // Karl (90%)
        priorityQueue.Enqueue("Carmen",92); // Carmen (92%) first high percentage
		priorityQueue.Enqueue("Chris",80); // Chris (80%)
        priorityQueue.Enqueue("Bill",92); // Bill (92%) second high percentage
        priorityQueue.Enqueue("Liz",85); // Liz (85%)
        priorityQueue.Enqueue("Alfred",92); // Alfred (92%) third high percentage
        priorityQueue.Enqueue("June",75); // Liz (75%)

        string expectedResult = "Carmen";

        string result = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult, result);

        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Try to get the high priority value from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Create a list of students where their priority is defined by their percentage in the course. 
    // Two students will have the same percentage, but the first in the queue must be the first
    // Ex: John (100), Karl (90), Carmen (92), Chris (100), Bill (92), Liz (85)
    // Expected Result: John (the first high percentage)
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_FirstIsTheFirst()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("John",100); // John (100%) high percentage
        priorityQueue.Enqueue("Karl",90); // Karl (90%)
        priorityQueue.Enqueue("Carmen",92); // Carmen (92%)
		priorityQueue.Enqueue("Chris",100); // Chris (100%) second high percentage
        priorityQueue.Enqueue("Bill",92); // Bill (92%)
        priorityQueue.Enqueue("Liz",85); // Liz (85%)

        string expectedResult = "John";

        string result = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult, result);

        // Assert.Fail("Implement the test case and then remove this.");
    }
}