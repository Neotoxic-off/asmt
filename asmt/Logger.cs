namespace ASMT
{
    public static class Logger
    {
        public static void Information(string message)
        {
            Render(ConsoleColor.DarkCyan, "info", message);
        }

        public static void Error(string message)
        {
            Render(ConsoleColor.Red, "erro", message);
        }

        public static void Warning(string message)
        {
            Render(ConsoleColor.Yellow, "warn", message);
        }

        public static void Success(string message)
        {
            Render(ConsoleColor.Green, "succ", message);
        }

        public static void Fail(string message)
        {
            Render(ConsoleColor.Red, "fail", message);
        }

        private static void Render(ConsoleColor color, string type, string message)
        {
            ConsoleColor original = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.Write(type.ToUpper());
            Console.ForegroundColor = original;
            Console.WriteLine($" {message}");
        }
    }
}