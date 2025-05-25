namespace The_Old_Robot.Power
{
    internal class OffCommand : IRobotCommand
    {
        public void Run(Robot Robot)
        {
            Robot.IsPowered = false;
        }
    }
}
