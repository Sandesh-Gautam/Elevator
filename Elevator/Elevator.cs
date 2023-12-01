using System.Data;
using MySql.Data.MySqlClient;


namespace Elevator
{
    public partial class Elevator : Form
    {
        int yElevatorUp = 1;
        int yElevatorDown = 706;
        int yliftopendoor = 1;
        int yliftclosedoor = 135;
        int yliftopendowndoor = 1;
        int yliftclosedowndoor = 135;
        Elevator_Control ElevatorControl = new Elevator_Control();
        Elevator_Door Elevator_Door = new Elevator_Door();
        private Database database;
        public Elevator()
        {
            InitializeComponent();
            database = new Database("localhost", "elevator_db", "root", "root", "3306"); // Initialize the Database object here
        }
        private void insertdata(string action)
        {
            // Format the date and time together in the required format
            string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "INSERT INTO actions (Date, Time, Action) VALUES (@date, @time, @action)";


            // Use formattedDateTime for both date and time parameters
            MySqlParameter[] parameters = {
             new MySqlParameter("@date", formattedDateTime),
             new MySqlParameter("@time", formattedDateTime),
             new MySqlParameter("@action", action) };
            
            database.ExecuteNonQuery(query, parameters);
        }
        public void UpdateDatalog()
        {
            string connectionString = "datasource=localhost; Database=elevator_db; port=3306; User=root; Password=root; ";
            string query = "SELECT Date, Time, Action FROM actions";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Update the DataGridView with the new data
                        logTable.DataSource = dataTable;

                        if (logTable.Rows.Count > 0)
                        {
                            logTable.FirstDisplayedScrollingRowIndex = logTable.Rows.Count - 1;
                        }
                    }
                }
            }
        }
        private void lift_open_button_Click(object sender, EventArgs e)
        {
            if (Common.current_floor == 1)
            {
                if (Common.liftclosedown == true || Common.liftopendown == false)
                {
                    timerDownOpen.Start();
                    insertdata("Opening Ground Door");
                }
            }

            else if (Common.current_floor == 2)
            {
                if (Common.liftcloseup == true || Common.liftopenup == false)
                {
                    timerUpOpen.Start();
                    insertdata("Opening First Door");
                }
            }
        }

        private void lift_close_button_Click(object sender, EventArgs e)
        {
            if (Common.current_floor == 1)
            {             
                    if (Common.door_state == 0)
                    {
                        timerDownClose.Start();
                        insertdata("Closing Ground Door");
                    }
            }
            else if (Common.current_floor == 2)
            {
            
                    if (Common.door_state == 0)
                    {
                        timerUpClose.Start();
                        insertdata("Closing First Door");
                    }            
            }
        }
        private void lift_up_button_Click(object sender, EventArgs e)
        {
            if (Common.current_floor == 1)
            {
                if (Common.liftopendown == false)
                {
                    timerDownOpen.Start();
                    insertdata("Opening Ground Door");
                }
            }
            else if (Common.liftopenup == false)
            {
                if (Common.door_state == 0)
                {
                    timerLiftDown.Start();
                    insertdata("Lift Going Down");
                }
            }
        }
        private void lift_down_button_Click(object sender, EventArgs e)
        {
            if (Common.current_floor == 2)
            {
             
                if (Common.liftopenup == false)
                {
                    timerUpOpen.Start();
                    insertdata("Opening First Door");
                }
            }
            else if (Common.current_floor == 1 || Common.liftopendown == false)
            {
                if (Common.door_state == 0)
                {
                    timerLiftUp.Start();
                    insertdata("Lift Going Up");
                }
            }
        }
        private void timerLiftUp_Tick(object sender, EventArgs e)
        {
            if (Inside_Elevator.Top >= yElevatorUp)
            {
                ElevatorControl.elevatorUp(Inside_Elevator);
                Common.door_state = 1;
                display_panel.Image = global::Elevator.Properties.Resources.UpDisplay;
                display_panel_top.Image = global::Elevator.Properties.Resources.UpDisplay;
                display_panel_bottom.Image = global::Elevator.Properties.Resources.UpDisplay;
                

            }
            else
            {
                timerLiftUp.Stop();
                Common.door_state = 0;
                display_panel.Image = global::Elevator.Properties.Resources.OneDisplay;
                display_panel_top.Image = global::Elevator.Properties.Resources.OneDisplay;
                display_panel_bottom.Image = global::Elevator.Properties.Resources.OneDisplay;
                Common.current_floor = 2;
                timerUpOpen.Start();
            }
        }

        private void timerLiftDown_Tick(object sender, EventArgs e)
        {
            if (Inside_Elevator.Top <= yElevatorDown)
            {
                ElevatorControl.elevatorDown(Inside_Elevator);
                Common.door_state = 1;
                display_panel.Image = global::Elevator.Properties.Resources.DownDisplay;
                display_panel_top.Image = global::Elevator.Properties.Resources.DownDisplay;
                display_panel_bottom.Image = global::Elevator.Properties.Resources.DownDisplay;
            }
            else
            {
                timerLiftDown.Stop();
                Common.door_state = 0;
                display_panel.Image = global::Elevator.Properties.Resources.GDisplay;
                display_panel_top.Image = global::Elevator.Properties.Resources.GDisplay;
                display_panel_bottom.Image = global::Elevator.Properties.Resources.GDisplay;
                Common.current_floor = 1;
                timerDownOpen.Start();
            }
        }



        private void FirstFloorButton_Click(object sender, EventArgs e)
        {
            if (Common.current_floor == 1)
            {
                if (Common.liftopendown == false)
                {
                    if (Common.door_state == 0)
                    {
                        timerLiftUp.Start(); //up
                        insertdata("Lift Going Up");
                    }

                }
            }
            else if (Common.liftopenup == false)
            {
                timerUpOpen.Start(); //
                insertdata("Opening First Door");
            }
        }
        private void GroundFloorButton_Click(object sender, EventArgs e)
        {
            if (Common.current_floor == 2)
            {
                if (Common.liftopenup == false)
                {
                    if (Common.door_state == 0)
                    {
                        timerLiftDown.Start();
                        insertdata("Lift Going Down");
                    }
                }
            }
            else if (Common.liftopendown == false)
            {
                timerDownOpen.Start();
                insertdata("Opening Ground Door");
            }
        }
        private void timerUpOpen_Tick(object sender, EventArgs e)
        {
            if (yliftopendoor <= 135)
            {
                Elevator_Door.elevator_open_first_floor(left_first_door, right_first_door);
                yliftopendoor++;
                if (Common.emergency == false)
                {
                    timerAutoClose.Start();
                }
                Common.door_state = 0;
            }
            else
            {
                timerUpOpen.Stop();
                Common.door_state = 0;
                yliftopendoor = 1;
            }

        }

        private void timerDownOpen_Tick(object sender, EventArgs e)
        {
            if (yliftopendowndoor <= 135)
            {
                Elevator_Door.elevator_open_ground_floor(left_ground_door, right_ground_door);
                yliftopendowndoor++;
                if (Common.emergency == false)
                {
                    timerAutoClose.Start();
                }
                Common.door_state = 1;
            }
            else
            {
                Common.door_state = 0;
                timerDownOpen.Stop();
                yliftopendowndoor = 1;
            }

        }

        private void timerUpClose_Tick(object sender, EventArgs e) // first floor
        {

            if (yliftclosedoor >= 1)
            {
                Elevator_Door.elevator_close_first_floor(left_first_door, right_first_door);
                yliftclosedoor--;
                lift_close_button.Enabled = true;
                Common.door_state = 1;
            }
            else
            {
                timerUpClose.Stop();
                Common.door_state = 0;
                timerAutoClose.Stop();
                insertdata("Door Closed Automatically");
                yliftclosedoor = 135;
            }
        }


        private void timerDownClose_Tick(object sender, EventArgs e)
        {

            if (yliftclosedowndoor >= 1)
            {
                Elevator_Door.elevator_close_ground_floor(left_ground_door, right_ground_door);
                yliftclosedowndoor--;
                Common.door_state = 1;

            }
            else
            {
                timerDownClose.Stop();
                Common.door_state = 0;
                timerAutoClose.Stop();
                insertdata("Door Closed Automatically");
                yliftclosedowndoor = 135;
            }
        }

        private void timerAutoClose_Tick(object sender, EventArgs e)
        {
            if (Common.current_floor == 2)
            {
                timerUpClose.Start();
            }
            else if (Common.current_floor == 1)
            {
                timerDownClose.Start();
            }
        }
        private void Elevator_Load(object sender, EventArgs e)
        {
            display_panel.Image = global::Elevator.Properties.Resources.GDisplay;
            display_panel_top.Image = global::Elevator.Properties.Resources.GDisplay;
            display_panel_bottom.Image = global::Elevator.Properties.Resources.GDisplay;
        }

        private void EmergencyButton_Click(object sender, EventArgs e)
        {
            Common.emergency = true;
            Common.door_state = 0;
            timerUpOpen.Start();
            timerDownOpen.Start();
            timerLiftUp.Stop();
            timerLiftDown.Stop();
            timerAutoClose.Enabled = false;
            timerUpClose.Enabled = false;
            timerDownClose.Enabled = false;
            display_panel.Image = global::Elevator.Properties.Resources.emergency;
            display_panel_top.Image = global::Elevator.Properties.Resources.emergency;
            display_panel_bottom.Image = global::Elevator.Properties.Resources.emergency;           
        }
        private void btn_Display_Click(object sender, EventArgs e)
        {
            UpdateDatalog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete records from the 'actions' table
                string deleteQuery = "DELETE FROM actions";
                database.ExecuteNonQuery(deleteQuery);
                // Inform the user that the log has been cleared
                MessageBox.Show("Log has been cleared successfully.", "Log Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the operation
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}