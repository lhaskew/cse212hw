using System;
using System.Collections.Generic;

public class PriorityQueue
{
    private List<PriorityItem> _queue = new List<PriorityItem>();

    public void Enqueue(string value, int priority)
    {
        var newItem = new PriorityItem(value, priority);
        _queue.Add(newItem);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return null;
        }

        int highestPriorityIndex = 0;
        for (int i = 1; i < _queue.Count; i++)
        {
            if (_queue[i].Priority > _queue[highestPriorityIndex].Priority)
            {
                highestPriorityIndex = i;
            }
        }

        string valueToRemove = _queue[highestPriorityIndex].Value;
        _queue.RemoveAt(highestPriorityIndex);
        return valueToRemove;
    }

    public override string ToString()
    {
        return $"Queue: [{string.Join(", ", _queue)}]";
    }
}
