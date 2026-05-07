public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        int inputNumber1 = 12;
        List<int> list = FindDivisors(inputNumber1);
        Console.WriteLine("Divisors of " + inputNumber1 + " = " + string.Join(", ", list)); // Divisors of 12 = 1, 2, 3, 4, 6

        int inputNumber2 = 17;
        List<int> list1 = FindDivisors(inputNumber2);
        Console.WriteLine("Divisors of " + inputNumber2 + " = " + string.Join(", ", list1)); // Divisors of 17 = 1
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number) {
        List<int> results = new();
        for (int i = 1; i < number; i++)
        {
            if(number % i == 0)
            {
                results.Add(i);
            }
        }
        return results;
    }
}