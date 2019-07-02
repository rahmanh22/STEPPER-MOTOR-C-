namespace STEPPER_MOTOR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_serial_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.c_box_serial = new System.Windows.Forms.ComboBox();
            this.btn_serial_start = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_step = new System.Windows.Forms.NumericUpDown();
            this.checkBox_inv = new System.Windows.Forms.CheckBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.num_PRM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PRM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_serial_stop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.c_box_serial);
            this.panel1.Controls.Add(this.btn_serial_start);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 85);
            this.panel1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(144, 25);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(63, 23);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // btn_serial_stop
            // 
            this.btn_serial_stop.Enabled = false;
            this.btn_serial_stop.Location = new System.Drawing.Point(75, 52);
            this.btn_serial_stop.Name = "btn_serial_stop";
            this.btn_serial_stop.Size = new System.Drawing.Size(63, 23);
            this.btn_serial_stop.TabIndex = 3;
            this.btn_serial_stop.Text = "Stop";
            this.btn_serial_stop.UseVisualStyleBackColor = true;
            this.btn_serial_stop.Click += new System.EventHandler(this.Btn_serial_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial Port:";
            // 
            // c_box_serial
            // 
            this.c_box_serial.FormattingEnabled = true;
            this.c_box_serial.Location = new System.Drawing.Point(6, 25);
            this.c_box_serial.Name = "c_box_serial";
            this.c_box_serial.Size = new System.Drawing.Size(132, 21);
            this.c_box_serial.TabIndex = 1;
            // 
            // btn_serial_start
            // 
            this.btn_serial_start.Location = new System.Drawing.Point(6, 52);
            this.btn_serial_start.Name = "btn_serial_start";
            this.btn_serial_start.Size = new System.Drawing.Size(63, 23);
            this.btn_serial_start.TabIndex = 0;
            this.btn_serial_start.Text = "Start";
            this.btn_serial_start.UseVisualStyleBackColor = true;
            this.btn_serial_start.Click += new System.EventHandler(this.Btn_serial_start_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DiscardNull = true;
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.WriteTimeout = 1000;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.num_step);
            this.panel2.Controls.Add(this.checkBox_inv);
            this.panel2.Controls.Add(this.btn_send);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.num_PRM);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 175);
            this.panel2.TabIndex = 1;
            // 
            // num_step
            // 
            this.num_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_step.Location = new System.Drawing.Point(6, 86);
            this.num_step.Maximum = new decimal(new int[] {
            -1454759936,
            465,
            0,
            0});
            this.num_step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_step.Name = "num_step";
            this.num_step.Size = new System.Drawing.Size(109, 29);
            this.num_step.TabIndex = 9;
            this.num_step.Value = new decimal(new int[] {
            2038,
            0,
            0,
            0});
            // 
            // checkBox_inv
            // 
            this.checkBox_inv.AutoSize = true;
            this.checkBox_inv.Location = new System.Drawing.Point(146, 34);
            this.checkBox_inv.Name = "checkBox_inv";
            this.checkBox_inv.Size = new System.Drawing.Size(61, 17);
            this.checkBox_inv.TabIndex = 7;
            this.checkBox_inv.Text = "Inverse";
            this.checkBox_inv.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(6, 136);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(91, 29);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "Send Config.";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step (2038 is 360 degree):";
            // 
            // num_PRM
            // 
            this.num_PRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_PRM.Location = new System.Drawing.Point(6, 25);
            this.num_PRM.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_PRM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_PRM.Name = "num_PRM";
            this.num_PRM.Size = new System.Drawing.Size(109, 29);
            this.num_PRM.TabIndex = 3;
            this.num_PRM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RPM:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 288);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stepper Motor Control";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PRM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_serial_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox c_box_serial;
        private System.Windows.Forms.Button btn_serial_start;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown num_PRM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.CheckBox checkBox_inv;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.NumericUpDown num_step;
    }
}

