namespace Chronometer
{
    partial class Form1
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
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.progressBarSecond = new System.Windows.Forms.ProgressBar();
            this.progressBarMinute = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BackColor = System.Drawing.Color.Transparent;
            this.lblSecond.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSecond.Location = new System.Drawing.Point(60, 40);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(90, 33);
            this.lblSecond.TabIndex = 0;
            this.lblSecond.Text = "Second:";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.BackColor = System.Drawing.Color.Transparent;
            this.lblMinute.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinute.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinute.Location = new System.Drawing.Point(60, 90);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(89, 33);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "Minute:";
            // 
            // txtSecond
            // 
            this.txtSecond.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecond.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSecond.Location = new System.Drawing.Point(188, 42);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.ReadOnly = true;
            this.txtSecond.Size = new System.Drawing.Size(56, 29);
            this.txtSecond.TabIndex = 2;
            this.txtSecond.Text = "00";
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMinute
            // 
            this.txtMinute.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinute.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMinute.Location = new System.Drawing.Point(188, 94);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.ReadOnly = true;
            this.txtMinute.Size = new System.Drawing.Size(56, 29);
            this.txtMinute.TabIndex = 4;
            this.txtMinute.Text = "00";
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // progressBarSecond
            // 
            this.progressBarSecond.Location = new System.Drawing.Point(274, 42);
            this.progressBarSecond.MarqueeAnimationSpeed = 60;
            this.progressBarSecond.Maximum = 60;
            this.progressBarSecond.Name = "progressBarSecond";
            this.progressBarSecond.Size = new System.Drawing.Size(484, 31);
            this.progressBarSecond.TabIndex = 5;
            // 
            // progressBarMinute
            // 
            this.progressBarMinute.Location = new System.Drawing.Point(274, 94);
            this.progressBarMinute.Name = "progressBarMinute";
            this.progressBarMinute.Size = new System.Drawing.Size(484, 31);
            this.progressBarMinute.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(188, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 34);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(348, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinish.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFinish.Location = new System.Drawing.Point(523, 146);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(108, 34);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chronometer.Properties.Resources.chasy_budilnik_vremya_4010;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBarMinute);
            this.Controls.Add(this.progressBarSecond);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblSecond);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.ProgressBar progressBarSecond;
        private System.Windows.Forms.ProgressBar progressBarMinute;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Timer timer1;
    }
}

