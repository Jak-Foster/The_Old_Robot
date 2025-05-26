
namespace The_Old_Robot.Coloured_Items
{
    public class ColouredItem<T>(T Item, ConsoleColor Colour)
    {
        public T Item { get; set; } = Item;
        public ConsoleColor Colour { get; set; } = Colour;

        public void Display()
        {
            Console.ForegroundColor = Colour;
            Console.WriteLine(Item.ToString());
        }
    }
}
