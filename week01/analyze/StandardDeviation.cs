/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation {
    public static void Run() {
        var numbers = new[] { 600, 470, 170, 430, 300 };
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

    private static double StandardDeviation1(int[] numbers) {
        var total = 0.0; // 1 
        var count = 0; // 1
        foreach (var number in numbers) { // n
            total += number; // n
            count += 1; // n
        }

        var avg = total / count; // 1
        var sumSquaredDifferences = 0.0; // 1
        foreach (var number in numbers) { // n
            sumSquaredDifferences += Math.Pow(number - avg, 2); // n
        }

        var variance = sumSquaredDifferences / count; // 1
        return Math.Sqrt(variance); // 1
    }
    // O(6 + 5n) => 5n => n

    private static double StandardDeviation2(int[] numbers) {
        var sumSquaredDifferences = 0.0; // 1
        var countNumbers = 0; // 1
        foreach (var number in numbers) { // n
            var total = 0; // n
            var count = 0; // n
            foreach (var value in numbers) { // n * n = n²
                total += value; // n * n = n²
                count += 1; // n * n = n²
            }

            var avg = total / count; // n
            sumSquaredDifferences += Math.Pow(number - avg, 2); // n
            countNumbers += 1; // n
        }

        var variance = sumSquaredDifferences / countNumbers; // 1
        return Math.Sqrt(variance); // 1
    }
    // O(4 + 6n + 3n²) => 3n² => n²

    private static double StandardDeviation3(int[] numbers) {
        var count = numbers.Length; // 1
        var avg = (double)numbers.Sum() / count; // 1
        var sumSquaredDifferences = 0.0; // 1
        foreach (var number in numbers) { // n
            sumSquaredDifferences += Math.Pow(number - avg, 2); // n
        }

        var variance = sumSquaredDifferences / count; // 1
        return Math.Sqrt(variance); // 1
    }
    // O(5 + 2n) => 2n => n
}