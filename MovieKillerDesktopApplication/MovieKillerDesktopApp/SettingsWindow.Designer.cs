namespace MovieKillerDesktopApp
{
    partial class SettingsWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_changeColorOfLabelOptionsForegroundColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_changeColorOfLabelOptionsBackgroundColor = new System.Windows.Forms.Button();
            this.btn_changeColorOfLabelClockForegroundColor = new System.Windows.Forms.Button();
            this.btn_changeColorOfLabelClockBackgroundColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_changeColorOfPanelOptionsBackgroundColor = new System.Windows.Forms.Button();
            this.btn_changeColorOfPanelClockBackground = new System.Windows.Forms.Button();
            this.btn_changeColorOfWindowBackground = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_setToDefault = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_stopTestingSound = new System.Windows.Forms.Button();
            this.btn_testSound = new System.Windows.Forms.Button();
            this.rb_setSound_Custom = new System.Windows.Forms.RadioButton();
            this.rb_setSound_App = new System.Windows.Forms.RadioButton();
            this.cb_collectionOfAvaibleSounds = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tabControl_settings = new System.Windows.Forms.TabControl();
            this.tabPage_colorSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_setTemplateOfColor = new System.Windows.Forms.ComboBox();
            this.tabPage_soundSettings = new System.Windows.Forms.TabPage();
            this.tabPage_connectionSettings = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_passwordInspection = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl_settings.SuspendLayout();
            this.tabPage_colorSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_soundSettings.SuspendLayout();
            this.tabPage_connectionSettings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_changeColorOfLabelOptionsForegroundColor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_changeColorOfLabelOptionsBackgroundColor);
            this.groupBox1.Controls.Add(this.btn_changeColorOfLabelClockForegroundColor);
            this.groupBox1.Controls.Add(this.btn_changeColorOfLabelClockBackgroundColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_changeColorOfPanelOptionsBackgroundColor);
            this.groupBox1.Controls.Add(this.btn_changeColorOfPanelClockBackground);
            this.groupBox1.Controls.Add(this.btn_changeColorOfWindowBackground);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia ręczne";
            // 
            // btn_changeColorOfLabelOptionsForegroundColor
            // 
            this.btn_changeColorOfLabelOptionsForegroundColor.Location = new System.Drawing.Point(223, 189);
            this.btn_changeColorOfLabelOptionsForegroundColor.Name = "btn_changeColorOfLabelOptionsForegroundColor";
            this.btn_changeColorOfLabelOptionsForegroundColor.Size = new System.Drawing.Size(65, 23);
            this.btn_changeColorOfLabelOptionsForegroundColor.TabIndex = 15;
            this.btn_changeColorOfLabelOptionsForegroundColor.Text = "Zmień";
            this.btn_changeColorOfLabelOptionsForegroundColor.UseVisualStyleBackColor = true;
            this.btn_changeColorOfLabelOptionsForegroundColor.Click += new System.EventHandler(this.ColorChangeButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Czcionka opcji do wyboru";
            // 
            // btn_changeColorOfLabelOptionsBackgroundColor
            // 
            this.btn_changeColorOfLabelOptionsBackgroundColor.Location = new System.Drawing.Point(223, 160);
            this.btn_changeColorOfLabelOptionsBackgroundColor.Name = "btn_changeColorOfLabelOptionsBackgroundColor";
            this.btn_changeColorOfLabelOptionsBackgroundColor.Size = new System.Drawing.Size(65, 23);
            this.btn_changeColorOfLabelOptionsBackgroundColor.TabIndex = 13;
            this.btn_changeColorOfLabelOptionsBackgroundColor.Text = "Zmień";
            this.btn_changeColorOfLabelOptionsBackgroundColor.UseVisualStyleBackColor = true;
            this.btn_changeColorOfLabelOptionsBackgroundColor.Click += new System.EventHandler(this.ColorChangeButtonClick);
            // 
            // btn_changeColorOfLabelClockForegroundColor
            // 
            this.btn_changeColorOfLabelClockForegroundColor.Location = new System.Drawing.Point(223, 131);
            this.btn_changeColorOfLabelClockForegroundColor.Name = "btn_changeColorOfLabelClockForegroundColor";
            this.btn_changeColorOfLabelClockForegroundColor.Size = new System.Drawing.Size(65, 23);
            this.btn_changeColorOfLabelClockForegroundColor.TabIndex = 12;
            this.btn_changeColorOfLabelClockForegroundColor.Text = "Zmień";
            this.btn_changeColorOfLabelClockForegroundColor.UseVisualStyleBackColor = true;
            this.btn_changeColorOfLabelClockForegroundColor.Click += new System.EventHandler(this.ColorChangeButtonClick);
            // 
            // btn_changeColorOfLabelClockBackgroundColor
            // 
            this.btn_changeColorOfLabelClockBackgroundColor.Location = new System.Drawing.Point(223, 102);
            this.btn_changeColorOfLabelClockBackgroundColor.Name = "btn_changeColorOfLabelClockBackgroundColor";
            this.btn_changeColorOfLabelClockBackgroundColor.Size = new System.Drawing.Size(65, 23);
            this.btn_changeColorOfLabelClockBackgroundColor.TabIndex = 11;
            this.btn_changeColorOfLabelClockBackgroundColor.Text = "Zmień";
            this.btn_changeColorOfLabelClockBackgroundColor.UseVisualStyleBackColor = true;
            this.btn_changeColorOfLabelClockBackgroundColor.Click += new System.EventHandler(this.ColorChangeButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tło opcji do wyboru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Czcionka wyświetlacza godziny";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tło wyświetlacza godziny";
            // 
            // btn_changeColorOfPanelOptionsBackgroundColor
            // 
            this.btn_changeColorOfPanelOptionsBackgroundColor.Location = new System.Drawing.Point(223, 75);
            this.btn_changeColorOfPanelOptionsBackgroundColor.Name = "btn_changeColorOfPanelOptionsBackgroundColor";
            this.btn_changeColorOfPanelOptionsBackgroundColor.Size = new System.Drawing.Size(65, 23);
            this.btn_changeColorOfPanelOptionsBackgroundColor.TabIndex = 6;
            this.btn_changeColorOfPanelOptionsBackgroundColor.Text = "Zmień";
            this.btn_changeColorOfPanelOptionsBackgroundColor.UseVisualStyleBackColor = true;
            this.btn_changeColorOfPanelOptionsBackgroundColor.Click += new System.EventHandler(this.ColorChangeButtonClick);
            // 
            // btn_changeColorOfPanelClockBackground
            // 
            this.btn_changeColorOfPanelClockBackground.Location = new System.Drawing.Point(223, 46);
            this.btn_changeColorOfPanelClockBackground.Name = "btn_changeColorOfPanelClockBackground";
            this.btn_changeColorOfPanelClockBackground.Size = new System.Drawing.Size(65, 23);
            this.btn_changeColorOfPanelClockBackground.TabIndex = 5;
            this.btn_changeColorOfPanelClockBackground.Text = "Zmień";
            this.btn_changeColorOfPanelClockBackground.UseVisualStyleBackColor = true;
            this.btn_changeColorOfPanelClockBackground.Click += new System.EventHandler(this.ColorChangeButtonClick);
            // 
            // btn_changeColorOfWindowBackground
            // 
            this.btn_changeColorOfWindowBackground.Location = new System.Drawing.Point(223, 17);
            this.btn_changeColorOfWindowBackground.Name = "btn_changeColorOfWindowBackground";
            this.btn_changeColorOfWindowBackground.Size = new System.Drawing.Size(65, 23);
            this.btn_changeColorOfWindowBackground.TabIndex = 4;
            this.btn_changeColorOfWindowBackground.Text = "Zmień";
            this.btn_changeColorOfWindowBackground.UseVisualStyleBackColor = true;
            this.btn_changeColorOfWindowBackground.Click += new System.EventHandler(this.ColorChangeButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tło paneli opcji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tło zegara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tło okna";
            // 
            // btn_setToDefault
            // 
            this.btn_setToDefault.Location = new System.Drawing.Point(191, 356);
            this.btn_setToDefault.Name = "btn_setToDefault";
            this.btn_setToDefault.Size = new System.Drawing.Size(154, 74);
            this.btn_setToDefault.TabIndex = 7;
            this.btn_setToDefault.Text = "Przywróć ustawienia fabryczne";
            this.btn_setToDefault.UseVisualStyleBackColor = true;
            this.btn_setToDefault.Click += new System.EventHandler(this.btn_settingsToDefault);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_stopTestingSound);
            this.groupBox3.Controls.Add(this.btn_testSound);
            this.groupBox3.Controls.Add(this.rb_setSound_Custom);
            this.groupBox3.Controls.Add(this.rb_setSound_App);
            this.groupBox3.Controls.Add(this.cb_collectionOfAvaibleSounds);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ustawienia dźwięku budzika";
            // 
            // btn_stopTestingSound
            // 
            this.btn_stopTestingSound.BackColor = System.Drawing.Color.LightCoral;
            this.btn_stopTestingSound.Image = global::MovieKillerDesktopApp.Properties.Resources.stopPlaying3;
            this.btn_stopTestingSound.Location = new System.Drawing.Point(71, 108);
            this.btn_stopTestingSound.Name = "btn_stopTestingSound";
            this.btn_stopTestingSound.Size = new System.Drawing.Size(44, 38);
            this.btn_stopTestingSound.TabIndex = 7;
            this.btn_stopTestingSound.UseVisualStyleBackColor = false;
            this.btn_stopTestingSound.Click += new System.EventHandler(this.btn_stopTestingSound_Click);
            // 
            // btn_testSound
            // 
            this.btn_testSound.BackColor = System.Drawing.Color.LightGreen;
            this.btn_testSound.Image = global::MovieKillerDesktopApp.Properties.Resources.iconPlay1;
            this.btn_testSound.Location = new System.Drawing.Point(21, 108);
            this.btn_testSound.Name = "btn_testSound";
            this.btn_testSound.Size = new System.Drawing.Size(44, 38);
            this.btn_testSound.TabIndex = 6;
            this.btn_testSound.UseVisualStyleBackColor = false;
            this.btn_testSound.Click += new System.EventHandler(this.btn_testSound_Click);
            // 
            // rb_setSound_Custom
            // 
            this.rb_setSound_Custom.AutoSize = true;
            this.rb_setSound_Custom.Location = new System.Drawing.Point(25, 51);
            this.rb_setSound_Custom.Name = "rb_setSound_Custom";
            this.rb_setSound_Custom.Size = new System.Drawing.Size(121, 21);
            this.rb_setSound_Custom.TabIndex = 5;
            this.rb_setSound_Custom.TabStop = true;
            this.rb_setSound_Custom.Text = "Własny dźwięk";
            this.rb_setSound_Custom.UseVisualStyleBackColor = true;
            this.rb_setSound_Custom.Click += new System.EventHandler(this.ManageRadioButtons);
            // 
            // rb_setSound_App
            // 
            this.rb_setSound_App.AutoSize = true;
            this.rb_setSound_App.Location = new System.Drawing.Point(25, 24);
            this.rb_setSound_App.Name = "rb_setSound_App";
            this.rb_setSound_App.Size = new System.Drawing.Size(130, 21);
            this.rb_setSound_App.TabIndex = 3;
            this.rb_setSound_App.TabStop = true;
            this.rb_setSound_App.Text = "Dźwięki aplikacji";
            this.rb_setSound_App.UseVisualStyleBackColor = true;
            this.rb_setSound_App.Click += new System.EventHandler(this.ManageRadioButtons);
            // 
            // cb_collectionOfAvaibleSounds
            // 
            this.cb_collectionOfAvaibleSounds.FormattingEnabled = true;
            this.cb_collectionOfAvaibleSounds.Items.AddRange(new object[] {
            "Alarm 1",
            "Alarm 2",
            "Alarm 3",
            "Alarm 4",
            "Alarm 5"});
            this.cb_collectionOfAvaibleSounds.Location = new System.Drawing.Point(22, 78);
            this.cb_collectionOfAvaibleSounds.Name = "cb_collectionOfAvaibleSounds";
            this.cb_collectionOfAvaibleSounds.Size = new System.Drawing.Size(178, 24);
            this.cb_collectionOfAvaibleSounds.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Location = new System.Drawing.Point(12, 356);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(173, 74);
            this.btn_saveChanges.TabIndex = 6;
            this.btn_saveChanges.Text = "Zatwierdź zmiany";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // tabControl_settings
            // 
            this.tabControl_settings.Controls.Add(this.tabPage_colorSettings);
            this.tabControl_settings.Controls.Add(this.tabPage_soundSettings);
            this.tabControl_settings.Controls.Add(this.tabPage_connectionSettings);
            this.tabControl_settings.Location = new System.Drawing.Point(12, 12);
            this.tabControl_settings.Multiline = true;
            this.tabControl_settings.Name = "tabControl_settings";
            this.tabControl_settings.SelectedIndex = 0;
            this.tabControl_settings.Size = new System.Drawing.Size(340, 342);
            this.tabControl_settings.TabIndex = 8;
            // 
            // tabPage_colorSettings
            // 
            this.tabPage_colorSettings.Controls.Add(this.groupBox2);
            this.tabPage_colorSettings.Controls.Add(this.groupBox1);
            this.tabPage_colorSettings.Location = new System.Drawing.Point(4, 46);
            this.tabPage_colorSettings.Name = "tabPage_colorSettings";
            this.tabPage_colorSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_colorSettings.Size = new System.Drawing.Size(332, 292);
            this.tabPage_colorSettings.TabIndex = 0;
            this.tabPage_colorSettings.Text = "Ustawienia koloru";
            this.tabPage_colorSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_setTemplateOfColor);
            this.groupBox2.Location = new System.Drawing.Point(6, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustaw szablon";
            // 
            // cb_setTemplateOfColor
            // 
            this.cb_setTemplateOfColor.FormattingEnabled = true;
            this.cb_setTemplateOfColor.Items.AddRange(new object[] {
            "Szablon1",
            "Szablon2",
            "Szablon3",
            "Szablon4",
            "Szablon5",
            "Ustawienia domyślne"});
            this.cb_setTemplateOfColor.Location = new System.Drawing.Point(9, 21);
            this.cb_setTemplateOfColor.Name = "cb_setTemplateOfColor";
            this.cb_setTemplateOfColor.Size = new System.Drawing.Size(231, 24);
            this.cb_setTemplateOfColor.TabIndex = 0;
            this.cb_setTemplateOfColor.Text = "Wybierz szablon";
            this.cb_setTemplateOfColor.SelectedIndexChanged += new System.EventHandler(this.cb_setTemplateOfColor_SelectedIndexChanged);
            // 
            // tabPage_soundSettings
            // 
            this.tabPage_soundSettings.Controls.Add(this.groupBox3);
            this.tabPage_soundSettings.Location = new System.Drawing.Point(4, 46);
            this.tabPage_soundSettings.Name = "tabPage_soundSettings";
            this.tabPage_soundSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_soundSettings.Size = new System.Drawing.Size(332, 292);
            this.tabPage_soundSettings.TabIndex = 1;
            this.tabPage_soundSettings.Text = "Ustawienia dźwięku";
            this.tabPage_soundSettings.UseVisualStyleBackColor = true;
            // 
            // tabPage_connectionSettings
            // 
            this.tabPage_connectionSettings.Controls.Add(this.groupBox5);
            this.tabPage_connectionSettings.Controls.Add(this.groupBox4);
            this.tabPage_connectionSettings.Location = new System.Drawing.Point(4, 46);
            this.tabPage_connectionSettings.Name = "tabPage_connectionSettings";
            this.tabPage_connectionSettings.Size = new System.Drawing.Size(332, 292);
            this.tabPage_connectionSettings.TabIndex = 2;
            this.tabPage_connectionSettings.Text = "Ustawienia łączności";
            this.tabPage_connectionSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_passwordInspection);
            this.groupBox5.Location = new System.Drawing.Point(3, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 62);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kontrola hasła";
            // 
            // cb_passwordInspection
            // 
            this.cb_passwordInspection.AutoSize = true;
            this.cb_passwordInspection.Checked = true;
            this.cb_passwordInspection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_passwordInspection.Location = new System.Drawing.Point(11, 21);
            this.cb_passwordInspection.Name = "cb_passwordInspection";
            this.cb_passwordInspection.Size = new System.Drawing.Size(92, 21);
            this.cb_passwordInspection.TabIndex = 2;
            this.cb_passwordInspection.Text = "Włączona";
            this.cb_passwordInspection.UseVisualStyleBackColor = true;
            this.cb_passwordInspection.CheckedChanged += new System.EventHandler(this.cb_passwordInspection_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btn_changePassword);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 94);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ustaw hasło";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 34);
            this.label8.TabIndex = 2;
            this.label8.Text = "Zmiana hasła potrzebnego do połączenia się \r\nzewnętrznego urządzenia z aplikacją";
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(198, 55);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(116, 24);
            this.btn_changePassword.TabIndex = 2;
            this.btn_changePassword.Text = "Zmień hasło";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 444);
            this.Controls.Add(this.btn_setToDefault);
            this.Controls.Add(this.tabControl_settings);
            this.Controls.Add(this.btn_saveChanges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SettingsWindow";
            this.Text = "Ustawienia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl_settings.ResumeLayout(false);
            this.tabPage_colorSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage_soundSettings.ResumeLayout(false);
            this.tabPage_connectionSettings.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_setSound_Custom;
        private System.Windows.Forms.RadioButton rb_setSound_App;
        private System.Windows.Forms.ComboBox cb_collectionOfAvaibleSounds;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Button btn_testSound;
        private System.Windows.Forms.Button btn_changeColorOfPanelOptionsBackgroundColor;
        private System.Windows.Forms.Button btn_changeColorOfPanelClockBackground;
        private System.Windows.Forms.Button btn_changeColorOfWindowBackground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btn_setToDefault;
        private System.Windows.Forms.Button btn_changeColorOfLabelOptionsBackgroundColor;
        private System.Windows.Forms.Button btn_changeColorOfLabelClockForegroundColor;
        private System.Windows.Forms.Button btn_changeColorOfLabelClockBackgroundColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_changeColorOfLabelOptionsForegroundColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl_settings;
        private System.Windows.Forms.TabPage tabPage_colorSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_setTemplateOfColor;
        private System.Windows.Forms.TabPage tabPage_soundSettings;
        private System.Windows.Forms.TabPage tabPage_connectionSettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cb_passwordInspection;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_stopTestingSound;
    }
}