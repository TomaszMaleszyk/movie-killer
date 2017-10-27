namespace MovieKillerDesktopApp
{
    partial class ClockDisplayer
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_clock = new System.Windows.Forms.Panel();
            this.lb_endOfOperation = new System.Windows.Forms.Label();
            this.lb_timeOfEnd = new System.Windows.Forms.Label();
            this.lb_timeToEnd = new System.Windows.Forms.Label();
            this.lb_timer = new System.Windows.Forms.Label();
            this.progressBar_TimeToEnd = new System.Windows.Forms.ProgressBar();
            this.panel_clock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_clock
            // 
            this.panel_clock.BackColor = System.Drawing.Color.MediumBlue;
            this.panel_clock.Controls.Add(this.lb_endOfOperation);
            this.panel_clock.Controls.Add(this.lb_timeOfEnd);
            this.panel_clock.Controls.Add(this.lb_timeToEnd);
            this.panel_clock.Controls.Add(this.lb_timer);
            this.panel_clock.Controls.Add(this.progressBar_TimeToEnd);
            this.panel_clock.Location = new System.Drawing.Point(3, 3);
            this.panel_clock.Name = "panel_clock";
            this.panel_clock.Size = new System.Drawing.Size(553, 200);
            this.panel_clock.TabIndex = 17;
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
            // lb_timeOfEnd
            // 
            this.lb_timeOfEnd.AutoSize = true;
            this.lb_timeOfEnd.BackColor = System.Drawing.Color.MediumBlue;
            this.lb_timeOfEnd.ForeColor = System.Drawing.Color.LightBlue;
            this.lb_timeOfEnd.Location = new System.Drawing.Point(184, 125);
            this.lb_timeOfEnd.Name = "lb_timeOfEnd";
            this.lb_timeOfEnd.Size = new System.Drawing.Size(167, 17);
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
            this.lb_timeToEnd.Size = new System.Drawing.Size(219, 17);
            this.lb_timeToEnd.TabIndex = 8;
            this.lb_timeToEnd.Text = "Do wykonania operacji pozostało:";
            this.lb_timeToEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // progressBar_TimeToEnd
            // 
            this.progressBar_TimeToEnd.Location = new System.Drawing.Point(0, 190);
            this.progressBar_TimeToEnd.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_TimeToEnd.Maximum = 10000;
            this.progressBar_TimeToEnd.Name = "progressBar_TimeToEnd";
            this.progressBar_TimeToEnd.Size = new System.Drawing.Size(550, 10);
            this.progressBar_TimeToEnd.TabIndex = 4;
            // 
            // ClockDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_clock);
            this.Name = "ClockDisplayer";
            this.Size = new System.Drawing.Size(558, 203);
            this.panel_clock.ResumeLayout(false);
            this.panel_clock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_clock;
        private System.Windows.Forms.Label lb_endOfOperation;
        private System.Windows.Forms.Label lb_timeOfEnd;
        private System.Windows.Forms.Label lb_timeToEnd;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.ProgressBar progressBar_TimeToEnd;
    }
}
