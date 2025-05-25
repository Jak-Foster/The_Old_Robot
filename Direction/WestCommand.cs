
namespace The_Old_Robot.Direction
{
    internal class WestCommand : RobotCommand
    {
        public override void Run(Robot Robot)
        {
            if (Robot.IsPowered == true) Robot.X -= 1;
        }
    }
}
