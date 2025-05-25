namespace The_Old_Robot.Power
{
    internal class OnCommand : RobotCommand
    {
        public override void Run(Robot Robot) 
        {
            Robot.IsPowered = true;
        }
    }
}
