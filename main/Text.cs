public static class Text 
{
    public static void Alert(string message)
    {
        // Add color to alert messages 
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void Info(string message)
    {
        // Add color to info messages 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}