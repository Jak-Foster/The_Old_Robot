using The_Old_Robot;
using The_Old_Robot.Power;
using The_Old_Robot.Direction;
using The_Old_Robot.Room_Coordinates;
using The_Old_Robot.War_Preparations;

internal class Program
{
    private static void Main()
    {
        //Robot Robot = new();

        //Console.WriteLine("Enter three commands for your robot!");

        //for (int I = -1; I++ < 2; )
        //{
        //    IRobotCommand UserInput = Console.ReadLine() switch
        //    {
        //        "On" => new OnCommand(),
        //        "Off" => new OffCommand(),
        //        "North" => new NorthCommand(),
        //        "South" => new SouthCommand(),
        //        "East" => new EastCommand(),
        //        "West" => new WestCommand()
        //    };

        //    Robot.Commands[I] = UserInput;
        //}

        //Robot.Run();


        //Coordinate Room1 = new(0, 1);
        //Coordinate Room2 = new(3, 2);
        //Coordinate Room3 = new(5, 6);
        //Coordinate Room4 = new(4, 7);
        //Coordinate Room5 = new(4, 6);

        //Console.WriteLine(Room1.IsAdjacent(Room2));
        //Console.WriteLine(Room2.IsAdjacent(Room3));
        //Console.WriteLine(Room3.IsAdjacent(Room4));
        //Console.WriteLine(Room4.IsAdjacent(Room5));
        //Console.WriteLine(Room5.IsAdjacent(Room1));
        //Console.WriteLine(Room3.IsAdjacent(Room3));

        SwordRecord SwordOne = new(SwordMaterial.Iron, SwordGemstone.None, 10, 4);
        SwordRecord SwordTwo = SwordOne with { SwordMaterial = SwordMaterial.Binarium, SwordGemstone = SwordGemstone.Bitstone };
        SwordRecord SwordThree = SwordTwo with { SwordMaterial = SwordMaterial.Bronze, SwordLength = 15, CrossGuardWidth = 3 };

        Console.WriteLine(SwordOne);
        Console.WriteLine(SwordTwo);
        Console.WriteLine(SwordThree);
        Console.WriteLine(SwordThree.SwordMaterial);    

    }
}