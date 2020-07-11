using System;

namespace KoyashiroKohaku.GitHubActionsPractice
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            // Hello World!
            Console.WriteLine(GetHellowWorld());

            // The current time is 'yyyy/MM/dd H:mm:ss'
            Console.WriteLine($"The current time is '{GetCurrentTime()}'.");
        }

        public static string GetHellowWorld()
        {
            return "Hello World!";
        }

        public static DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}
