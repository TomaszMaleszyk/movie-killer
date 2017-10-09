namespace MovieKillerDesktopApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.progressBar_TimeToEnd = new System.Windows.Forms.ProgressBar();
            this.lb_timer = new System.Windows.Forms.Label();
            this.lb_endOfOperation = new System.Windows.Forms.Label();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.numUD_hours = new System.Windows.Forms.NumericUpDown();
            this.numUD_minutes = new System.Windows.Forms.NumericUpDown();
            this.numUD_seconds = new System.Windows.Forms.NumericUpDown();
            this.gb_setTime = new System.Windows.Forms.GroupBox();
            this.numUD_inputTimeToStart = new System.Windows.Forms.NumericUpDown();
            this.rb_atTime = new System.Windows.Forms.RadioButton();
            this.rb_timeLeft = new System.Windows.Forms.RadioButton();
            this.panel_clock = new System.Windows.Forms.Panel();
            this.lb_timeOfEnd = new System.Windows.Forms.Label();
            this.lb_timeToEnd = new System.Windows.Forms.Label();
            this.lb_connectionStatus = new System.Windows.Forms.Label();
            this.panel_controlClock = new System.Windows.Forms.Panel();
            this.btn_stopClock = new System.Windows.Forms.Button();
            this.btn_slowDownCountdown = new System.Windows.Forms.Button();
            this.btn_speedUpCountdown = new System.Windows.Forms.Button();
            this.btn_startClock = new System.Windows.Forms.Button();
            this.cb_pauseClock = new System.Windows.Forms.CheckBox();
            this.gb_operationsCollection = new System.Windows.Forms.GroupBox();
            this.rb_alarmClock = new System.Windows.Forms.RadioButton();
            this.rb_shutDown = new System.Windows.Forms.RadioButton();
            this.rb_restart = new System.Windows.Forms.RadioButton();
            this.rb_sleep = new System.Windows.Forms.RadioButton();
            this.rb_logout = new System.Windows.Forms.RadioButton();
            this.rb_lock = new System.Windows.Forms.RadioButton();
            this.panel_bottomMenu = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.lb_messageReceived = new System.Windows.Forms.Label();
            this.cb_listenningConnection = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_seconds)).BeginInit();
            this.gb_setTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_inputTimeToStart)).BeginInit();
            this.panel_clock.SuspendLayout();
            this.panel_controlClock.SuspendLayout();
            this.gb_operationsCollection.SuspendLayout();
            this.panel_bottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar_TimeToEnd
            // 
            this.progressBar_TimeToEnd.Location = new System.Drawing.Point(0, 190);
            this.progressBar_TimeToEnd.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_TimeToEnd.Maximum = 10000;
            this.progressBar_TimeToEnd.Name = "progressBar_TimeToEnd";
            this.progressBar_TimeToEnd.Size = new System.Drawing.Size(550, 10);
            this.progressBar_TimeToEnd.TabIndex = 4;
            // 
            // lb_timer
            // 
            this.lb_timer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_timer.Font = new System.Drawing.Font("Calibri", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_timer.Location = new System.Drawing.Point(101, 39);
            this.lb_timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(349, 86);
            this.lb_timer.TabIndex = 7;
            this.lb_timer.Text = "00 : 00 : 00";
            this.lb_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_endOfOperation
            // 
            this.lb_endOfOperation.BackColor = System.Drawing.Color.DodgerBlue;
            this.lb_endOfOperation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_endOfOperation.Location = new System.Drawing.Point(148, 149);
            this.lb_endOfOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_endOfOperation.MinimumSize = new System.Drawing.Size(250, 0);
            this.lb_endOfOperation.Name = "lb_endOfOperation";
            this.lb_endOfOperation.Size = new System.Drawing.Size(250, 37);
            this.lb_endOfOperation.TabIndex = 9;
            this.lb_endOfOperation.Text = "00 : 00 : 00";
            this.lb_endOfOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_clock
            // 
            this.timer_clock.Interval = 1000;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // numUD_hours
            // 
            this.numUD_hours.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_hours.ForeColor = System.Drawing.Color.Indigo;
            this.numUD_hours.Location = new System.Drawing.Point(8, 150);
            this.numUD_hours.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numUD_hours.Name = "numUD_hours";
            this.numUD_hours.ReadOnly = true;
            this.numUD_hours.Size = new System.Drawing.Size(84, 32);
            this.numUD_hours.TabIndex = 11;
            this.numUD_hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUD_minutes
            // 
            this.numUD_minutes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_minutes.ForeColor = System.Drawing.Color.Indigo;
            this.numUD_minutes.Location = new System.Drawing.Point(100, 150);
            this.numUD_minutes.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUD_minutes.Name = "numUD_minutes";
            this.numUD_minutes.ReadOnly = true;
            this.numUD_minutes.Size = new System.Drawing.Size(72, 32);
            this.numUD_minutes.TabIndex = 12;
            this.numUD_minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUD_seconds
            // 
            this.numUD_seconds.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_seconds.ForeColor = System.Drawing.Color.Indigo;
            this.numUD_seconds.Location = new System.Drawing.Point(178, 150);
            this.numUD_seconds.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUD_seconds.Name = "numUD_seconds";
            this.numUD_seconds.ReadOnly = true;
            this.numUD_seconds.Size = new System.Drawing.Size(79, 32);
            this.numUD_seconds.TabIndex = 13;
            this.numUD_seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_setTime
            // 
            this.gb_setTime.BackColor = System.Drawing.Color.MediumPurple;
            this.gb_setTime.Controls.Add(this.numUD_inputTimeToStart);
            this.gb_setTime.Controls.Add(this.rb_atTime);
            this.gb_setTime.Controls.Add(this.numUD_seconds);
            this.gb_setTime.Controls.Add(this.rb_timeLeft);
            this.gb_setTime.Controls.Add(this.numUD_minutes);
            this.gb_setTime.Controls.Add(this.numUD_hours);
            this.gb_setTime.Font = new System.Drawing.Font("OCR A Extended", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_setTime.ForeColor = System.Drawing.Color.Indigo;
            this.gb_setTime.Location = new System.Drawing.Point(264, 220);
            this.gb_setTime.Margin = new System.Windows.Forms.Padding(4);
            this.gb_setTime.Name = "gb_setTime";
            this.gb_setTime.Padding = new System.Windows.Forms.Padding(4);
            this.gb_setTime.Size = new System.Drawing.Size(298, 208);
            this.gb_setTime.TabIndex = 14;
            this.gb_setTime.TabStop = false;
            this.gb_setTime.Text = "Ustal czas rozpoczęcia operacji";
            // 
            // numUD_inputTimeToStart
            // 
            this.numUD_inputTimeToStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_inputTimeToStart.ForeColor = System.Drawing.Color.Indigo;
            this.numUD_inputTimeToStart.Location = new System.Drawing.Point(8, 110);
            this.numUD_inputTimeToStart.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_inputTimeToStart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUD_inputTimeToStart.Name = "numUD_inputTimeToStart";
            this.numUD_inputTimeToStart.ReadOnly = true;
            this.numUD_inputTimeToStart.Size = new System.Drawing.Size(249, 32);
            this.numUD_inputTimeToStart.TabIndex = 14;
            this.numUD_inputTimeToStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUD_inputTimeToStart.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // rb_atTime
            // 
            this.rb_atTime.AutoSize = true;
            this.rb_atTime.BackColor = System.Drawing.Color.DarkMagenta;
            this.rb_atTime.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_atTime.ForeColor = System.Drawing.Color.Thistle;
            this.rb_atTime.Location = new System.Drawing.Point(8, 60);
            this.rb_atTime.Margin = new System.Windows.Forms.Padding(4);
            this.rb_atTime.Name = "rb_atTime";
            this.rb_atTime.Size = new System.Drawing.Size(199, 22);
            this.rb_atTime.TabIndex = 1;
            this.rb_atTime.TabStop = true;
            this.rb_atTime.Text = "Konkretna godzina";
            this.rb_atTime.UseVisualStyleBackColor = false;
            this.rb_atTime.Click += new System.EventHandler(this.RadioButtonChooseKindOfCountingTimeManager);
            // 
            // rb_timeLeft
            // 
            this.rb_timeLeft.AutoSize = true;
            this.rb_timeLeft.BackColor = System.Drawing.Color.DarkMagenta;
            this.rb_timeLeft.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_timeLeft.ForeColor = System.Drawing.Color.Thistle;
            this.rb_timeLeft.Location = new System.Drawing.Point(8, 23);
            this.rb_timeLeft.Margin = new System.Windows.Forms.Padding(4);
            this.rb_timeLeft.Name = "rb_timeLeft";
            this.rb_timeLeft.Size = new System.Drawing.Size(169, 22);
            this.rb_timeLeft.TabIndex = 0;
            this.rb_timeLeft.TabStop = true;
            this.rb_timeLeft.Text = "Pozostały czas";
            this.rb_timeLeft.UseVisualStyleBackColor = false;
            this.rb_timeLeft.Click += new System.EventHandler(this.RadioButtonChooseKindOfCountingTimeManager);
            // 
            // panel_clock
            // 
            this.panel_clock.BackColor = System.Drawing.Color.MediumBlue;
            this.panel_clock.Controls.Add(this.lb_endOfOperation);
            this.panel_clock.Controls.Add(this.lb_timeOfEnd);
            this.panel_clock.Controls.Add(this.lb_timeToEnd);
            this.panel_clock.Controls.Add(this.lb_timer);
            this.panel_clock.Controls.Add(this.progressBar_TimeToEnd);
            this.panel_clock.Location = new System.Drawing.Point(12, 12);
            this.panel_clock.Name = "panel_clock";
            this.panel_clock.Size = new System.Drawing.Size(550, 200);
            this.panel_clock.TabIndex = 15;
            // 
            // lb_timeOfEnd
            // 
            this.lb_timeOfEnd.AutoSize = true;
            this.lb_timeOfEnd.BackColor = System.Drawing.Color.MediumBlue;
            this.lb_timeOfEnd.ForeColor = System.Drawing.Color.LightBlue;
            this.lb_timeOfEnd.Location = new System.Drawing.Point(184, 125);
            this.lb_timeOfEnd.Name = "lb_timeOfEnd";
            this.lb_timeOfEnd.Size = new System.Drawing.Size(214, 24);
            this.lb_timeOfEnd.TabIndex = 10;
            this.lb_timeOfEnd.Text = "Operacja zakończy się o:";
            this.lb_timeOfEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_timeToEnd
            // 
            this.lb_timeToEnd.AutoSize = true;
            this.lb_timeToEnd.BackColor = System.Drawing.Color.MediumBlue;
            this.lb_timeToEnd.ForeColor = System.Drawing.Color.LightBlue;
            this.lb_timeToEnd.Location = new System.Drawing.Point(151, 15);
            this.lb_timeToEnd.Name = "lb_timeToEnd";
            this.lb_timeToEnd.Size = new System.Drawing.Size(295, 24);
            this.lb_timeToEnd.TabIndex = 8;
            this.lb_timeToEnd.Text = "Do wykonania operacji pozostało:";
            this.lb_timeToEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_connectionStatus
            // 
            this.lb_connectionStatus.AutoSize = true;
            this.lb_connectionStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_connectionStatus.Location = new System.Drawing.Point(145, 6);
            this.lb_connectionStatus.Name = "lb_connectionStatus";
            this.lb_connectionStatus.Size = new System.Drawing.Size(122, 18);
            this.lb_connectionStatus.TabIndex = 24;
            this.lb_connectionStatus.Text = "Status połączenia: ";
            this.lb_connectionStatus.MouseEnter += new System.EventHandler(this.panel_bottomMenu_MouseEnter);
            // 
            // panel_controlClock
            // 
            this.panel_controlClock.BackColor = System.Drawing.Color.Gold;
            this.panel_controlClock.Controls.Add(this.btn_stopClock);
            this.panel_controlClock.Controls.Add(this.btn_slowDownCountdown);
            this.panel_controlClock.Controls.Add(this.btn_speedUpCountdown);
            this.panel_controlClock.Controls.Add(this.btn_startClock);
            this.panel_controlClock.Controls.Add(this.cb_pauseClock);
            this.panel_controlClock.Location = new System.Drawing.Point(128, 435);
            this.panel_controlClock.Name = "panel_controlClock";
            this.panel_controlClock.Size = new System.Drawing.Size(303, 62);
            this.panel_controlClock.TabIndex = 24;
            // 
            // btn_stopClock
            // 
            this.btn_stopClock.BackColor = System.Drawing.Color.Tomato;
            this.btn_stopClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stopClock.Image = global::MovieKillerDesktopApp.Properties.Resources.iconStop__3_;
            this.btn_stopClock.Location = new System.Drawing.Point(73, 6);
            this.btn_stopClock.Name = "btn_stopClock";
            this.btn_stopClock.Size = new System.Drawing.Size(50, 50);
            this.btn_stopClock.TabIndex = 29;
            this.btn_stopClock.UseVisualStyleBackColor = false;
            this.btn_stopClock.Click += new System.EventHandler(this.btn_stopClock_Click);
            // 
            // btn_slowDownCountdown
            // 
            this.btn_slowDownCountdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_slowDownCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_slowDownCountdown.Image = ((System.Drawing.Image)(resources.GetObject("btn_slowDownCountdown.Image")));
            this.btn_slowDownCountdown.Location = new System.Drawing.Point(22, 8);
            this.btn_slowDownCountdown.Name = "btn_slowDownCountdown";
            this.btn_slowDownCountdown.Size = new System.Drawing.Size(45, 45);
            this.btn_slowDownCountdown.TabIndex = 28;
            this.btn_slowDownCountdown.UseVisualStyleBackColor = false;
            this.btn_slowDownCountdown.Click += new System.EventHandler(this.btn_slowDownCountdown_Click);
            // 
            // btn_speedUpCountdown
            // 
            this.btn_speedUpCountdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_speedUpCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speedUpCountdown.Image = global::MovieKillerDesktopApp.Properties.Resources.iconSpeedUp1;
            this.btn_speedUpCountdown.Location = new System.Drawing.Point(241, 9);
            this.btn_speedUpCountdown.Name = "btn_speedUpCountdown";
            this.btn_speedUpCountdown.Size = new System.Drawing.Size(45, 45);
            this.btn_speedUpCountdown.TabIndex = 27;
            this.btn_speedUpCountdown.UseVisualStyleBackColor = false;
            this.btn_speedUpCountdown.Click += new System.EventHandler(this.btn_speedUpCountdown_Click);
            // 
            // btn_startClock
            // 
            this.btn_startClock.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_startClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startClock.Image = global::MovieKillerDesktopApp.Properties.Resources.iconStart__2_;
            this.btn_startClock.Location = new System.Drawing.Point(129, 6);
            this.btn_startClock.Name = "btn_startClock";
            this.btn_startClock.Size = new System.Drawing.Size(50, 50);
            this.btn_startClock.TabIndex = 24;
            this.btn_startClock.UseVisualStyleBackColor = false;
            this.btn_startClock.Click += new System.EventHandler(this.btn_startClock_Click);
            // 
            // cb_pauseClock
            // 
            this.cb_pauseClock.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_pauseClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cb_pauseClock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_pauseClock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_pauseClock.Image = global::MovieKillerDesktopApp.Properties.Resources.iconPause__2_;
            this.cb_pauseClock.Location = new System.Drawing.Point(185, 6);
            this.cb_pauseClock.Name = "cb_pauseClock";
            this.cb_pauseClock.Size = new System.Drawing.Size(50, 50);
            this.cb_pauseClock.TabIndex = 23;
            this.cb_pauseClock.UseVisualStyleBackColor = false;
            this.cb_pauseClock.CheckedChanged += new System.EventHandler(this.cb_pauseClock_CheckedChanged);
            // 
            // gb_operationsCollection
            // 
            this.gb_operationsCollection.BackColor = System.Drawing.Color.MediumPurple;
            this.gb_operationsCollection.Controls.Add(this.rb_alarmClock);
            this.gb_operationsCollection.Controls.Add(this.rb_shutDown);
            this.gb_operationsCollection.Controls.Add(this.rb_restart);
            this.gb_operationsCollection.Controls.Add(this.rb_sleep);
            this.gb_operationsCollection.Controls.Add(this.rb_logout);
            this.gb_operationsCollection.Controls.Add(this.rb_lock);
            this.gb_operationsCollection.Font = new System.Drawing.Font("OCR A Extended", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_operationsCollection.ForeColor = System.Drawing.Color.Indigo;
            this.gb_operationsCollection.Location = new System.Drawing.Point(12, 220);
            this.gb_operationsCollection.Margin = new System.Windows.Forms.Padding(4);
            this.gb_operationsCollection.Name = "gb_operationsCollection";
            this.gb_operationsCollection.Padding = new System.Windows.Forms.Padding(4);
            this.gb_operationsCollection.Size = new System.Drawing.Size(244, 208);
            this.gb_operationsCollection.TabIndex = 25;
            this.gb_operationsCollection.TabStop = false;
            this.gb_operationsCollection.Text = "Wybierz rodzaj operacji";
            // 
            // rb_alarmClock
            // 
            this.rb_alarmClock.AutoSize = true;
            this.rb_alarmClock.BackColor = System.Drawing.Color.DarkMagenta;
            this.rb_alarmClock.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_alarmClock.ForeColor = System.Drawing.Color.Thistle;
            this.rb_alarmClock.Location = new System.Drawing.Point(7, 174);
            this.rb_alarmClock.Margin = new System.Windows.Forms.Padding(4);
            this.rb_alarmClock.Name = "rb_alarmClock";
            this.rb_alarmClock.Size = new System.Drawing.Size(89, 22);
            this.rb_alarmClock.TabIndex = 25;
            this.rb_alarmClock.TabStop = true;
            this.rb_alarmClock.Text = "Budzik";
            this.rb_alarmClock.UseVisualStyleBackColor = false;
            this.rb_alarmClock.CheckedChanged += new System.EventHandler(this.RadioButtonChooseKindOfOperationManager);
            // 
            // rb_shutDown
            // 
            this.rb_shutDown.AutoSize = true;
            this.rb_shutDown.BackColor = System.Drawing.Color.DarkMagenta;
            this.rb_shutDown.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_shutDown.ForeColor = System.Drawing.Color.Thistle;
            this.rb_shutDown.Location = new System.Drawing.Point(7, 144);
            this.rb_shutDown.Margin = new System.Windows.Forms.Padding(4);
            this.rb_shutDown.Name = "rb_shutDown";
            this.rb_shutDown.Size = new System.Drawing.Size(87, 22);
            this.rb_shutDown.TabIndex = 24;
            this.rb_shutDown.TabStop = true;
            this.rb_shutDown.Text = "Wyłącz";
            this.rb_shutDown.UseVisualStyleBackColor = false;
            this.rb_shutDown.CheckedChanged += new System.EventHandler(this.RadioButtonChooseKindOfOperationManager);
            // 
            // rb_restart
            // 
            this.rb_restart.AutoSize = true;
            this.rb_restart.BackColor = System.Drawing.Color.DarkMagenta;
            this.rb_restart.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_restart.ForeColor = System.Drawing.Color.Thistle;
            this.rb_restart.Location = new System.Drawing.Point(7, 114);
            this.rb_restart.Margin = new System.Windows.Forms.Padding(4);
            this.rb_restart.Name = "rb_restart";
            this.rb_restart.Size = new System.Drawing.Size(129, 22);
            this.rb_restart.TabIndex = 23;
            this.rb_restart.TabStop = true;
            this.rb_restart.Text = "Zrestartuj";
            this.rb_restart.UseVisualStyleBackColor = false;
            this.rb_restart.CheckedChanged += new System.EventHandler(this.RadioButtonChooseKindOfOperationManager);
            // 
            // rb_sleep
            // 
            this.rb_sleep.AutoSize = true;
            this.rb_sleep.BackColor = System.Drawing.Color.DarkMagenta;
            this.rb_sleep.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sleep.ForeColor = System.Drawing.Color.Thistle;
            this.rb_sleep.Location = new System.Drawing.Point(7, 84);
            this.rb_sleep.Margin = new System.Windows.Forms.Padding(4);
            this.rb_sleep.Name = "rb_sleep";
            this.rb_sleep.Size = new System.Drawing.Size(76, 22);
            this.rb_sleep.TabIndex = 22;
            this.rb_sleep.TabStop = true;
            this.rb_sleep.Text = "Uśpij";
            this.rb_sleep.UseVisualStyleBackColor = false;
            this.rb_sleep.CheckedChanged += new System.EventHandler(this.RadioButtonChooseKindOfOperationManager);
            // 
            // rb_logout
            // 
            this.rb_logout.AutoSize = true;
            this.rb_logout.BackColor = System.Drawing.Color.DarkMagenta;
            this.rb_logout.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_logout.ForeColor = System.Drawing.Color.Thistle;
            this.rb_logout.Location = new System.Drawing.Point(7, 54);
            this.rb_logout.Margin = new System.Windows.Forms.Padding(4);
            this.rb_logout.Name = "rb_logout";
            this.rb_logout.Size = new System.Drawing.Size(99, 22);
            this.rb_logout.TabIndex = 21;
            this.rb_logout.TabStop = true;
            this.rb_logout.Text = "Wyloguj";
            this.rb_logout.UseVisualStyleBackColor = false;
            this.rb_logout.CheckedChanged += new System.EventHandler(this.RadioButtonChooseKindOfOperationManager);
            // 
            // rb_lock
            // 
            this.rb_lock.AutoSize = true;
            this.rb_lock.BackColor = System.Drawing.Color.DarkMagenta;
            this.rb_lock.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lock.ForeColor = System.Drawing.Color.Thistle;
            this.rb_lock.Location = new System.Drawing.Point(7, 24);
            this.rb_lock.Margin = new System.Windows.Forms.Padding(4);
            this.rb_lock.Name = "rb_lock";
            this.rb_lock.Size = new System.Drawing.Size(109, 22);
            this.rb_lock.TabIndex = 20;
            this.rb_lock.TabStop = true;
            this.rb_lock.Text = "Zablokuj";
            this.rb_lock.UseVisualStyleBackColor = false;
            this.rb_lock.CheckedChanged += new System.EventHandler(this.RadioButtonChooseKindOfOperationManager);
            // 
            // panel_bottomMenu
            // 
            this.panel_bottomMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_bottomMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bottomMenu.Controls.Add(this.btn_settings);
            this.panel_bottomMenu.Controls.Add(this.lb_messageReceived);
            this.panel_bottomMenu.Controls.Add(this.lb_connectionStatus);
            this.panel_bottomMenu.Controls.Add(this.cb_listenningConnection);
            this.panel_bottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottomMenu.ForeColor = System.Drawing.Color.Black;
            this.panel_bottomMenu.Location = new System.Drawing.Point(0, 476);
            this.panel_bottomMenu.Name = "panel_bottomMenu";
            this.panel_bottomMenu.Size = new System.Drawing.Size(573, 50);
            this.panel_bottomMenu.TabIndex = 26;
            this.panel_bottomMenu.MouseEnter += new System.EventHandler(this.panel_bottomMenu_MouseEnter);
            this.panel_bottomMenu.MouseLeave += new System.EventHandler(this.panel_bottomMenu_MouseLeave);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Orange;
            this.btn_settings.Image = global::MovieKillerDesktopApp.Properties.Resources.iconSettings1;
            this.btn_settings.Location = new System.Drawing.Point(11, -1);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(55, 50);
            this.btn_settings.TabIndex = 26;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.MouseEnter += new System.EventHandler(this.panel_bottomMenu_MouseEnter);
            // 
            // lb_messageReceived
            // 
            this.lb_messageReceived.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_messageReceived.Location = new System.Drawing.Point(364, 6);
            this.lb_messageReceived.Name = "lb_messageReceived";
            this.lb_messageReceived.Size = new System.Drawing.Size(204, 37);
            this.lb_messageReceived.TabIndex = 25;
            this.lb_messageReceived.Text = "Użytkownik wydał komendę:";
            this.lb_messageReceived.Visible = false;
            this.lb_messageReceived.MouseEnter += new System.EventHandler(this.panel_bottomMenu_MouseEnter);
            // 
            // cb_listenningConnection
            // 
            this.cb_listenningConnection.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_listenningConnection.BackColor = System.Drawing.Color.Tomato;
            this.cb_listenningConnection.Image = ((System.Drawing.Image)(resources.GetObject("cb_listenningConnection.Image")));
            this.cb_listenningConnection.Location = new System.Drawing.Point(72, -1);
            this.cb_listenningConnection.Name = "cb_listenningConnection";
            this.cb_listenningConnection.Size = new System.Drawing.Size(55, 50);
            this.cb_listenningConnection.TabIndex = 24;
            this.cb_listenningConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_listenningConnection.UseVisualStyleBackColor = false;
            this.cb_listenningConnection.CheckedChanged += new System.EventHandler(this.cbListenningConnection_CheckedChanged);
            this.cb_listenningConnection.MouseEnter += new System.EventHandler(this.panel_bottomMenu_MouseEnter);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(573, 526);
            this.Controls.Add(this.panel_bottomMenu);
            this.Controls.Add(this.gb_operationsCollection);
            this.Controls.Add(this.panel_controlClock);
            this.Controls.Add(this.panel_clock);
            this.Controls.Add(this.gb_setTime);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Opacity = 0.98D;
            this.Text = "MOVIE KILLER";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_seconds)).EndInit();
            this.gb_setTime.ResumeLayout(false);
            this.gb_setTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_inputTimeToStart)).EndInit();
            this.panel_clock.ResumeLayout(false);
            this.panel_clock.PerformLayout();
            this.panel_controlClock.ResumeLayout(false);
            this.gb_operationsCollection.ResumeLayout(false);
            this.gb_operationsCollection.PerformLayout();
            this.panel_bottomMenu.ResumeLayout(false);
            this.panel_bottomMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar_TimeToEnd;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Label lb_endOfOperation;
        private System.Windows.Forms.Timer timer_clock;
        private System.Windows.Forms.NumericUpDown numUD_hours;
        private System.Windows.Forms.NumericUpDown numUD_minutes;
        private System.Windows.Forms.NumericUpDown numUD_seconds;
        private System.Windows.Forms.GroupBox gb_setTime;
        private System.Windows.Forms.RadioButton rb_atTime;
        private System.Windows.Forms.RadioButton rb_timeLeft;
        private System.Windows.Forms.Panel panel_clock;
        private System.Windows.Forms.Label lb_timeToEnd;
        private System.Windows.Forms.Label lb_timeOfEnd;
        private System.Windows.Forms.NumericUpDown numUD_inputTimeToStart;
        private System.Windows.Forms.Label lb_connectionStatus;
        private System.Windows.Forms.CheckBox cb_pauseClock;
        private System.Windows.Forms.Panel panel_controlClock;
        private System.Windows.Forms.Button btn_startClock;
        private System.Windows.Forms.GroupBox gb_operationsCollection;
        private System.Windows.Forms.RadioButton rb_shutDown;
        private System.Windows.Forms.RadioButton rb_restart;
        private System.Windows.Forms.RadioButton rb_sleep;
        private System.Windows.Forms.RadioButton rb_logout;
        private System.Windows.Forms.RadioButton rb_lock;
        private System.Windows.Forms.Button btn_slowDownCountdown;
        private System.Windows.Forms.Button btn_speedUpCountdown;
        private System.Windows.Forms.Button btn_stopClock;
        private System.Windows.Forms.Panel panel_bottomMenu;
        private System.Windows.Forms.CheckBox cb_listenningConnection;
        private System.Windows.Forms.Label lb_messageReceived;
        private System.Windows.Forms.RadioButton rb_alarmClock;
        private System.Windows.Forms.Button btn_settings;
    }
}

