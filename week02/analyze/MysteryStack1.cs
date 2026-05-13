public static class MysteryStack1 {
    public static string Run(string text) { // if text is = racecar / stressed / a nut for a jar of tuna
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result; // result is = racecar / desserts / anut fo raj a rof tun a
    }
}