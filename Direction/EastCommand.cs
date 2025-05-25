
namespace The_Old_Robot.Direction
{
    internal class EastCommand : RobotCommand
    {
        public override void Run(Robot Robot)
        {
            if (Robot.IsPowered == true) Robot.X += 1;
        }
    }
}
