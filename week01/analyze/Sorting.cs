public static class Sorting {
    public static void Run() {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    private static void SortArray(int[] data) {
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--) { // n
            for (var swapPos = 0; swapPos < sortPos; ++swapPos) { // n * n = n²
                if (data[swapPos] > data[swapPos + 1]) { // n * n = n²
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]); // n * n = n²
                }
            }
        }
    }
}

// O(n + 3n²) => 3n² => n²