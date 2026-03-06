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
        // PLAN
        // Step 1: Create an array with the size equal to length.
        // Step 2: Use a loop from 0 to length - 1.
        // Step 3: Multiply the number by (i + 1) to get each multiple.
        // Step 4: Store each result in the array.
        // Step 5: Return the completed array.

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
        // PLAN
        // Step 1: Find where the rotation starts using data.Count - amount.
        // Step 2: Get the last 'amount' values from the list.
        // Step 3: Remove those values from the end of the list.
        // Step 4: Insert those values at the beginning of the list.

        int startIndex = data.Count - amount;

        List<int> endPart = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, endPart);
    }
}
