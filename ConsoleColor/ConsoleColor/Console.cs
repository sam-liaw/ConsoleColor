

namespace ConsoleColor
{
    public class Console
    {
        private static object _lock = new object();

        public static void WriteLine(string msg)
        {
            lock (_lock)
            {
                System.Console.ResetColor();

                System.Console.WriteLine(msg);
            }
        }

        public static void WriteLine(string msg, System.ConsoleColor color)
        {
            lock (_lock)
            {
                System.ConsoleColor currentForeground = System.Console.ForegroundColor;

                // 紀錄目前的字體顏色
                System.Console.ForegroundColor = color;

                System.Console.WriteLine(msg);

                // 顏色復原
                System.Console.ForegroundColor = currentForeground;
            }
        }

        public static void WriteLine(string msg, System.ConsoleColor foregroundColor, System.ConsoleColor backgroundColor)
        {
            lock (_lock)
            {
                System.ConsoleColor currentForeground = System.Console.ForegroundColor;
                System.ConsoleColor currentBackground = System.Console.BackgroundColor;

                // 紀錄目前的字體顏色
                System.Console.ForegroundColor = foregroundColor;
                System.Console.BackgroundColor = backgroundColor;

                System.Console.WriteLine(msg);

                // 顏色復原
                System.Console.ForegroundColor = currentForeground;
                System.Console.BackgroundColor = currentBackground;
            }
        }
    }
}
