namespace Commercial_Controller
{
    //Button on a floor or basement to go back to lobby
    public class CallButton
    {
        public int ID = 1;
        public int floor;
        public string status = "status";
        public string direction;

        public CallButton(int _floor, string _direction)
        {
            floor = _floor;
            direction = _direction;

        }
    }
}

