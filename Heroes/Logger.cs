using Heroes.Abstract;

namespace Heroes
{
    public class Logger : ILogger
    {
        public void Message(ConsoleColor Color, string Massage)
        {
            Console.BackgroundColor = Color;
            Console.WriteLine(Massage);
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
