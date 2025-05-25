namespace The_Old_Robot.Power
{
    internal class OffCommand : RobotCommand
    {
        public override void Run(Robot Robot)
        {
            Robot.IsPowered = false;
        }
    }
}
