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
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.prgressSecond = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            // prgressSecond
            // 
            this.prgressSecond.Location = new System.Drawing.Point(274, 42);
            this.prgressSecond.Name = "prgressSecond";
            this.prgressSecond.Size = new System.Drawing.Size(484, 31);
            this.prgressSecond.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(274, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(484, 31);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chronometer.Properties.Resources.chasy_budilnik_vremya_4010;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.prgressSecond);
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
        private System.Windows.Forms.ProgressBar prgressSecond;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

