
namespace The_Old_Robot.Direction
{
    internal class NorthCommand : RobotCommand
    {
        public override void Run(Robot Robot)
        {
            if (Robot.IsPowered == true) Robot.Y += 1;
        }
    }
}
