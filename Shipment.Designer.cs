namespace WindowsFormsApp1
{
    partial class Shipment
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
            this.s6 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.s5 = new System.Windows.Forms.TextBox();
            this.s4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.s7 = new System.Windows.Forms.Button();
            this.s2 = new System.Windows.Forms.ComboBox();
            this.s3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.s8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // s6
            // 
            this.s6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.s6.FormattingEnabled = true;
            this.s6.Location = new System.Drawing.Point(260, 545);
            this.s6.Name = "s6";
            this.s6.Size = new System.Drawing.Size(561, 28);
            this.s6.TabIndex = 32;
            this.s6.SelectedIndexChanged += new System.EventHandler(this.s6_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Date";
            // 
            // s1
            // 
            this.s1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.s1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1.Location = new System.Drawing.Point(260, 185);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(561, 39);
            this.s1.TabIndex = 27;
            this.s1.TextChanged += new System.EventHandler(this.S1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Shipment ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Truck";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Driver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(70, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "+ Create New Shipment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(260, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 65);
            this.label1.TabIndex = 22;
            this.label1.Text = "SHIPMENT MANAGMENT ";
            // 
            // s5
            // 
            this.s5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.s5.Location = new System.Drawing.Point(260, 485);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(561, 26);
            this.s5.TabIndex = 36;
            // 
            // s4
            // 
            this.s4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.s4.Location = new System.Drawing.Point(260, 425);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(561, 26);
            this.s4.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = "Destination";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "Status";
            // 
            // s7
            // 
            this.s7.FlatAppearance.BorderSize = 0;
            this.s7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s7.ForeColor = System.Drawing.Color.Blue;
            this.s7.Location = new System.Drawing.Point(320, 600);
            this.s7.Name = "s7";
            this.s7.Size = new System.Drawing.Size(240, 55);
            this.s7.TabIndex = 37;
            this.s7.Text = "Register Shipment";
            this.s7.UseVisualStyleBackColor = true;
            this.s7.Click += new System.EventHandler(this.s7_Click);
            // 
            // s2
            // 
            this.s2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.s2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2.FormattingEnabled = true;
            this.s2.Location = new System.Drawing.Point(260, 245);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(561, 40);
            this.s2.TabIndex = 38;
            this.s2.SelectedIndexChanged += new System.EventHandler(this.s2_SelectedIndexChanged);
            // 
            // s3
            // 
            this.s3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.s3.FormattingEnabled = true;
            this.s3.Location = new System.Drawing.Point(260, 305);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(561, 28);
            this.s3.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 32);
            this.label6.TabIndex = 40;
            this.label6.Text = "From";
            // 
            // s8
            // 
            this.s8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.s8.Location = new System.Drawing.Point(260, 365);
            this.s8.Name = "s8";
            this.s8.Size = new System.Drawing.Size(561, 26);
            this.s8.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.arrow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Shipment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.shipment;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.s8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s7);
            this.Controls.Add(this.s5);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.s6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Shipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipment";
            this.Load += new System.EventHandler(this.Shipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox s6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox s5;
        private System.Windows.Forms.TextBox s4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button s7;
        private System.Windows.Forms.ComboBox s2;
        private System.Windows.Forms.ComboBox s3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox s8;
        private System.Windows.Forms.Button button1;
    }
}