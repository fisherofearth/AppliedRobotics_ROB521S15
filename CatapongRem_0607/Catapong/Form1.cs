using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catapong
{
    public partial class Catapong : Form
    {
        public Catapong()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchSerialPort1();
        }
        private void SwitchSerialPort1()
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Close();
                    button2.Text = "OPEN";
                    label2.BackColor = Color.Red;
                    label2.Text = "Disconneced";
                    tabControl1.Enabled = false;
                    //button1.Enabled = false;
                }
                else
                {
                    serialPort1.PortName = "COM" + Convert.ToInt32(textBox_com.Text);
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_baudrate.Text);
                    serialPort1.Open();
                    button2.Text = "CLOSE";
                    label2.Text = "Connected";
                    label2.BackColor = Color.Green;
                    tabControl1.Enabled = true;
                    //button1.Enabled = true;

                }
            }
            catch
            {
                MessageBox.Show("ERROR", "Error");
            }
        }

        private void Catapong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                SwitchSerialPort1();
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {

            serialPort1.Write(textBox_launchDist.Text + "04");
            delay(1000);
        }

        private void textBox_serialSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                serialPort1.Write(textBox_serialSend.Text);
                textBox_serialSend.Text = "";
            }
        }

        private void button_def_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            delay(1000);
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
            delay(1000);
        }

        private void button_sliderBack_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1" + "7000" + "03");
            delay(1000);
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            string dir;
            if (comboBox_Direction.SelectedItem.ToString() == "left") dir = "2";
            else dir = "1";
            string steps0 = "";
            for (int L = 0; L < (4 - textBox_step.Text.Length); L++)
            {
                steps0 += "0";
            }
            serialPort1.Write(dir + steps0 + textBox_step.Text + "03");
            delay(1000);
        }

        Point[] cupPositions = new Point[6];

        private void timer1_Tick(object sender, EventArgs e)
        {
     
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            serialPort1.Write("06");
            //timer1.Enabled = true;

            //timer1.Start();
        }

        int countCV = 0;
        int counttest = 0;
        byte[] dataCOM = new byte[24];
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            counttest++;
            serialPort1.Read(dataCOM, 0, 24);
            //string a = serialPort1.ReadExisting();
                //serialPort1.Read(dataCOM, 0, 12);
            for (int i = 0; i < 6; i++)
            {
                cupPositions[i].X = (((int)dataCOM[i * 4 + 0]) * 16) + ((int)dataCOM[i * 4 + 1]);
                cupPositions[i].Y = (((int)dataCOM[i * 4 + 2]) * 16) + ((int)dataCOM[i * 4 + 3]);
            }
            this.BeginInvoke(new mydele(RefreshCups));
  
        }
        private delegate void mydele();
         private void RefreshCups()
        {
            
            richTextBox1.Text = "";
            for (int i = 0; i < 6; i++)
            {
                richTextBox1.Text += cupPositions[i].ToString() + "\n";
            }
        }

         private void button_Auto_Click(object sender, EventArgs e)
         {
             serialPort1.Write("08");
             delay(1000);
         }

         private void button4_Click(object sender, EventArgs e)
         {
             string zeros = "";
             for(int i = 0; i < 4 - txbAbsStep.Text.Length;i++)
             {
                 zeros += "0";
             }
             string data = "10" + zeros + txbAbsStep.Text + "07";
             serialPort1.Write(data);
             delay(1000);
         }

         float XX = 0;
         float YY = 0;
         private void pictureBox1_Click(object sender, EventArgs e)
         {
            
         }

         private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
         {
             label6.Text = (Convert.ToInt16(((pictureBox1.Width / 2) - e.X) * Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox1.Text))).ToString();
             if (checkBox1.Checked == false)
             {
                 label8.Text = (Convert.ToInt16((((pictureBox1.Height / 2) - e.Y) * Convert.ToDouble(textBox4.Text) / 10) + Convert.ToDouble(textBox2.Text))).ToString();
             }
             else
             {
                 label8.Text = (Convert.ToInt16((((pictureBox1.Height / 2) - e.Y) * Convert.ToDouble(textBox5.Text) / 20) + Convert.ToDouble(textBox6.Text))).ToString();
             }
             
         }


         private void button1_Click(object sender, EventArgs e)
         {
             string zeros = "";
             for (int i = 0; i < 4 - textBox1.Text.Length; i++)
             {
                 zeros += "0";
             }
             string data = "10" + zeros + textBox1.Text + "07";
             serialPort1.Write(data);
             delay(1000);
         }

         private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
         {
             label13.Text = label6.Text;
             label12.Text = label8.Text;
             testNum++;

             //Bitmap myBitmap = new Bitmap(pictureBox1.Image);
             Graphics g = Graphics.FromImage(pictureBox1.Image);

            
             g.DrawEllipse(new Pen(Color.Red, 3), (e.X * 810)/200 -50, (e.Y* 810)/200-50, 100, 100);
             g.DrawString(testNum.ToString(), new Font("Arial", 50), Brushes.Red, (e.X * 810) / 200 - 50, (e.Y * 810) / 200 - 50);
             g.Dispose();  
             this.pictureBox1.Refresh();

             string zeros = "";
             for (int i = 0; i < 4 - label12.Text.Length; i++)
             {
                 zeros += "0";
             }
             string data = label13.Text + zeros + label12.Text + "09";

             serialPort1.Write(data);
             delay(1000);
             
         }

         int testNum = 0;
         private void button3_Click(object sender, EventArgs e)
         {
             testNum = 0;
             pictureBox1.Load("bg.png");
         }

         private void Catapong_Load(object sender, EventArgs e)
         { 
         }

         private void button5_Click(object sender, EventArgs e)
         {
             serialPort1.Write("11");
             delay(1000);
         }

         private void button6_Click(object sender, EventArgs e)
         {
             serialPort1.Write("1" + "7000" + "03");
             delay(1000);
         }

         private void checkBox2_CheckedChanged(object sender, EventArgs e)
         {
             if(checkBox2.Checked == true)
                 serialPort1.Write("1" + "12");
             else
                 serialPort1.Write("0" + "12"); 
         }

        
         private void delay(int time_ms)
         {
             tabControl1.Enabled = false;
             timer2.Interval = time_ms;
             timer2.Enabled = true;
             timer2.Start();
         }


         private void timer2_Tick(object sender, EventArgs e)
         {
             tabControl1.Enabled = true;
             timer2.Stop();
             timer2.Enabled = false;

         }
    }
}
