public static class Priority {
    public static void Test() {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test 1
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item1", 2);
        priorityQueue.Enqueue("Item2", 1);
        priorityQueue.Enqueue("Item3", 3);
        RunPriorityTests(priorityQueue, 3);
        Console.WriteLine("---------");

        // Test 2
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Item4", 2);
        priorityQueue.Enqueue("Item5", 2);
        priorityQueue.Enqueue("Item6", 1);
        RunPriorityTests(priorityQueue, 6);
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }

    private static void RunPriorityTests(PriorityQueue queue, int count) {
        for (int i = 0; i < count; i++) {
            var item = queue.Dequeue();
            if (item != null) {
                Console.WriteLine($"Dequeued: {item}");
            }
        }
    }
}
