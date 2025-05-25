
namespace The_Old_Robot.Direction
{
    internal class SouthCommand : IRobotCommand
    {
        public void Run(Robot Robot)
        {
            if (Robot.IsPowered == true) Robot.Y -= 1;
        }
    }
}
