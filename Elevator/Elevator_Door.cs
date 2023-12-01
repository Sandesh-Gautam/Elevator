namespace Elevator
{
    internal class Elevator_Door
    {
        public void elevator_open_first_floor(PictureBox left_first_floor,PictureBox right_first_floor)
        {
         left_first_floor.Left -= 1;
         right_first_floor.Left += 1;
         Common.liftopenup = true;
         Common.liftcloseup = false;
           

        }
        public void elevator_close_first_floor(PictureBox left_first_floor, PictureBox right_first_floor)
        {

            left_first_floor.Left += 1;
            right_first_floor.Left -= 1;
            Common.liftopenup = false;
            Common.liftcloseup = true;
     
        }
        public void elevator_open_ground_floor(PictureBox left_ground_floor, PictureBox right_ground_floor)
        {

            left_ground_floor.Left -= 1;
            right_ground_floor.Left += 1;
            Common.liftopendown = true;
            Common.liftclosedown = false;
         

        }
        public void elevator_close_ground_floor(PictureBox left_ground_floor, PictureBox right_ground_floor)
        {

            left_ground_floor.Left += 1;
            right_ground_floor.Left -= 1;
            Common.liftopendown = false;
            Common.liftclosedown = true;
         
        }
    }
}
