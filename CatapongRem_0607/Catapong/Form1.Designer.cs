namespace Catapong
{
    partial class Catapong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catapong));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.textBox_com = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_com = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_advance = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.txbAbsStep = new System.Windows.Forms.TextBox();
            this.comboBox_Direction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_sliderBack = new System.Windows.Forms.Button();
            this.textBox_serialSend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_launch = new System.Windows.Forms.Button();
            this.button_def = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Auto = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.textBox_launchDist = new System.Windows.Forms.TextBox();
            this.tabPage_quick = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_advance.SuspendLayout();
            this.tabPage_quick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReceivedBytesThreshold = 24;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_baudrate);
            this.groupBox1.Controls.Add(this.label_baudrate);
            this.groupBox1.Controls.Add(this.textBox_com);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label_com);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 125);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SerialPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("SimSun", 10F);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Disconneced";
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(61, 15);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(66, 21);
            this.comboBox_baudrate.TabIndex = 14;
            this.comboBox_baudrate.Text = "9600";
            // 
            // label_baudrate
            // 
            this.label_baudrate.AutoSize = true;
            this.label_baudrate.Font = new System.Drawing.Font("SimSun", 9F);
            this.label_baudrate.Location = new System.Drawing.Point(6, 18);
            this.label_baudrate.Name = "label_baudrate";
            this.label_baudrate.Size = new System.Drawing.Size(59, 12);
            this.label_baudrate.TabIndex = 3;
            this.label_baudrate.Text = "BaudRate:";
            // 
            // textBox_com
            // 
            this.textBox_com.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_com.Location = new System.Drawing.Point(61, 40);
            this.textBox_com.Name = "textBox_com";
            this.textBox_com.Size = new System.Drawing.Size(66, 21);
            this.textBox_com.TabIndex = 5;
            this.textBox_com.Text = "8";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(9, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "OPEN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.Font = new System.Drawing.Font("SimSun", 9F);
            this.label_com.Location = new System.Drawing.Point(6, 43);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(29, 12);
            this.label_com.TabIndex = 4;
            this.label_com.Text = "COM:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_advance);
            this.tabControl1.Controls.Add(this.tabPage_quick);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(152, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 316);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage_advance
            // 
            this.tabPage_advance.Controls.Add(this.button4);
            this.tabPage_advance.Controls.Add(this.txbAbsStep);
            this.tabPage_advance.Controls.Add(this.comboBox_Direction);
            this.tabPage_advance.Controls.Add(this.label5);
            this.tabPage_advance.Controls.Add(this.label4);
            this.tabPage_advance.Controls.Add(this.button_sliderBack);
            this.tabPage_advance.Controls.Add(this.textBox_serialSend);
            this.tabPage_advance.Controls.Add(this.label3);
            this.tabPage_advance.Controls.Add(this.button_launch);
            this.tabPage_advance.Controls.Add(this.button_def);
            this.tabPage_advance.Controls.Add(this.button_reload);
            this.tabPage_advance.Controls.Add(this.label1);
            this.tabPage_advance.Controls.Add(this.button_Auto);
            this.tabPage_advance.Controls.Add(this.button_move);
            this.tabPage_advance.Controls.Add(this.textBox_step);
            this.tabPage_advance.Controls.Add(this.textBox_launchDist);
            this.tabPage_advance.Location = new System.Drawing.Point(4, 22);
            this.tabPage_advance.Name = "tabPage_advance";
            this.tabPage_advance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_advance.Size = new System.Drawing.Size(406, 290);
            this.tabPage_advance.TabIndex = 0;
            this.tabPage_advance.Text = "Advance";
            this.tabPage_advance.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 80);
            this.button4.TabIndex = 35;
            this.button4.Text = "MoveTo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txbAbsStep
            // 
            this.txbAbsStep.Location = new System.Drawing.Point(73, 119);
            this.txbAbsStep.Name = "txbAbsStep";
            this.txbAbsStep.Size = new System.Drawing.Size(53, 20);
            this.txbAbsStep.TabIndex = 34;
            this.txbAbsStep.Text = "1000";
            this.txbAbsStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_Direction
            // 
            this.comboBox_Direction.FormattingEnabled = true;
            this.comboBox_Direction.Items.AddRange(new object[] {
            "left",
            "right"});
            this.comboBox_Direction.Location = new System.Drawing.Point(73, 199);
            this.comboBox_Direction.Name = "comboBox_Direction";
            this.comboBox_Direction.Size = new System.Drawing.Size(53, 21);
            this.comboBox_Direction.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Direction:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Step:";
            // 
            // button_sliderBack
            // 
            this.button_sliderBack.Location = new System.Drawing.Point(258, 182);
            this.button_sliderBack.Name = "button_sliderBack";
            this.button_sliderBack.Size = new System.Drawing.Size(77, 68);
            this.button_sliderBack.TabIndex = 27;
            this.button_sliderBack.Text = "SliderBack";
            this.button_sliderBack.UseVisualStyleBackColor = true;
            this.button_sliderBack.Click += new System.EventHandler(this.button_sliderBack_Click);
            // 
            // textBox_serialSend
            // 
            this.textBox_serialSend.Location = new System.Drawing.Point(6, 259);
            this.textBox_serialSend.Name = "textBox_serialSend";
            this.textBox_serialSend.Size = new System.Drawing.Size(329, 20);
            this.textBox_serialSend.TabIndex = 25;
            this.textBox_serialSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_serialSend_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Position:";
            // 
            // button_launch
            // 
            this.button_launch.Location = new System.Drawing.Point(150, 10);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(75, 80);
            this.button_launch.TabIndex = 12;
            this.button_launch.Text = "Launch";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // button_def
            // 
            this.button_def.Location = new System.Drawing.Point(258, 96);
            this.button_def.Name = "button_def";
            this.button_def.Size = new System.Drawing.Size(75, 39);
            this.button_def.TabIndex = 13;
            this.button_def.Text = "Defance";
            this.button_def.UseVisualStyleBackColor = true;
            this.button_def.Click += new System.EventHandler(this.button_def_Click);
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(258, 10);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(77, 80);
            this.button_reload.TabIndex = 14;
            this.button_reload.Text = "Reload";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Distance:";
            // 
            // button_Auto
            // 
            this.button_Auto.Location = new System.Drawing.Point(258, 141);
            this.button_Auto.Name = "button_Auto";
            this.button_Auto.Size = new System.Drawing.Size(75, 35);
            this.button_Auto.TabIndex = 15;
            this.button_Auto.Text = "Auto";
            this.button_Auto.UseVisualStyleBackColor = true;
            this.button_Auto.Click += new System.EventHandler(this.button_Auto_Click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(150, 182);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(75, 68);
            this.button_move.TabIndex = 19;
            this.button_move.Text = "Move";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(83, 228);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(43, 20);
            this.textBox_step.TabIndex = 21;
            this.textBox_step.Text = "100";
            this.textBox_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_launchDist
            // 
            this.textBox_launchDist.Location = new System.Drawing.Point(83, 28);
            this.textBox_launchDist.Name = "textBox_launchDist";
            this.textBox_launchDist.Size = new System.Drawing.Size(43, 20);
            this.textBox_launchDist.TabIndex = 16;
            this.textBox_launchDist.Text = "92";
            this.textBox_launchDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage_quick
            // 
            this.tabPage_quick.Controls.Add(this.checkBox2);
            this.tabPage_quick.Controls.Add(this.button6);
            this.tabPage_quick.Controls.Add(this.button5);
            this.tabPage_quick.Controls.Add(this.button3);
            this.tabPage_quick.Controls.Add(this.pictureBox1);
            this.tabPage_quick.Controls.Add(this.button1);
            this.tabPage_quick.Controls.Add(this.label6);
            this.tabPage_quick.Controls.Add(this.textBox6);
            this.tabPage_quick.Controls.Add(this.label8);
            this.tabPage_quick.Controls.Add(this.label14);
            this.tabPage_quick.Controls.Add(this.textBox1);
            this.tabPage_quick.Controls.Add(this.textBox5);
            this.tabPage_quick.Controls.Add(this.textBox2);
            this.tabPage_quick.Controls.Add(this.checkBox1);
            this.tabPage_quick.Controls.Add(this.textBox3);
            this.tabPage_quick.Controls.Add(this.label12);
            this.tabPage_quick.Controls.Add(this.label9);
            this.tabPage_quick.Controls.Add(this.label13);
            this.tabPage_quick.Controls.Add(this.label10);
            this.tabPage_quick.Controls.Add(this.textBox4);
            this.tabPage_quick.Controls.Add(this.label11);
            this.tabPage_quick.Location = new System.Drawing.Point(4, 22);
            this.tabPage_quick.Name = "tabPage_quick";
            this.tabPage_quick.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_quick.Size = new System.Drawing.Size(406, 290);
            this.tabPage_quick.TabIndex = 1;
            this.tabPage_quick.Text = "QuickUse";
            this.tabPage_quick.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 20);
            this.button3.TabIndex = 48;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "Slider2Center";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(209, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Position";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(293, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(53, 20);
            this.textBox6.TabIndex = 47;
            this.textBox6.Text = "66";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(209, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Speed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(213, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "BounceOffset";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "1000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(363, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(23, 20);
            this.textBox5.TabIndex = 46;
            this.textBox5.Text = "1";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(293, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "92";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBox1.Location = new System.Drawing.Point(298, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 29);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "Bounce";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(363, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(23, 20);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "12";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(210, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 25);
            this.label12.TabIndex = 42;
            this.label12.Text = "Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "PoseOffset";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(211, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 25);
            this.label13.TabIndex = 41;
            this.label13.Text = "Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "DistOffset";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(363, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(23, 20);
            this.textBox4.TabIndex = 40;
            this.textBox4.Text = "1";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "MultiP";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(134, 175);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(474, 335);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(79, 15);
            this.progressBar1.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Catapong V3";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.Location = new System.Drawing.Point(212, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 59);
            this.button5.TabIndex = 49;
            this.button5.Text = "Defense";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(296, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 20);
            this.button6.TabIndex = 50;
            this.button6.Text = "SliderBack";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBox2.Location = new System.Drawing.Point(28, 241);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(145, 29);
            this.checkBox2.TabIndex = 51;
            this.checkBox2.Text = "AutoDefense";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Catapong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 357);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Catapong";
            this.Text = "Catapong 3.4.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Catapong_FormClosing);
            this.Load += new System.EventHandler(this.Catapong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_advance.ResumeLayout(false);
            this.tabPage_advance.PerformLayout();
            this.tabPage_quick.ResumeLayout(false);
            this.tabPage_quick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.TextBox textBox_com;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_advance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_sliderBack;
        private System.Windows.Forms.TextBox textBox_serialSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.Button button_def;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Auto;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.TextBox textBox_launchDist;
        private System.Windows.Forms.TabPage tabPage_quick;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Direction;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txbAbsStep;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

