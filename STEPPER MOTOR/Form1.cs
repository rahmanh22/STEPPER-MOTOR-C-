using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STEPPER_MOTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            serial_refresh();
        }

        public void serial_refresh()
        {
            c_box_serial.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                c_box_serial.Items.Add(s);
            }
            if(c_box_serial.Items.Count>0) { c_box_serial.SelectedItem = c_box_serial.Items[0]; }

        }

        private void Btn_serial_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (c_box_serial.Items.Count <= 0 ) return;
                serialPort1.PortName = c_box_serial.SelectedItem.ToString();
                serialPort1.BaudRate = 115200;
                serial_close();
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    btn_refresh.Enabled = false;
                    btn_serial_stop.Enabled = true;
                    btn_serial_start.Enabled = false;
                    c_box_serial.Enabled = false;
                    panel2.Enabled = true;
                }
            }
            catch
            {
                serial_close();
                return;
            }
        }

        private void Btn_serial_stop_Click(object sender, EventArgs e)
        {
            serial_close();
        }

        public void serial_close()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            btn_refresh.Enabled = true;
            btn_serial_stop.Enabled = false;
            btn_serial_start.Enabled = true;
            c_box_serial.Enabled = true;
            panel2.Enabled = false;
        }

        //===================================================================================

        private void Btn_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string inv ="+" ;
                if (checkBox_inv.Checked) inv = "-";
                string data = "@" + num_PRM.Value.ToString()+ "A" + num_step.Value.ToString() + "B" + inv + "#";
                serialPort1.Write(data);
            }
        }

        private void Btn_stop_motor_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("!");
            }
        }
    }
}
