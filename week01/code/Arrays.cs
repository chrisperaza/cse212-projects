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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1 - create "results" array to store the result elements with a fixed size that is determined by length
        // 2 - create variable "listIndex" to add the multiples to the "results" array
        // 3 - make a loop that starts at 1 to skip the multiple 0 and repeats the number of times determined by length
        // 4 - multiply number by each integer number to find the multiples and store it in a variable
        // 5 - add a condition that evaluates whether the remainder of multiple between number is zero to verify that it is indeed a multiple
        // 6 - if the condition from the previous step is met, add the multiple to the results array
        // 7 - plus 1 to the listIndex variable so that the next time you loop through the loop, the multiple is added to the next available array space
        // 8 - return the results array

        var results = new double[length];
        int listIndex = 0;

        for (int i = 1; i <= length; i++)
        {
            double multiple = number * i;

            if (multiple % number == 0)
            {
                results[listIndex] = multiple;
            }

            listIndex++;
        }

        return results; // replace this return statement with your own
    }
    

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1 - make a loop that starts at zero and the repetition of the loop is determined by "amount" to rotate the list as many times as determined by "amount"
        // 2 - get the last element of the list "data" and store it in a variable
        // 3 - use the Insert() method to place the value of the last element in the first position of the list and move the list to the right
        // 4 - use the RemoveAt() method to remove the last element from the list
        // 5 - return the modified data list

        for (int i = 0; i < amount; i++) {
			int lastNumber = data.Last();
			data.Insert(0, lastNumber);
			data.RemoveAt(data.Count - 1);
		}
		
		return data;
    }
}
