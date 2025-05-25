
namespace The_Old_Robot.Room_Coordinates
{
    public readonly struct Coordinate(int Row, int Column)
    {
        public readonly int Row = Row;
        public readonly int Column = Column;

        public bool IsAdjacent(Coordinate OtherCoordinate)
        {
            if ((Row + 1 == OtherCoordinate.Row || Row - 1 == OtherCoordinate.Row) && Column == OtherCoordinate.Column)
            {
                return true;
            }
            if ((Column + 1 == OtherCoordinate.Column || Column - 1 == OtherCoordinate.Column) && Row == OtherCoordinate.Row)
            {
                return true;
            }
            return false;
        }
    }
}
