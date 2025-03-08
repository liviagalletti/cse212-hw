public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step-by-step plan to implement MultiplesOf:
        // 1. Understand the inputs: 'number' (a double, the starting number) and 'length' (an int, the size of the array).
        //    Example: MultiplesOf(3, 5) means start with 3 and generate 5 multiples: {3, 6, 9, 12, 15}.
        // 2. Determine the pattern: Each element is 'number' multiplied by an increasing integer (1, 2, 3, ...).
        //    For MultiplesOf(3, 5):
        //    - 1st element: 3 * 1 = 3
        //    - 2nd element: 3 * 2 = 6
        //    - 3rd element: 3 * 3 = 9, and so on.
        // 3. Create an array to store the results, with size 'length' since we need that many elements.
        // 4. Use a loop to populate the array:
        //    - Loop from 0 to length-1 (array indices).
        //    - For each index i, calculate the multiple as number * (i + 1).
        //    - Store the result in the array at index i.
        // 5. Return the completed array.
        // 6. Consider edge cases: The problem states length > 0, so no need to check for negative or zero length.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);

        }

        return result;

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Check if the list is empty or if amount is invalid (no need to do anything in this case)
        // Step 2: Calculate the cut point (where the list will be split)
        // The cut point is the size of the list minus the amount
        // Step 3: Get the two parts of the list
        // Part 1: The last 'amount' elements (which will go to the beginning)
        // Part 2: The first elements up to the cut point (which will go to the end)
        // Step 4: Clear the original list
        // Step 5: Rebuild the list in the correct order
        // First add Part 1 (the last elements)
        // Then add Part 2 (the first elements)
        if (data == null || data.Count == 0 || amount <= 0 || amount > data.Count)
        {
            return;
        }
        int cutPoint = data.Count - amount;


        List<int> lastPart = data.GetRange(cutPoint, amount);

        List<int> firstPart = data.GetRange(0, cutPoint);


        data.Clear();

        data.AddRange(lastPart);

        data.AddRange(firstPart);
    }
}
