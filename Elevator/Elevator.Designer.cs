namespace Elevator
{
    partial class Elevator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            Inside_Elevator = new PictureBox();
            right_first_door = new PictureBox();
            left_first_door = new PictureBox();
            panel1 = new Panel();
            right_ground_door = new PictureBox();
            left_ground_door = new PictureBox();
            lift_open_button = new PictureBox();
            lift_close_button = new PictureBox();
            lift_up_button = new PictureBox();
            lift_down_button = new PictureBox();
            pictureBox5 = new PictureBox();
            GroundFloorButton = new PictureBox();
            FirstFloorButton = new PictureBox();
            timerUpOpen = new System.Windows.Forms.Timer(components);
            timerUpClose = new System.Windows.Forms.Timer(components);
            timerLiftUp = new System.Windows.Forms.Timer(components);
            timerDownOpen = new System.Windows.Forms.Timer(components);
            timerDownClose = new System.Windows.Forms.Timer(components);
            timerLiftDown = new System.Windows.Forms.Timer(components);
            timerAutoClose = new System.Windows.Forms.Timer(components);
            display_panel = new PictureBox();
            logTable = new DataGridView();
            btn_Display = new Button();
            btnClear = new Button();
            btnExit = new Button();
            pictureBox2 = new PictureBox();
            display_panel_top = new PictureBox();
            display_panel_bottom = new PictureBox();
            EmergencyButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Inside_Elevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right_first_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left_first_door).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)right_ground_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left_ground_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lift_open_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lift_close_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lift_up_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lift_down_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GroundFloorButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstFloorButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)display_panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)display_panel_top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)display_panel_bottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmergencyButton).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame1;
            pictureBox1.Location = new Point(1609, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 1408);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Inside_Elevator
            // 
            Inside_Elevator.Image = Properties.Resources.InsideElevator;
            Inside_Elevator.Location = new Point(3, 711);
            Inside_Elevator.Name = "Inside_Elevator";
            Inside_Elevator.Size = new Size(270, 405);
            Inside_Elevator.SizeMode = PictureBoxSizeMode.StretchImage;
            Inside_Elevator.TabIndex = 1;
            Inside_Elevator.TabStop = false;
            // 
            // right_first_door
            // 
            right_first_door.Image = Properties.Resources.LeftDoor;
            right_first_door.Location = new Point(134, -9);
            right_first_door.Name = "right_first_door";
            right_first_door.Size = new Size(134, 416);
            right_first_door.SizeMode = PictureBoxSizeMode.StretchImage;
            right_first_door.TabIndex = 2;
            right_first_door.TabStop = false;
            // 
            // left_first_door
            // 
            left_first_door.Image = Properties.Resources.RightDoor;
            left_first_door.Location = new Point(0, -6);
            left_first_door.Name = "left_first_door";
            left_first_door.Size = new Size(136, 413);
            left_first_door.SizeMode = PictureBoxSizeMode.StretchImage;
            left_first_door.TabIndex = 3;
            left_first_door.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(right_ground_door);
            panel1.Controls.Add(right_first_door);
            panel1.Controls.Add(left_ground_door);
            panel1.Controls.Add(left_first_door);
            panel1.Controls.Add(Inside_Elevator);
            panel1.Location = new Point(1731, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 1113);
            panel1.TabIndex = 4;
            // 
            // right_ground_door
            // 
            right_ground_door.Image = Properties.Resources.LeftDoor;
            right_ground_door.Location = new Point(137, 711);
            right_ground_door.Name = "right_ground_door";
            right_ground_door.Size = new Size(131, 402);
            right_ground_door.SizeMode = PictureBoxSizeMode.StretchImage;
            right_ground_door.TabIndex = 12;
            right_ground_door.TabStop = false;
            // 
            // left_ground_door
            // 
            left_ground_door.Image = Properties.Resources.RightDoor;
            left_ground_door.Location = new Point(-3, 711);
            left_ground_door.Name = "left_ground_door";
            left_ground_door.Size = new Size(140, 402);
            left_ground_door.SizeMode = PictureBoxSizeMode.StretchImage;
            left_ground_door.TabIndex = 12;
            left_ground_door.TabStop = false;
            // 
            // lift_open_button
            // 
            lift_open_button.Image = Properties.Resources.Open;
            lift_open_button.Location = new Point(1289, 640);
            lift_open_button.Name = "lift_open_button";
            lift_open_button.Size = new Size(71, 75);
            lift_open_button.SizeMode = PictureBoxSizeMode.StretchImage;
            lift_open_button.TabIndex = 6;
            lift_open_button.TabStop = false;
            lift_open_button.Click += lift_open_button_Click;
            // 
            // lift_close_button
            // 
            lift_close_button.Image = Properties.Resources.Close;
            lift_close_button.Location = new Point(1391, 640);
            lift_close_button.Name = "lift_close_button";
            lift_close_button.Size = new Size(71, 75);
            lift_close_button.SizeMode = PictureBoxSizeMode.StretchImage;
            lift_close_button.TabIndex = 7;
            lift_close_button.TabStop = false;
            lift_close_button.Click += lift_close_button_Click;
            // 
            // lift_up_button
            // 
            lift_up_button.Image = Properties.Resources.Up;
            lift_up_button.Location = new Point(2051, 1042);
            lift_up_button.Name = "lift_up_button";
            lift_up_button.Size = new Size(59, 58);
            lift_up_button.SizeMode = PictureBoxSizeMode.StretchImage;
            lift_up_button.TabIndex = 10;
            lift_up_button.TabStop = false;
            lift_up_button.Click += lift_up_button_Click;
            // 
            // lift_down_button
            // 
            lift_down_button.Image = Properties.Resources.down;
            lift_down_button.Location = new Point(2051, 317);
            lift_down_button.Name = "lift_down_button";
            lift_down_button.Size = new Size(59, 58);
            lift_down_button.SizeMode = PictureBoxSizeMode.StretchImage;
            lift_down_button.TabIndex = 11;
            lift_down_button.TabStop = false;
            lift_down_button.Click += lift_down_button_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.concrete1;
            pictureBox5.Location = new Point(1609, 550);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(530, 308);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // GroundFloorButton
            // 
            GroundFloorButton.Image = Properties.Resources.G;
            GroundFloorButton.Location = new Point(1289, 550);
            GroundFloorButton.Name = "GroundFloorButton";
            GroundFloorButton.Size = new Size(71, 67);
            GroundFloorButton.SizeMode = PictureBoxSizeMode.StretchImage;
            GroundFloorButton.TabIndex = 14;
            GroundFloorButton.TabStop = false;
            GroundFloorButton.Click += GroundFloorButton_Click;
            // 
            // FirstFloorButton
            // 
            FirstFloorButton.Image = Properties.Resources._1;
            FirstFloorButton.Location = new Point(1391, 550);
            FirstFloorButton.Name = "FirstFloorButton";
            FirstFloorButton.Size = new Size(71, 67);
            FirstFloorButton.SizeMode = PictureBoxSizeMode.StretchImage;
            FirstFloorButton.TabIndex = 15;
            FirstFloorButton.TabStop = false;
            FirstFloorButton.Click += FirstFloorButton_Click;
            // 
            // timerUpOpen
            // 
            timerUpOpen.Interval = 10;
            timerUpOpen.Tick += timerUpOpen_Tick;
            // 
            // timerUpClose
            // 
            timerUpClose.Interval = 10;
            timerUpClose.Tick += timerUpClose_Tick;
            // 
            // timerLiftUp
            // 
            timerLiftUp.Interval = 1;
            timerLiftUp.Tick += timerLiftUp_Tick;
            // 
            // timerDownOpen
            // 
            timerDownOpen.Interval = 10;
            timerDownOpen.Tick += timerDownOpen_Tick;
            // 
            // timerDownClose
            // 
            timerDownClose.Interval = 10;
            timerDownClose.Tick += timerDownClose_Tick;
            // 
            // timerLiftDown
            // 
            timerLiftDown.Interval = 1;
            timerLiftDown.Tick += timerLiftDown_Tick;
            // 
            // timerAutoClose
            // 
            timerAutoClose.Interval = 5000;
            timerAutoClose.Tick += timerAutoClose_Tick;
            // 
            // display_panel
            // 
            display_panel.Image = Properties.Resources.DownDisplay;
            display_panel.Location = new Point(1318, 393);
            display_panel.Name = "display_panel";
            display_panel.Size = new Size(121, 109);
            display_panel.SizeMode = PictureBoxSizeMode.StretchImage;
            display_panel.TabIndex = 16;
            display_panel.TabStop = false;
            // 
            // logTable
            // 
            logTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            logTable.BackgroundColor = SystemColors.WindowFrame;
            logTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            logTable.GridColor = SystemColors.Desktop;
            logTable.Location = new Point(49, 28);
            logTable.Name = "logTable";
            logTable.RowHeadersWidth = 62;
            logTable.RowTemplate.Height = 33;
            logTable.Size = new Size(857, 1278);
            logTable.TabIndex = 17;
            // 
            // btn_Display
            // 
            btn_Display.Location = new Point(946, 290);
            btn_Display.Name = "btn_Display";
            btn_Display.Size = new Size(112, 34);
            btn_Display.TabIndex = 18;
            btn_Display.Text = "Display";
            btn_Display.UseVisualStyleBackColor = true;
            btn_Display.Click += btn_Display_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(946, 362);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(946, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ButtonPanel;
            pictureBox2.Location = new Point(1246, 362);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 449);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // display_panel_top
            // 
            display_panel_top.Image = Properties.Resources.black;
            display_panel_top.Location = new Point(2051, 145);
            display_panel_top.Name = "display_panel_top";
            display_panel_top.Size = new Size(59, 108);
            display_panel_top.SizeMode = PictureBoxSizeMode.StretchImage;
            display_panel_top.TabIndex = 22;
            display_panel_top.TabStop = false;
            // 
            // display_panel_bottom
            // 
            display_panel_bottom.Image = Properties.Resources.black;
            display_panel_bottom.Location = new Point(2051, 864);
            display_panel_bottom.Name = "display_panel_bottom";
            display_panel_bottom.Size = new Size(59, 108);
            display_panel_bottom.SizeMode = PictureBoxSizeMode.StretchImage;
            display_panel_bottom.TabIndex = 23;
            display_panel_bottom.TabStop = false;
            // 
            // EmergencyButton
            // 
            EmergencyButton.Image = Properties.Resources.emergency;
            EmergencyButton.Location = new Point(1335, 735);
            EmergencyButton.Name = "EmergencyButton";
            EmergencyButton.Size = new Size(71, 67);
            EmergencyButton.SizeMode = PictureBoxSizeMode.StretchImage;
            EmergencyButton.TabIndex = 24;
            EmergencyButton.TabStop = false;
            EmergencyButton.Click += EmergencyButton_Click;
            // 
            // Elevator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(2383, 1318);
            Controls.Add(EmergencyButton);
            Controls.Add(display_panel_bottom);
            Controls.Add(display_panel_top);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btn_Display);
            Controls.Add(logTable);
            Controls.Add(display_panel);
            Controls.Add(FirstFloorButton);
            Controls.Add(GroundFloorButton);
            Controls.Add(pictureBox5);
            Controls.Add(lift_down_button);
            Controls.Add(lift_up_button);
            Controls.Add(lift_close_button);
            Controls.Add(lift_open_button);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Elevator";
            Text = "Elevator_Control";
            WindowState = FormWindowState.Maximized;
            Load += Elevator_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Inside_Elevator).EndInit();
            ((System.ComponentModel.ISupportInitialize)right_first_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)left_first_door).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)right_ground_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)left_ground_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)lift_open_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)lift_close_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)lift_up_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)lift_down_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)GroundFloorButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstFloorButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)display_panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)logTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)display_panel_top).EndInit();
            ((System.ComponentModel.ISupportInitialize)display_panel_bottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmergencyButton).EndInit();
            ResumeLayout(false);
        }

        private void left_first_door_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Inside_Elevator;
        private PictureBox right_first_door;
        private PictureBox left_first_door;
        private Panel panel1;
        private PictureBox lift_open_button;
        private PictureBox lift_close_button;
        private PictureBox lift_up_button;
        private PictureBox lift_down_button;
        private PictureBox right_ground_door;
        private PictureBox left_ground_door;
        private PictureBox pictureBox5;
        private PictureBox GroundFloorButton;
        private PictureBox FirstFloorButton;
        private System.Windows.Forms.Timer timerUpOpen;
        private System.Windows.Forms.Timer timerUpClose;
        private System.Windows.Forms.Timer timerLiftUp;
        private System.Windows.Forms.Timer timerDownOpen;
        private System.Windows.Forms.Timer timerDownClose;
        private System.Windows.Forms.Timer timerLiftDown;
        private System.Windows.Forms.Timer timerAutoClose;
        private PictureBox display_panel;
        private DataGridView logTable;
        private Button btn_Display;
        private Button btnClear;
        private Button btnExit;
        private PictureBox pictureBox2;
        private PictureBox display_panel_top;
        private PictureBox display_panel_bottom;
        private PictureBox EmergencyButton;
    }
}