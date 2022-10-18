namespace Commercial_Controller
{
    //Button on a floor or basement to go back to lobby
    public class CallButton
    {
        public int ID = 1;
        public string status;
        public int floor;
        public string direction;

        public CallButton(int callButtonID, string _status, int _floor, string _direction)
        {
            ID = callButtonID;
            status = _status;
            floor = _floor;
            direction = _direction;

        }
    }
}

