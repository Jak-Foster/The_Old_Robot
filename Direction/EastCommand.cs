
namespace The_Old_Robot.Direction
{
    internal class EastCommand : IRobotCommand
    {
        public void Run(Robot Robot)
        {
            if (Robot.IsPowered == true) Robot.X += 1;
        }
    }
}
