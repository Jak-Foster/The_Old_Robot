using The_Old_Robot.Robotics;

namespace The_Old_Robot.Direction
{
    internal class NorthCommand : IRobotCommand
    {
        public void Run(Robot Robot)
        {
            if (Robot.IsPowered == true) Robot.Y += 1;
        }
    }
}
