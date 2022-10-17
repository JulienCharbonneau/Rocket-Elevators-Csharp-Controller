namespace Commercial_Controller
{
    //Button on a floor or basement to go back to lobby
    public class FloorRequestButton
    {
        public int ID = 1;
        public string status = "status";
        public int floor;
        public string direction;
        public FloorRequestButton(int _floor, string _direction)
        {
            floor = _floor;
            direction = _direction;
        }
    }
}