using The_Old_Robot.Robotics;

namespace The_Old_Robot.Power
{
    internal class OnCommand : IRobotCommand
    {
        public void Run(Robot Robot) 
        {
            Robot.IsPowered = true;
        }
    }
}
