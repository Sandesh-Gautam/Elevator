namespace Elevator
{
    internal class Elevator_Control
    {

        public void elevatorUp(PictureBox Inside_Elevator)
        {
            Inside_Elevator.Top -= 2;
           
        }

        public void elevatorDown(PictureBox Inside_Elevator)
        {
            Inside_Elevator.Top += 2;
        
        }
    }
}