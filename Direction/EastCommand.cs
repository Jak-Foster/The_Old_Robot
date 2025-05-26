namespace The_Old_Robot.Robotics;

internal class EastCommand : IRobotCommand
{
    public void Run(Robot Robot)
    {
        if (Robot.IsPowered == true) Robot.X += 1;
    }
}
