public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }

    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <param name="number">The starting number.</param>
    /// <param name="length">The number of multiples.</param>
    /// <returns>Array of doubles that are the multiples of the supplied number.</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // Initialize an array to hold the multiples
        double[] multiples = new double[length];

        // Fill the array with multiples of the given number
        for (int i = 0; i < length; i++) {
            // Calculate and store the current multiple
            multiples[i] = number * (i + 1);
        }

        // Return the populated array of multiples
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 
    /// then the list after the function runs should be List{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range of 1 and data.Count, inclusive.
    /// Because a list is dynamic, this function will modify the existing data list, rather than returning a new list.
    /// </summary>
    /// <param name="data">The list of integers to be rotated.</param>
    /// <param name="amount">The amount by which to rotate the list.</param>
    private static void RotateListRight(List<int> data, int amount)
    {
        // Determine how much we actually need to rotate, considering the list's length
        int count = data.Count;
        int effectiveAmount = amount % count; // Ensure the rotation amount is within the list's bounds

        // Perform the rotation using list slicing
        // Extract the last 'effectiveAmount' elements as the new beginning of the list
        List<int> tail = data.GetRange(count - effectiveAmount, effectiveAmount);
        // Extract the initial part of the list that will move to the end
        List<int> head = data.GetRange(0, count - effectiveAmount);

        // Clear the original list and reassemble it with the rotated parts
        data.Clear();
        // Add the new beginning followed by the remaining elements
        data.AddRange(tail);
        data.AddRange(head);
    }
}