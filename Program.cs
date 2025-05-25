using The_Old_Robot;
using The_Old_Robot.Power;
using The_Old_Robot.Direction;

internal class Program
{
    private static void Main()
    {
        Robot Robot = new();

        Console.WriteLine("Enter three commands for your robot!");

        for (int I = -1; I++ < 2; )
        {
            RobotCommand UserInput = Console.ReadLine() switch
            {
                "On" => new OnCommand(),
                "Off" => new OffCommand(),
                "North" => new NorthCommand(),
                "South" => new SouthCommand(),
                "East" => new EastCommand(),
                "West" => new WestCommand()
            };

            Robot.Commands[I] = UserInput;
        }

        Robot.Run();
    }
}