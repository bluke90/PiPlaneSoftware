
namespace PiPlanePanel
{
    partial class Form1
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
            this.roll = new System.Windows.Forms.Label();
            this.pitch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrackAxis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.yaw = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.throttle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roll
            // 
            this.roll.AutoSize = true;
            this.roll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roll.Location = new System.Drawing.Point(690, 291);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(19, 21);
            this.roll.TabIndex = 0;
            this.roll.Text = "0";
            // 
            // pitch
            // 
            this.pitch.AutoSize = true;
            this.pitch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pitch.Location = new System.Drawing.Point(690, 312);
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(19, 21);
            this.pitch.TabIndex = 1;
            this.pitch.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(640, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roll:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(631, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pitch:";
            // 
            // TrackAxis
            // 
            this.TrackAxis.Location = new System.Drawing.Point(713, 415);
            this.TrackAxis.Name = "TrackAxis";
            this.TrackAxis.Size = new System.Drawing.Size(75, 23);
            this.TrackAxis.TabIndex = 4;
            this.TrackAxis.Text = "Start Tracking";
            this.TrackAxis.UseVisualStyleBackColor = true;
            this.TrackAxis.Click += new System.EventHandler(this.TrackAxis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(639, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yaw:";
            // 
            // yaw
            // 
            this.yaw.AutoSize = true;
            this.yaw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yaw.Location = new System.Drawing.Point(690, 333);
            this.yaw.Name = "yaw";
            this.yaw.Size = new System.Drawing.Size(19, 21);
            this.yaw.TabIndex = 6;
            this.yaw.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(609, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Throttle:";
            // 
            // throttle
            // 
            this.throttle.AutoSize = true;
            this.throttle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.throttle.Location = new System.Drawing.Point(690, 354);
            this.throttle.Name = "throttle";
            this.throttle.Size = new System.Drawing.Size(19, 21);
            this.throttle.TabIndex = 8;
            this.throttle.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.throttle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yaw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrackAxis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pitch);
            this.Controls.Add(this.roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roll;
        private System.Windows.Forms.Label pitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TrackAxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label yaw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label throttle;
    }
}

